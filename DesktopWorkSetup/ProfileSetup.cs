using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace DesktopWorkSetup
{
	public partial class ProfileSetup : Form
	{
		[DllImport("user32.dll")]
		public static extern bool GetWindowRect(IntPtr hwnd, ref Rect rectangle);

		[DllImport("user32.dll", SetLastError = true)]
		internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

		public struct Rect
		{
			public int Left { get; set; }
			public int Top { get; set; }
			public int Right { get; set; }
			public int Bottom { get; set; }
		}

		private string filePath = string.Empty;
		private string windowName = string.Empty;
		private Rect windowRect = new Rect();

		private readonly List<AppProfile> appProfiles = new List<AppProfile>();

		private string profileToOpen = string.Empty;
		private readonly Login parentForm;

		public ProfileSetup(string wantedprofile, Login _parentForm)
		{
			InitializeComponent();
			profileToOpen = wantedprofile;

			parentForm = _parentForm;
		}

		private void ProfileSetup_DragEnter(object sender, DragEventArgs e)
		{
			if (tbFilePath.Text == string.Empty)
			{
				if (e.Data.GetDataPresent(DataFormats.FileDrop))
				{
					string[] filePaths = (string[])(e.Data.GetData(DataFormats.FileDrop));
					if (filePaths[0] != null)
					{
						filePath = filePaths[0];
						tbFilePath.Text = filePath;
					}
				}
			}
		}

		private void btnClearFilePath_Click(object sender, EventArgs e)
		{
			filePath = tbFilePath.Text = string.Empty;
		}

		private void GrabWindowData()
		{
			Process[] procs = Process.GetProcesses();

			foreach (var proc in procs)
			{
				try
				{
					if (proc.MainWindowTitle == lbOpenProcesses.SelectedItem.ToString())
					{
						GetWindowRect(proc.MainWindowHandle, ref windowRect);

						tbPositionX.Text = windowRect.Left.ToString();
						tbPositionY.Text = windowRect.Top.ToString();
						tbWidth.Text = (windowRect.Right - windowRect.Left).ToString();
						tbHeight.Text = (windowRect.Bottom - windowRect.Top).ToString();

						windowName = lbOpenProcesses.SelectedItem.ToString();
						return;
					}
				}
				catch { }
			}
		}

		private void lbOpenProcesses_SelectedValueChanged(object sender, EventArgs e)
		{
			if (lbOpenProcesses.SelectedItem != null)
			{
				GrabWindowData();
			}
		}

		private void btnTest_Click(object sender, EventArgs e)
		{
			if (filePath == string.Empty)
			{
				ErrorWindow.ShowBox("Error", "No file path.", this);
				return;
			}

			if (windowName == string.Empty)
			{
				ErrorWindow.ShowBox("Error", "Window name not found.", this);
				return;
			}

			btnAddToProfile.Enabled = true;

			if (cbIsWebsite.Checked && !cbIsNewTab.Checked)
			{
				Process process = new Process();
				process.StartInfo.FileName = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
				process.StartInfo.Arguments = filePath + " --new-window";
				process.Start();
			}
			else
			{
				Process.Start(filePath);
			}

			Thread.Sleep((int)nudWaitForSeconds.Value * 1000);
			Process proc = GetWindowProcess(windowName);

			try
			{
				MoveWindow(proc.MainWindowHandle, windowRect.Left, windowRect.Top, windowRect.Right - windowRect.Left, windowRect.Bottom - windowRect.Top, false);

				if (cbCredentials.Checked)
				{
					string test = "TESTING";
					for (int index = 0; index < test.Length; index++)
					{
						SendKeys.SendWait(test[index].ToString());
						Thread.Sleep(10);
					}
				}
			}
			catch
			{
				ErrorWindow.ShowBox("Error", "Program failed to load in time / was not found.", this);
				return;
			}


		}

		private void btnRestart_Click(object sender, EventArgs e)
		{
			ClearInputs();
		}

		private void btnAddToProfile_Click(object sender, EventArgs e)
		{
			if (tbNickname.Text == string.Empty)
			{
				ErrorWindow.ShowBox("Error", "Application profile needs a nickname.", this);
			}
			else if (lbAppProfiles.Items.Contains(tbNickname.Text))
			{
				ErrorWindow.ShowBox("Error", "That nickname is already in use.", this);
			}
			else
			{
				appProfiles.Add(new AppProfile(tbNickname.Text, Int32.Parse(tbPositionX.Text), Int32.Parse(tbPositionY.Text), Int32.Parse(tbWidth.Text), Int32.Parse(tbHeight.Text), filePath, windowName, cbCredentials.Checked, cbAutoLogin.Checked, cbIsWebsite.Checked, cbIsNewTab.Checked, (int)nudWaitForSeconds.Value * 1000));

				lbAppProfiles.Items.Add(tbNickname.Text);

				ClearInputs();
			}

		}

		private void cbIsWebsite_CheckStateChanged(object sender, EventArgs e)
		{
			if (cbIsWebsite.Checked)
			{
				cbIsNewTab.Enabled = true;
				tbFilePath.Enabled = true;
			}
			else
			{
				cbIsNewTab.Checked = false;
				cbIsNewTab.Enabled = false;
				tbFilePath.Enabled = false;
				tbFilePath.Text = string.Empty;
			}
		}

		private void btnFinished_Click(object sender, EventArgs e)
		{
			if (tbProfileName.Text == string.Empty)
			{
				ErrorWindow.ShowBox("Error", "Profile needs a name.", this);
				return;
			}

			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "Desktop Work Setup", tbProfileName.Text);

			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}

			foreach (string file in Directory.GetFiles(path))
			{
				File.Delete(file);
			}

			foreach (AppProfile appProfile in appProfiles)
			{
				File.WriteAllLines(path + "\\" + appProfiles.IndexOf(appProfile) + appProfile.appNickname + ".txt", appProfile.GetToFileFormat());
			}

			parentForm.ProfileFormExit(false);
		}

		private void ProfileSetup_Load(object sender, EventArgs e)
		{
			btnMoveUpSelected.Enabled = false;
			btnMoveDownSelected.Enabled = false;

			btnEditSelected.Enabled = false;
			btnRemoveSelected.Enabled = false;
			btnSaveSelected.Enabled = false;

			btnFinished.Enabled = false;

			if (profileToOpen != string.Empty)
			{
				profileToOpen = profileToOpen.Replace("*", "");

				tbProfileName.Text = profileToOpen;

				string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "Desktop Work Setup", profileToOpen);

				string[] files = Directory.GetFiles(path);

				foreach (string file in files)
				{
					string[] fileLines = File.ReadAllLines(file);
					appProfiles.Add(new AppProfile(fileLines));
					lbAppProfiles.Items.Add(fileLines[0]);
				}

				tbProfileName.Text = profileToOpen;
			}
		}

		private void btnTestAll_Click(object sender, EventArgs e)
		{
			foreach (AppProfile appProfile in appProfiles)
			{
				appProfile.Test(this);
			}

			btnFinished.Enabled = true;
		}

		private void ProfileSetup_FormClosing(object sender, FormClosingEventArgs e)
		{
			parentForm.ProfileFormExit(true);
		}

		private void btnRemoveSelected_Click(object sender, EventArgs e)
		{
			if (lbAppProfiles.SelectedItem != null)
			{
				appProfiles.RemoveAt(lbAppProfiles.SelectedIndex);
				lbAppProfiles.Items.RemoveAt(lbAppProfiles.SelectedIndex);

				btnFinished.Enabled = false;
			}
			else
			{
				ErrorWindow.ShowBox("Error", "No application has been selected.", this);
			}

		}

		private void btnEditSelected_Click(object sender, EventArgs e)
		{
			ClearInputs();

			tbNickname.Text = appProfiles[lbAppProfiles.SelectedIndex].appNickname;
			tbFilePath.Text = filePath = appProfiles[lbAppProfiles.SelectedIndex].filePath;
			windowName = appProfiles[lbAppProfiles.SelectedIndex].windowName;

			cbCredentials.Checked = appProfiles[lbAppProfiles.SelectedIndex].requiresCredentials;
			cbIsWebsite.Checked = appProfiles[lbAppProfiles.SelectedIndex].isWebsite;
			cbIsNewTab.Checked = appProfiles[lbAppProfiles.SelectedIndex].isNewTab;

			tbPositionX.Text = appProfiles[lbAppProfiles.SelectedIndex].positionX.ToString();
			tbPositionY.Text = appProfiles[lbAppProfiles.SelectedIndex].positionY.ToString();
			tbWidth.Text = appProfiles[lbAppProfiles.SelectedIndex].width.ToString();
			tbHeight.Text = appProfiles[lbAppProfiles.SelectedIndex].height.ToString();

			nudWaitForSeconds.Value = appProfiles[lbAppProfiles.SelectedIndex].loadTime / 1000;

			btnFinished.Enabled = false;
		}

		private void btnSaveSelected_Click(object sender, EventArgs e)
		{
			if (lbAppProfiles.SelectedItem.ToString() == tbNickname.Text)
			{
				appProfiles[lbAppProfiles.SelectedIndex] = new AppProfile(tbNickname.Text, Int32.Parse(tbPositionX.Text), Int32.Parse(tbPositionY.Text), Int32.Parse(tbWidth.Text), Int32.Parse(tbHeight.Text), filePath, windowName, cbCredentials.Checked, cbAutoLogin.Checked, cbIsWebsite.Checked, cbIsNewTab.Checked, (int)nudWaitForSeconds.Value * 1000);

				ClearInputs();

				btnFinished.Enabled = false;
			}
		}

		private void btnRunFilePath_Click(object sender, EventArgs e)
		{
			if (tbFilePath.Text == string.Empty)
			{
				ErrorWindow.ShowBox("Error", "File path is needed to continue.", this);
			}
			else
			{
				filePath = tbFilePath.Text;

				Process.Start(filePath);
				Thread.Sleep((int)nudWaitForSeconds.Value * 1000);

				btnRefreshOpenProcess.Enabled = true;

				ShowProcesses();
			}
		}

		private void btnRefreshOpenProcess_Click(object sender, EventArgs e)
		{
			ShowProcesses();
		}

		private void ClearInputs()
		{
			btnClearFilePath.Enabled = true;
			btnNext1.Enabled = true;

			tbFilePath.Text = filePath = string.Empty;
			windowName = string.Empty;

			tbPositionX.Text = string.Empty;
			tbPositionY.Text = string.Empty;
			tbWidth.Text = string.Empty;
			tbHeight.Text = string.Empty;

			lbOpenProcesses.Items.Clear();

			btnAddToProfile.Enabled = false;

			cbIsNewTab.Checked = false;
			cbIsNewTab.Enabled = false;
			cbCredentials.Checked = false;
			cbCredentials.Enabled = true;
			cbIsWebsite.Checked = false;
			cbIsWebsite.Enabled = true;

			tbNickname.Text = string.Empty;
			btnRefreshOpenProcess.Enabled = false;
		}

		private void ShowProcesses()
		{
			lbOpenProcesses.Items.Clear();

			Process[] procs = Process.GetProcesses();

			foreach (var proc in procs)
			{
				try
				{
					if (proc.MainWindowTitle.Length > 0)
					{
						lbOpenProcesses.Items.Add(proc.MainWindowTitle);
					}
				}
				catch { }
			}
		}

		private Process GetWindowProcess(string windowTitle)
		{
			Process[] procs = Process.GetProcesses();

			foreach (var proc in procs)
			{
				try
				{
					if (proc.MainWindowTitle == windowTitle)
					{
						return proc;
					}
				}
				catch { }
			}
			return new Process();
		}

		private void LbAppProfiles_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lbAppProfiles.SelectedItem != null)
			{
				btnMoveUpSelected.Enabled = true;
				btnMoveDownSelected.Enabled = true;

				btnEditSelected.Enabled = true;
				btnRemoveSelected.Enabled = true;
				btnSaveSelected.Enabled = true;
			}
		}

		private void BtnMoveUpSelected_Click(object sender, EventArgs e)
		{
			if (lbAppProfiles.SelectedItem != null)
			{
				if (lbAppProfiles.SelectedIndex - 1 < 0) return;

				int selectedIndex = lbAppProfiles.SelectedIndex;

				AppProfile tempAppProfile = appProfiles[selectedIndex];
				appProfiles[selectedIndex] = appProfiles[selectedIndex - 1];
				appProfiles[selectedIndex - 1] = tempAppProfile;

				object tempObj = lbAppProfiles.SelectedItem;
				lbAppProfiles.Items[selectedIndex] = lbAppProfiles.Items[selectedIndex - 1];
				lbAppProfiles.Items[selectedIndex - 1] = tempObj;

				lbAppProfiles.SelectedIndex--;

				btnFinished.Enabled = false;
			}
		}

		private void BtnMoveDownSelected_Click(object sender, EventArgs e)
		{
			if (lbAppProfiles.SelectedItem != null)
			{
				if (lbAppProfiles.SelectedIndex + 1 >= lbAppProfiles.Items.Count) return;

				int selectedIndex = lbAppProfiles.SelectedIndex;

				AppProfile tempAppProfile = appProfiles[selectedIndex];
				appProfiles[selectedIndex] = appProfiles[selectedIndex + 1];
				appProfiles[selectedIndex + 1] = tempAppProfile;

				object tempObj = lbAppProfiles.SelectedItem;
				lbAppProfiles.Items[selectedIndex] = lbAppProfiles.Items[selectedIndex + 1];
				lbAppProfiles.Items[selectedIndex + 1] = tempObj;

				lbAppProfiles.SelectedIndex++;

				btnFinished.Enabled = false;
			}
		}

		private void BtnRegrabProcessProperties_Click(object sender, EventArgs e)
		{
			if (lbOpenProcesses.SelectedItem != null)
			{
				GrabWindowData();
			}
		}

		private void CbCredentials_CheckedChanged(object sender, EventArgs e)
		{
			if (cbCredentials.Checked)
			{
				cbAutoLogin.Enabled = true;
			}
			else
			{
				cbAutoLogin.Checked = false;
				cbAutoLogin.Enabled = false;
			}
		}
	}
}
