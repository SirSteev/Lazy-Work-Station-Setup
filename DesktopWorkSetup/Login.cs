using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DesktopWorkSetup
{
	public partial class Login : Form
	{
		private ProfileSetup profileSetup;
		readonly List<AppProfile> appProfiles = new List<AppProfile>();

		public string wantedProfile = string.Empty;

		public Login()
		{
			InitializeComponent();
		}

		private void btnRunProfile_Click(object sender, EventArgs e)
		{
			RunProfile();

			this.Activate();

			if (ErrorWindow.ShowBox("Done", "Your desktop has been setup.", this) == DialogResult.OK)
				Application.Exit();
		}

		private void tbPassword_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (lbProfiles.SelectedItem != null)
				{
					btnRunProfile_Click(sender, e);
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			UpdateProfilesList();

			if (lbProfiles.Items.Count > 0)
			{
				lbProfiles.SelectedIndex = 0;
			}

			if (lbProfiles.SelectedItem == null)
			{
				btnDeleteProfile.Enabled = false;
				btnEditProfile.Enabled = false;
			}
		}

		private void lbProfiles_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lbProfiles.SelectedItem != null)
			{
				btnRunSetup.Enabled = true;
				btnDeleteProfile.Enabled = true;
				btnEditProfile.Enabled = true;
			}
			else
			{
				btnRunSetup.Enabled = false;
			}
		}

		private void btnNewProfile_Click(object sender, EventArgs e)
		{
			profileSetup = new ProfileSetup(string.Empty, this);

			Point NewPoint = new Point();

			NewPoint.X = this.Location.X + this.Size.Width / 2 - profileSetup.Size.Width / 2;
			NewPoint.Y = this.Location.Y + this.Size.Height / 2 - profileSetup.Size.Height / 2;

			profileSetup.Location = NewPoint;

			profileSetup.Show();

			this.Visible = false;
		}

		private void btnEditProfile_Click(object sender, EventArgs e)
		{
			if (lbProfiles.SelectedItem != null)
			{
				wantedProfile = lbProfiles.SelectedItem.ToString();
			}

			this.Visible = false;

			profileSetup = new ProfileSetup(wantedProfile, this);

			Point NewPoint = new Point();

			NewPoint.X = this.Location.X + this.Size.Width / 2 - profileSetup.Size.Width / 2;
			NewPoint.Y = this.Location.Y + this.Size.Height / 2 - profileSetup.Size.Height / 2;

			profileSetup.Location = NewPoint;

			profileSetup.Show();
		}

		private void btnDeleteProfile_Click(object sender, EventArgs e)
		{
			if (lbProfiles.SelectedItem != null)
			{
				string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "Desktop Work Setup", lbProfiles.SelectedItem.ToString()).Replace("*", "");

				string[] files = Directory.GetFiles(path);

				try
				{
					foreach (string file in files)
					{
						File.Delete(file);
					}

					Directory.Delete(path);
				}
				catch
				{
					ErrorWindow.ShowBox("Error", "Unknown Item in selected Profile's folder.", this);
				}

				UpdateProfilesList();
			}
			else
			{
				ErrorWindow.ShowBox("Error", "No profile has been selected.", this);
			}
		}

		public void ProfileFormExit(bool userClose)
		{
			if (!userClose)
			{
				profileSetup.Close();
			}

			UpdateProfilesList();

			Point NewPoint = new Point();

			NewPoint.X = profileSetup.Location.X + profileSetup.Size.Width / 2 - this.Size.Width / 2;
			NewPoint.Y = profileSetup.Location.Y + profileSetup.Size.Height / 2 - this.Size.Height / 2;

			this.Location = NewPoint;

			this.Visible = true;
		}

		private void UpdateProfilesList()
		{
			lbProfiles.Items.Clear();

			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "Desktop Work Setup");

			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}

			foreach (string folderName in Directory.GetDirectories(path))
			{
				string[] words = folderName.Split('\\');

				lbProfiles.Items.Add(words[words.Length - 1]);

				string[] files = Directory.GetFiles(folderName);

				foreach (string file in files)
				{
					string[] fileLines = File.ReadAllLines(file);
					if (fileLines[7] == "True")
					{
						lbProfiles.Items[lbProfiles.Items.Count - 1] = lbProfiles.Items[lbProfiles.Items.Count - 1] + "*";
						break;
					}
				}
			}

			btnRunSetup.Enabled = false;
		}

		private void RunProfile()
		{
			btnRunSetup.Enabled = false;
			btnSetupProfile.Enabled = false;
			btnEditProfile.Enabled = false;
			tbUserName.Enabled = false;
			tbPassword.Enabled = false;
			btnDeleteProfile.Enabled = false;
			lbProfiles.Enabled = false;

			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "Desktop Work Setup", lbProfiles.SelectedItem.ToString()).Replace("*", "");

			string[] files = Directory.GetFiles(path);

			foreach (string file in files)
			{
				string[] fileLines = File.ReadAllLines(file);
				appProfiles.Add(new AppProfile(fileLines));
			}

			foreach (AppProfile appProfile in appProfiles)
			{
				appProfile.Run(tbUserName.Text, tbPassword.Text, this);
			}

			tbUserName.Text = string.Empty;
			tbPassword.Text = string.Empty;
		}

		private void btnOpenGitHub_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/SirSteev/Lazy-Work-Station-Setup");
		}
	}
}
