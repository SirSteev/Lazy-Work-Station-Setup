using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;

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

        private List<AppProfile> appProfiles = new List<AppProfile>();

        private string profileToOpen = string.Empty;
        private Login parentForm;

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

        private void lbOpenProcesses_SelectedValueChanged(object sender, EventArgs e)
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

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (filePath == string.Empty)
            {
                MessageBox.Show("No file path.", "Error");
                return;
            }

            if (windowName == string.Empty)
            {
                MessageBox.Show("Window name not found.", "Error");
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
            catch (Exception err)
            {
                MessageBox.Show("Program failed to load in time / was not found.", "Error");
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
                MessageBox.Show("Application profile needs a nickname.", "Error");
            }
            else if (lbAppProfiles.Items.Contains(tbNickname.Text))
            {
                MessageBox.Show("That nickname is already in use.", "Error");
            }
            else
            {
                appProfiles.Add(new AppProfile(tbNickname.Text, Int32.Parse(tbPositionX.Text), Int32.Parse(tbPositionY.Text), Int32.Parse(tbWidth.Text), Int32.Parse(tbHeight.Text), filePath, windowName, cbCredentials.Checked, cbIsWebsite.Checked, cbIsNewTab.Checked, (int)nudWaitForSeconds.Value * 1000));
              
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
                cbIsNewTab.Enabled = false;
                tbFilePath.Enabled = false;
                tbFilePath.Text = string.Empty;
            }
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            if (tbProfileName.Text == string.Empty)
            {
                MessageBox.Show("Profile needs a name.", "Error");
                return;
            }

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "Desktop Work Setup", tbProfileName.Text);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            
            foreach (AppProfile appProfile in appProfiles)
            {
                File.WriteAllLines(path + "\\" + appProfiles.IndexOf(appProfile) + appProfile.appNickname + ".txt", appProfile.GetToFileFormat());
            }

            parentForm.ProfileFormExit(false);
        }

        private void ProfileSetup_Load(object sender, EventArgs e)
        {
            if (profileToOpen != string.Empty)
            {
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
                appProfile.Test();
            }
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
            }
            else
            {
                MessageBox.Show("No application has been selected.", "Error");
            }
            
        }

        private void btnEditSelected_Click(object sender, EventArgs e)
        {
            ClearInputs();

            tbNickname.Text = appProfiles[lbAppProfiles.SelectedIndex].appNickname;
            tbFilePath.Text = appProfiles[lbAppProfiles.SelectedIndex].filePath;

            cbCredentials.Checked = appProfiles[lbAppProfiles.SelectedIndex].requiresCredentials;
            cbIsWebsite.Checked = appProfiles[lbAppProfiles.SelectedIndex].isWebsite;
            cbIsNewTab.Checked = appProfiles[lbAppProfiles.SelectedIndex].isNewTab;

            tbPositionX.Text = appProfiles[lbAppProfiles.SelectedIndex].positionX.ToString();
            tbPositionY.Text = appProfiles[lbAppProfiles.SelectedIndex].positionY.ToString();
            tbWidth.Text = appProfiles[lbAppProfiles.SelectedIndex].width.ToString();
            tbHeight.Text = appProfiles[lbAppProfiles.SelectedIndex].height.ToString();

            nudWaitForSeconds.Value = appProfiles[lbAppProfiles.SelectedIndex].loadTime / 1000;
        }

        private void btnSaveSelected_Click(object sender, EventArgs e)
        {
            if (lbAppProfiles.SelectedItem.ToString() == tbNickname.Text)
            {
                appProfiles[lbAppProfiles.SelectedIndex] = new AppProfile(tbNickname.Text, Int32.Parse(tbPositionX.Text), Int32.Parse(tbPositionY.Text), Int32.Parse(tbWidth.Text), Int32.Parse(tbHeight.Text), filePath, windowName, cbCredentials.Checked, cbIsWebsite.Checked, cbIsNewTab.Checked, (int)nudWaitForSeconds.Value * 1000);
                
                ClearInputs();
            }
        }

        private void btnRunFilePath_Click(object sender, EventArgs e)
        {
            if (tbFilePath.Text == string.Empty)
            {
                MessageBox.Show("File path is needed to continue.", "Error");
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

            tbFilePath.Text = string.Empty;

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
    }
}
