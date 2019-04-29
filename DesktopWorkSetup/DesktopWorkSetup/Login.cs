using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace DesktopWorkSetup
{
    public partial class Login : Form
    {
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        private ProfileSetup profileSetup;
        List<AppProfile> appProfiles = new List<AppProfile>();

        public string wantedProfile = string.Empty;

        public Login()
        {
            InitializeComponent();
        }

        private void btnRunSetup_Click(object sender, EventArgs e)
        {
            if (lbProfiles.SelectedItem != null)
            {
                RunSetup();
            }
            else
            {
                MessageBox.Show("No profile selected.", "Error");
            }
        }
        private void RunSetup()
        {
            btnRunSetup.Enabled = false;
            btnSetupProfile.Enabled = false;
            tbUserName.Enabled = false;
            tbPassword.Enabled = false;
            btnDeleteProfile.Enabled = false;
            lbProfiles.Enabled = false;

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "Desktop Work Setup", lbProfiles.SelectedItem.ToString());

            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                string[] fileLines = File.ReadAllLines(file);
                appProfiles.Add(new AppProfile(fileLines));
            }

            foreach (AppProfile appProfile in appProfiles)
            {
                appProfile.Run(tbUserName.Text, tbPassword.Text);
            }

            if (MessageBox.Show("Your desktop has been setup.", "Done", MessageBoxButtons.OK) == DialogResult.OK)
                Application.Exit();
        }
        
        private void tbPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lbProfiles.SelectedItem != null)
                {
                    RunSetup();
                }
            }
        }

        private void btnSetupProfile_Click(object sender, EventArgs e)
        {
            if (lbProfiles.SelectedItem != null)
            {
                wantedProfile = lbProfiles.SelectedItem.ToString();
            }

            this.Visible = false;

            profileSetup = new ProfileSetup(wantedProfile, this);
            profileSetup.Show();
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
            }

            btnRunSetup.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateProfilesList();

            if (lbProfiles.Items.Count > 0)
            {
                lbProfiles.SelectedIndex = 0;
            }
        }

        private void lbProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbProfiles.SelectedItem != null)
            {
                btnRunSetup.Enabled = true;
            }
            else
            {
                btnRunSetup.Enabled = false;
            }
        }

        public void ProfileFormExit(bool userClose)
        {
            if (!userClose)
            {
                profileSetup.Close();
            }

            UpdateProfilesList();

            this.Visible = true;
            
        }

        private void btnDeleteProfile_Click(object sender, EventArgs e)
        {
            if (lbProfiles.SelectedItem != null)
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "Desktop Work Setup", lbProfiles.SelectedItem.ToString());

                string[] files = Directory.GetFiles(path);

                foreach (string file in files)
                {
                    File.Delete(file);
                }
                
                Directory.Delete(path);

                UpdateProfilesList();
            }
            else
            {
                MessageBox.Show("No profile has been selected.", "Error");
            }
        }
    }
}
