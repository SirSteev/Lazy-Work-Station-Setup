namespace DesktopWorkSetup
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbUserName = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.btnRunSetup = new System.Windows.Forms.Button();
			this.btnSetupProfile = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lbProfiles = new System.Windows.Forms.ListBox();
			this.btnDeleteProfile = new System.Windows.Forms.Button();
			this.btnEditProfile = new System.Windows.Forms.Button();
			this.btnOpenGitHub = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 49);
			this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "User Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 78);
			this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password:";
			// 
			// tbUserName
			// 
			this.tbUserName.Location = new System.Drawing.Point(74, 46);
			this.tbUserName.Margin = new System.Windows.Forms.Padding(1);
			this.tbUserName.Name = "tbUserName";
			this.tbUserName.Size = new System.Drawing.Size(136, 20);
			this.tbUserName.TabIndex = 2;
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(74, 75);
			this.tbPassword.Margin = new System.Windows.Forms.Padding(1);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(136, 20);
			this.tbPassword.TabIndex = 3;
			this.tbPassword.UseSystemPasswordChar = true;
			this.tbPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyUp);
			// 
			// btnRunSetup
			// 
			this.btnRunSetup.Enabled = false;
			this.btnRunSetup.Location = new System.Drawing.Point(11, 105);
			this.btnRunSetup.Name = "btnRunSetup";
			this.btnRunSetup.Size = new System.Drawing.Size(199, 23);
			this.btnRunSetup.TabIndex = 4;
			this.btnRunSetup.Text = "Run Profile";
			this.btnRunSetup.UseVisualStyleBackColor = true;
			this.btnRunSetup.Click += new System.EventHandler(this.btnRunProfile_Click);
			// 
			// btnSetupProfile
			// 
			this.btnSetupProfile.Location = new System.Drawing.Point(11, 326);
			this.btnSetupProfile.Name = "btnSetupProfile";
			this.btnSetupProfile.Size = new System.Drawing.Size(199, 23);
			this.btnSetupProfile.TabIndex = 5;
			this.btnSetupProfile.Text = "New Profile";
			this.btnSetupProfile.UseVisualStyleBackColor = true;
			this.btnSetupProfile.Click += new System.EventHandler(this.btnNewProfile_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 131);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Profiles";
			// 
			// lbProfiles
			// 
			this.lbProfiles.FormattingEnabled = true;
			this.lbProfiles.Location = new System.Drawing.Point(12, 147);
			this.lbProfiles.Name = "lbProfiles";
			this.lbProfiles.Size = new System.Drawing.Size(198, 173);
			this.lbProfiles.TabIndex = 7;
			this.lbProfiles.SelectedIndexChanged += new System.EventHandler(this.lbProfiles_SelectedIndexChanged);
			// 
			// btnDeleteProfile
			// 
			this.btnDeleteProfile.Location = new System.Drawing.Point(11, 384);
			this.btnDeleteProfile.Name = "btnDeleteProfile";
			this.btnDeleteProfile.Size = new System.Drawing.Size(199, 23);
			this.btnDeleteProfile.TabIndex = 9;
			this.btnDeleteProfile.Text = "Delete Profile";
			this.btnDeleteProfile.UseVisualStyleBackColor = true;
			this.btnDeleteProfile.Click += new System.EventHandler(this.btnDeleteProfile_Click);
			// 
			// btnEditProfile
			// 
			this.btnEditProfile.Location = new System.Drawing.Point(11, 355);
			this.btnEditProfile.Name = "btnEditProfile";
			this.btnEditProfile.Size = new System.Drawing.Size(199, 23);
			this.btnEditProfile.TabIndex = 10;
			this.btnEditProfile.Text = "Edit Profile";
			this.btnEditProfile.UseVisualStyleBackColor = true;
			this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
			// 
			// btnOpenGitHub
			// 
			this.btnOpenGitHub.Location = new System.Drawing.Point(11, 436);
			this.btnOpenGitHub.Name = "btnOpenGitHub";
			this.btnOpenGitHub.Size = new System.Drawing.Size(199, 23);
			this.btnOpenGitHub.TabIndex = 11;
			this.btnOpenGitHub.Text = "GitHub Page";
			this.btnOpenGitHub.UseVisualStyleBackColor = true;
			this.btnOpenGitHub.Click += new System.EventHandler(this.btnOpenGitHub_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(202, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "If the Profile does not require cridentials*, ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(196, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "just select the Profile and  \"Run Profile\".";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 410);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(205, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "_________________________________";
			// 
			// Login
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(223, 470);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnOpenGitHub);
			this.Controls.Add(this.btnEditProfile);
			this.Controls.Add(this.btnDeleteProfile);
			this.Controls.Add(this.lbProfiles);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnSetupProfile);
			this.Controls.Add(this.btnRunSetup);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.tbUserName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(1);
			this.MaximizeBox = false;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Profiles";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnRunSetup;
        private System.Windows.Forms.Button btnSetupProfile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbProfiles;
        private System.Windows.Forms.Button btnDeleteProfile;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnOpenGitHub;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}

