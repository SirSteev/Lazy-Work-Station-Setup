namespace DesktopWorkSetup
{
    partial class ProfileSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileSetup));
            this.label1 = new System.Windows.Forms.Label();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.btnClearFilePath = new System.Windows.Forms.Button();
            this.lbOpenProcesses = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPositionX = new System.Windows.Forms.TextBox();
            this.tbPositionY = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lbAppProfiles = new System.Windows.Forms.ListBox();
            this.btnAddToProfile = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.btnTestAll = new System.Windows.Forms.Button();
            this.btnEditSelected = new System.Windows.Forms.Button();
            this.btnFinished = new System.Windows.Forms.Button();
            this.tbNickname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbCredentials = new System.Windows.Forms.CheckBox();
            this.cbIsWebsite = new System.Windows.Forms.CheckBox();
            this.cbIsNewTab = new System.Windows.Forms.CheckBox();
            this.tbProfileName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRefreshOpenProcess = new System.Windows.Forms.Button();
            this.btnSaveSelected = new System.Windows.Forms.Button();
            this.nudWaitForSeconds = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudWaitForSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Drag file you wish to open over the window to get the file path.";
            // 
            // tbFilePath
            // 
            this.tbFilePath.Enabled = false;
            this.tbFilePath.Location = new System.Drawing.Point(15, 139);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(310, 20);
            this.tbFilePath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "File Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "2. After we have the file path click the \"Run File Path\" button.";
            // 
            // btnNext1
            // 
            this.btnNext1.Location = new System.Drawing.Point(15, 178);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(150, 23);
            this.btnNext1.TabIndex = 4;
            this.btnNext1.Text = "Run File Path";
            this.btnNext1.UseVisualStyleBackColor = true;
            this.btnNext1.Click += new System.EventHandler(this.btnRunFilePath_Click);
            // 
            // btnClearFilePath
            // 
            this.btnClearFilePath.Location = new System.Drawing.Point(175, 178);
            this.btnClearFilePath.Name = "btnClearFilePath";
            this.btnClearFilePath.Size = new System.Drawing.Size(150, 23);
            this.btnClearFilePath.TabIndex = 5;
            this.btnClearFilePath.Text = "Clear Path";
            this.btnClearFilePath.UseVisualStyleBackColor = true;
            this.btnClearFilePath.Click += new System.EventHandler(this.btnClearFilePath_Click);
            // 
            // lbOpenProcesses
            // 
            this.lbOpenProcesses.FormattingEnabled = true;
            this.lbOpenProcesses.Location = new System.Drawing.Point(15, 207);
            this.lbOpenProcesses.Name = "lbOpenProcesses";
            this.lbOpenProcesses.Size = new System.Drawing.Size(150, 121);
            this.lbOpenProcesses.TabIndex = 6;
            this.lbOpenProcesses.SelectedValueChanged += new System.EventHandler(this.lbOpenProcesses_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "3. After the file opens position it ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "where you want and select its ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "name in the box to the left.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Position X:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Position Y:";
            // 
            // tbPositionX
            // 
            this.tbPositionX.Enabled = false;
            this.tbPositionX.Location = new System.Drawing.Point(232, 253);
            this.tbPositionX.Name = "tbPositionX";
            this.tbPositionX.Size = new System.Drawing.Size(100, 20);
            this.tbPositionX.TabIndex = 12;
            // 
            // tbPositionY
            // 
            this.tbPositionY.Enabled = false;
            this.tbPositionY.Location = new System.Drawing.Point(232, 279);
            this.tbPositionY.Name = "tbPositionY";
            this.tbPositionY.Size = new System.Drawing.Size(100, 20);
            this.tbPositionY.TabIndex = 13;
            // 
            // tbWidth
            // 
            this.tbWidth.Enabled = false;
            this.tbWidth.Location = new System.Drawing.Point(232, 305);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(100, 20);
            this.tbWidth.TabIndex = 14;
            // 
            // tbHeight
            // 
            this.tbHeight.Enabled = false;
            this.tbHeight.Location = new System.Drawing.Point(232, 331);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(100, 20);
            this.tbHeight.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Width:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(175, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Height:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(320, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "4. After we have all the information, close window and click \"Test\"";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(15, 373);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(150, 23);
            this.btnTest.TabIndex = 19;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(175, 373);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(150, 23);
            this.btnRestart.TabIndex = 20;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lbAppProfiles
            // 
            this.lbAppProfiles.FormattingEnabled = true;
            this.lbAppProfiles.Location = new System.Drawing.Point(338, 9);
            this.lbAppProfiles.Name = "lbAppProfiles";
            this.lbAppProfiles.Size = new System.Drawing.Size(120, 355);
            this.lbAppProfiles.TabIndex = 21;
            // 
            // btnAddToProfile
            // 
            this.btnAddToProfile.Enabled = false;
            this.btnAddToProfile.Location = new System.Drawing.Point(15, 402);
            this.btnAddToProfile.Name = "btnAddToProfile";
            this.btnAddToProfile.Size = new System.Drawing.Size(310, 23);
            this.btnAddToProfile.TabIndex = 22;
            this.btnAddToProfile.Text = "Add To Profile";
            this.btnAddToProfile.UseVisualStyleBackColor = true;
            this.btnAddToProfile.Click += new System.EventHandler(this.btnAddToProfile_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Location = new System.Drawing.Point(338, 402);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(120, 23);
            this.btnRemoveSelected.TabIndex = 23;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // btnTestAll
            // 
            this.btnTestAll.Location = new System.Drawing.Point(15, 431);
            this.btnTestAll.Name = "btnTestAll";
            this.btnTestAll.Size = new System.Drawing.Size(310, 23);
            this.btnTestAll.TabIndex = 24;
            this.btnTestAll.Text = "Test All";
            this.btnTestAll.UseVisualStyleBackColor = true;
            this.btnTestAll.Click += new System.EventHandler(this.btnTestAll_Click);
            // 
            // btnEditSelected
            // 
            this.btnEditSelected.Location = new System.Drawing.Point(338, 431);
            this.btnEditSelected.Name = "btnEditSelected";
            this.btnEditSelected.Size = new System.Drawing.Size(120, 23);
            this.btnEditSelected.TabIndex = 25;
            this.btnEditSelected.Text = "Edit Selected";
            this.btnEditSelected.UseVisualStyleBackColor = true;
            this.btnEditSelected.Click += new System.EventHandler(this.btnEditSelected_Click);
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(15, 486);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(443, 23);
            this.btnFinished.TabIndex = 26;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // tbNickname
            // 
            this.tbNickname.Location = new System.Drawing.Point(225, 113);
            this.tbNickname.Name = "tbNickname";
            this.tbNickname.Size = new System.Drawing.Size(100, 20);
            this.tbNickname.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(222, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Nickname";
            // 
            // cbCredentials
            // 
            this.cbCredentials.AutoSize = true;
            this.cbCredentials.Location = new System.Drawing.Point(15, 103);
            this.cbCredentials.Name = "cbCredentials";
            this.cbCredentials.Size = new System.Drawing.Size(123, 17);
            this.cbCredentials.TabIndex = 29;
            this.cbCredentials.Text = "Requires Credentials";
            this.cbCredentials.UseVisualStyleBackColor = true;
            // 
            // cbIsWebsite
            // 
            this.cbIsWebsite.AutoSize = true;
            this.cbIsWebsite.Location = new System.Drawing.Point(140, 103);
            this.cbIsWebsite.Name = "cbIsWebsite";
            this.cbIsWebsite.Size = new System.Drawing.Size(76, 17);
            this.cbIsWebsite.TabIndex = 30;
            this.cbIsWebsite.Text = "Is Wedsite";
            this.cbIsWebsite.UseVisualStyleBackColor = true;
            this.cbIsWebsite.CheckStateChanged += new System.EventHandler(this.cbIsWebsite_CheckStateChanged);
            // 
            // cbIsNewTab
            // 
            this.cbIsNewTab.AutoSize = true;
            this.cbIsNewTab.Enabled = false;
            this.cbIsNewTab.Location = new System.Drawing.Point(140, 122);
            this.cbIsNewTab.Name = "cbIsNewTab";
            this.cbIsNewTab.Size = new System.Drawing.Size(81, 17);
            this.cbIsNewTab.TabIndex = 31;
            this.cbIsNewTab.Text = "Is New Tab";
            this.cbIsNewTab.UseVisualStyleBackColor = true;
            // 
            // tbProfileName
            // 
            this.tbProfileName.Location = new System.Drawing.Point(88, 460);
            this.tbProfileName.Name = "tbProfileName";
            this.tbProfileName.Size = new System.Drawing.Size(371, 20);
            this.tbProfileName.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 463);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Profile Name:";
            // 
            // btnRefreshOpenProcess
            // 
            this.btnRefreshOpenProcess.Enabled = false;
            this.btnRefreshOpenProcess.Location = new System.Drawing.Point(114, 331);
            this.btnRefreshOpenProcess.Name = "btnRefreshOpenProcess";
            this.btnRefreshOpenProcess.Size = new System.Drawing.Size(52, 23);
            this.btnRefreshOpenProcess.TabIndex = 34;
            this.btnRefreshOpenProcess.Text = "Refresh";
            this.btnRefreshOpenProcess.UseVisualStyleBackColor = true;
            this.btnRefreshOpenProcess.Click += new System.EventHandler(this.btnRefreshOpenProcess_Click);
            // 
            // btnSaveSelected
            // 
            this.btnSaveSelected.Location = new System.Drawing.Point(338, 373);
            this.btnSaveSelected.Name = "btnSaveSelected";
            this.btnSaveSelected.Size = new System.Drawing.Size(120, 23);
            this.btnSaveSelected.TabIndex = 35;
            this.btnSaveSelected.Text = "Save Selected";
            this.btnSaveSelected.UseVisualStyleBackColor = true;
            this.btnSaveSelected.Click += new System.EventHandler(this.btnSaveSelected_Click);
            // 
            // nudWaitForSeconds
            // 
            this.nudWaitForSeconds.Location = new System.Drawing.Point(39, 334);
            this.nudWaitForSeconds.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudWaitForSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWaitForSeconds.Name = "nudWaitForSeconds";
            this.nudWaitForSeconds.Size = new System.Drawing.Size(27, 20);
            this.nudWaitForSeconds.TabIndex = 36;
            this.nudWaitForSeconds.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 336);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Wait";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(66, 336);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Seconds";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(318, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "Or, if you wish to open a Website, check \"Is Website\" then paste ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "the link in the \"File Path\"";
            // 
            // ProfileSetup
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 521);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.nudWaitForSeconds);
            this.Controls.Add(this.btnSaveSelected);
            this.Controls.Add(this.btnRefreshOpenProcess);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbProfileName);
            this.Controls.Add(this.cbIsNewTab);
            this.Controls.Add(this.cbIsWebsite);
            this.Controls.Add(this.cbCredentials);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbNickname);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.btnEditSelected);
            this.Controls.Add(this.btnTestAll);
            this.Controls.Add(this.btnRemoveSelected);
            this.Controls.Add(this.btnAddToProfile);
            this.Controls.Add(this.lbAppProfiles);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.tbPositionY);
            this.Controls.Add(this.tbPositionX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbOpenProcesses);
            this.Controls.Add(this.btnClearFilePath);
            this.Controls.Add(this.btnNext1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProfileSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile Setup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProfileSetup_FormClosing);
            this.Load += new System.EventHandler(this.ProfileSetup_Load);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.ProfileSetup_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.nudWaitForSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.Button btnClearFilePath;
        private System.Windows.Forms.ListBox lbOpenProcesses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPositionX;
        private System.Windows.Forms.TextBox tbPositionY;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.ListBox lbAppProfiles;
        private System.Windows.Forms.Button btnAddToProfile;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Button btnTestAll;
        private System.Windows.Forms.Button btnEditSelected;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.TextBox tbNickname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cbCredentials;
        private System.Windows.Forms.CheckBox cbIsWebsite;
        private System.Windows.Forms.CheckBox cbIsNewTab;
        private System.Windows.Forms.TextBox tbProfileName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRefreshOpenProcess;
        private System.Windows.Forms.Button btnSaveSelected;
        private System.Windows.Forms.NumericUpDown nudWaitForSeconds;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}