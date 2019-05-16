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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnMoveDownSelected = new System.Windows.Forms.Button();
			this.btnMoveUpSelected = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cbAutoLogin = new System.Windows.Forms.CheckBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nicknameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.isWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.isNewTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.requiresCredentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.autoLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnRegrabProcessProperties = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudWaitForSeconds)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(313, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "1. Drag file you wish to open over the window to get the file path.";
			// 
			// tbFilePath
			// 
			this.tbFilePath.Enabled = false;
			this.tbFilePath.Location = new System.Drawing.Point(73, 19);
			this.tbFilePath.Name = "tbFilePath";
			this.tbFilePath.Size = new System.Drawing.Size(310, 20);
			this.tbFilePath.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(70, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "File Path";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(299, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "2. After we have the file path click the \"Run File Path\" button.";
			// 
			// btnNext1
			// 
			this.btnNext1.Location = new System.Drawing.Point(73, 87);
			this.btnNext1.Name = "btnNext1";
			this.btnNext1.Size = new System.Drawing.Size(150, 23);
			this.btnNext1.TabIndex = 4;
			this.btnNext1.Text = "Run File Path";
			this.btnNext1.UseVisualStyleBackColor = true;
			this.btnNext1.Click += new System.EventHandler(this.btnRunFilePath_Click);
			// 
			// btnClearFilePath
			// 
			this.btnClearFilePath.Location = new System.Drawing.Point(233, 87);
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
			this.lbOpenProcesses.Location = new System.Drawing.Point(74, 32);
			this.lbOpenProcesses.Name = "lbOpenProcesses";
			this.lbOpenProcesses.Size = new System.Drawing.Size(150, 95);
			this.lbOpenProcesses.TabIndex = 6;
			this.lbOpenProcesses.SelectedValueChanged += new System.EventHandler(this.lbOpenProcesses_SelectedValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 263);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(428, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "3. After the file opens, position it where you want and select its name in the bo" +
    "x to the left.";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(230, 8);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 13);
			this.label7.TabIndex = 10;
			this.label7.Text = "Position X:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(230, 34);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 13);
			this.label8.TabIndex = 11;
			this.label8.Text = "Position Y:";
			// 
			// tbPositionX
			// 
			this.tbPositionX.Enabled = false;
			this.tbPositionX.Location = new System.Drawing.Point(287, 5);
			this.tbPositionX.Name = "tbPositionX";
			this.tbPositionX.Size = new System.Drawing.Size(100, 20);
			this.tbPositionX.TabIndex = 12;
			// 
			// tbPositionY
			// 
			this.tbPositionY.Enabled = false;
			this.tbPositionY.Location = new System.Drawing.Point(287, 31);
			this.tbPositionY.Name = "tbPositionY";
			this.tbPositionY.Size = new System.Drawing.Size(100, 20);
			this.tbPositionY.TabIndex = 13;
			// 
			// tbWidth
			// 
			this.tbWidth.Enabled = false;
			this.tbWidth.Location = new System.Drawing.Point(287, 57);
			this.tbWidth.Name = "tbWidth";
			this.tbWidth.Size = new System.Drawing.Size(100, 20);
			this.tbWidth.TabIndex = 14;
			// 
			// tbHeight
			// 
			this.tbHeight.Enabled = false;
			this.tbHeight.Location = new System.Drawing.Point(287, 83);
			this.tbHeight.Name = "tbHeight";
			this.tbHeight.Size = new System.Drawing.Size(100, 20);
			this.tbHeight.TabIndex = 15;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(230, 60);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(38, 13);
			this.label9.TabIndex = 16;
			this.label9.Text = "Width:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(230, 86);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(41, 13);
			this.label10.TabIndex = 17;
			this.label10.Text = "Height:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(12, 417);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(320, 13);
			this.label11.TabIndex = 18;
			this.label11.Text = "4. After we have all the information, close window and click \"Test\"";
			// 
			// btnTest
			// 
			this.btnTest.Location = new System.Drawing.Point(76, 29);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(150, 23);
			this.btnTest.TabIndex = 19;
			this.btnTest.Text = "Test";
			this.btnTest.UseVisualStyleBackColor = true;
			this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
			// 
			// btnRestart
			// 
			this.btnRestart.Location = new System.Drawing.Point(236, 29);
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
			this.lbAppProfiles.Location = new System.Drawing.Point(3, 20);
			this.lbAppProfiles.Name = "lbAppProfiles";
			this.lbAppProfiles.Size = new System.Drawing.Size(120, 316);
			this.lbAppProfiles.TabIndex = 21;
			this.lbAppProfiles.SelectedIndexChanged += new System.EventHandler(this.LbAppProfiles_SelectedIndexChanged);
			// 
			// btnAddToProfile
			// 
			this.btnAddToProfile.Enabled = false;
			this.btnAddToProfile.Location = new System.Drawing.Point(76, 58);
			this.btnAddToProfile.Name = "btnAddToProfile";
			this.btnAddToProfile.Size = new System.Drawing.Size(310, 23);
			this.btnAddToProfile.TabIndex = 22;
			this.btnAddToProfile.Text = "Add To Profile";
			this.btnAddToProfile.UseVisualStyleBackColor = true;
			this.btnAddToProfile.Click += new System.EventHandler(this.btnAddToProfile_Click);
			// 
			// btnRemoveSelected
			// 
			this.btnRemoveSelected.Location = new System.Drawing.Point(3, 429);
			this.btnRemoveSelected.Name = "btnRemoveSelected";
			this.btnRemoveSelected.Size = new System.Drawing.Size(120, 23);
			this.btnRemoveSelected.TabIndex = 23;
			this.btnRemoveSelected.Text = "Remove Selected";
			this.btnRemoveSelected.UseVisualStyleBackColor = true;
			this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
			// 
			// btnTestAll
			// 
			this.btnTestAll.Location = new System.Drawing.Point(3, 3);
			this.btnTestAll.Name = "btnTestAll";
			this.btnTestAll.Size = new System.Drawing.Size(444, 23);
			this.btnTestAll.TabIndex = 24;
			this.btnTestAll.Text = "Test All";
			this.btnTestAll.UseVisualStyleBackColor = true;
			this.btnTestAll.Click += new System.EventHandler(this.btnTestAll_Click);
			// 
			// btnEditSelected
			// 
			this.btnEditSelected.Location = new System.Drawing.Point(3, 458);
			this.btnEditSelected.Name = "btnEditSelected";
			this.btnEditSelected.Size = new System.Drawing.Size(120, 23);
			this.btnEditSelected.TabIndex = 25;
			this.btnEditSelected.Text = "Edit Selected";
			this.btnEditSelected.UseVisualStyleBackColor = true;
			this.btnEditSelected.Click += new System.EventHandler(this.btnEditSelected_Click);
			// 
			// btnFinished
			// 
			this.btnFinished.Location = new System.Drawing.Point(3, 58);
			this.btnFinished.Name = "btnFinished";
			this.btnFinished.Size = new System.Drawing.Size(444, 23);
			this.btnFinished.TabIndex = 26;
			this.btnFinished.Text = "Finished";
			this.btnFinished.UseVisualStyleBackColor = true;
			this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
			// 
			// tbNickname
			// 
			this.tbNickname.Location = new System.Drawing.Point(15, 95);
			this.tbNickname.Name = "tbNickname";
			this.tbNickname.Size = new System.Drawing.Size(100, 20);
			this.tbNickname.TabIndex = 27;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(12, 79);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(55, 13);
			this.label12.TabIndex = 28;
			this.label12.Text = "Nickname";
			// 
			// cbCredentials
			// 
			this.cbCredentials.AutoSize = true;
			this.cbCredentials.Location = new System.Drawing.Point(212, 45);
			this.cbCredentials.Name = "cbCredentials";
			this.cbCredentials.Size = new System.Drawing.Size(123, 17);
			this.cbCredentials.TabIndex = 29;
			this.cbCredentials.Text = "Requires Credentials";
			this.cbCredentials.UseVisualStyleBackColor = true;
			this.cbCredentials.CheckedChanged += new System.EventHandler(this.CbCredentials_CheckedChanged);
			// 
			// cbIsWebsite
			// 
			this.cbIsWebsite.AutoSize = true;
			this.cbIsWebsite.Location = new System.Drawing.Point(130, 45);
			this.cbIsWebsite.Name = "cbIsWebsite";
			this.cbIsWebsite.Size = new System.Drawing.Size(76, 17);
			this.cbIsWebsite.TabIndex = 30;
			this.cbIsWebsite.Text = "Is Website";
			this.cbIsWebsite.UseVisualStyleBackColor = true;
			this.cbIsWebsite.CheckStateChanged += new System.EventHandler(this.cbIsWebsite_CheckStateChanged);
			// 
			// cbIsNewTab
			// 
			this.cbIsNewTab.AutoSize = true;
			this.cbIsNewTab.Enabled = false;
			this.cbIsNewTab.Location = new System.Drawing.Point(130, 64);
			this.cbIsNewTab.Name = "cbIsNewTab";
			this.cbIsNewTab.Size = new System.Drawing.Size(81, 17);
			this.cbIsNewTab.TabIndex = 31;
			this.cbIsNewTab.Text = "Is New Tab";
			this.cbIsNewTab.UseVisualStyleBackColor = true;
			// 
			// tbProfileName
			// 
			this.tbProfileName.Location = new System.Drawing.Point(76, 32);
			this.tbProfileName.Name = "tbProfileName";
			this.tbProfileName.Size = new System.Drawing.Size(371, 20);
			this.tbProfileName.TabIndex = 32;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(0, 35);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(70, 13);
			this.label13.TabIndex = 33;
			this.label13.Text = "Profile Name:";
			// 
			// btnRefreshOpenProcess
			// 
			this.btnRefreshOpenProcess.Enabled = false;
			this.btnRefreshOpenProcess.Location = new System.Drawing.Point(74, 3);
			this.btnRefreshOpenProcess.Name = "btnRefreshOpenProcess";
			this.btnRefreshOpenProcess.Size = new System.Drawing.Size(150, 23);
			this.btnRefreshOpenProcess.TabIndex = 34;
			this.btnRefreshOpenProcess.Text = "Refresh List";
			this.btnRefreshOpenProcess.UseVisualStyleBackColor = true;
			this.btnRefreshOpenProcess.Click += new System.EventHandler(this.btnRefreshOpenProcess_Click);
			// 
			// btnSaveSelected
			// 
			this.btnSaveSelected.Location = new System.Drawing.Point(3, 400);
			this.btnSaveSelected.Name = "btnSaveSelected";
			this.btnSaveSelected.Size = new System.Drawing.Size(120, 23);
			this.btnSaveSelected.TabIndex = 35;
			this.btnSaveSelected.Text = "Save Selected";
			this.btnSaveSelected.UseVisualStyleBackColor = true;
			this.btnSaveSelected.Click += new System.EventHandler(this.btnSaveSelected_Click);
			// 
			// nudWaitForSeconds
			// 
			this.nudWaitForSeconds.Location = new System.Drawing.Point(280, 1);
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
			this.label14.Location = new System.Drawing.Point(76, 2);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(204, 13);
			this.label14.TabIndex = 37;
			this.label14.Text = "If the application requires credentials, wait";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(309, 2);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(70, 13);
			this.label15.TabIndex = 38;
			this.label15.Text = "seconds for it";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(26, 37);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(305, 13);
			this.label16.TabIndex = 39;
			this.label16.Text = "Or, if you wish to open a Website, check \"Is Website\" in step 2";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(27, 50);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(177, 13);
			this.label17.TabIndex = 40;
			this.label17.Text = "then paste the link in the \"File Path\"";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label23);
			this.panel1.Controls.Add(this.label22);
			this.panel1.Controls.Add(this.label21);
			this.panel1.Controls.Add(this.btnMoveDownSelected);
			this.panel1.Controls.Add(this.btnMoveUpSelected);
			this.panel1.Controls.Add(this.lbAppProfiles);
			this.panel1.Controls.Add(this.btnRemoveSelected);
			this.panel1.Controls.Add(this.btnEditSelected);
			this.panel1.Controls.Add(this.btnSaveSelected);
			this.panel1.Location = new System.Drawing.Point(477, 138);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(130, 490);
			this.panel1.TabIndex = 41;
			// 
			// btnMoveDownSelected
			// 
			this.btnMoveDownSelected.Location = new System.Drawing.Point(65, 355);
			this.btnMoveDownSelected.Name = "btnMoveDownSelected";
			this.btnMoveDownSelected.Size = new System.Drawing.Size(58, 23);
			this.btnMoveDownSelected.TabIndex = 37;
			this.btnMoveDownSelected.Text = "Order \\/";
			this.btnMoveDownSelected.UseVisualStyleBackColor = true;
			this.btnMoveDownSelected.Click += new System.EventHandler(this.BtnMoveDownSelected_Click);
			// 
			// btnMoveUpSelected
			// 
			this.btnMoveUpSelected.Location = new System.Drawing.Point(3, 355);
			this.btnMoveUpSelected.Name = "btnMoveUpSelected";
			this.btnMoveUpSelected.Size = new System.Drawing.Size(58, 23);
			this.btnMoveUpSelected.TabIndex = 36;
			this.btnMoveUpSelected.Text = "Order /\\";
			this.btnMoveUpSelected.UseVisualStyleBackColor = true;
			this.btnMoveUpSelected.Click += new System.EventHandler(this.BtnMoveUpSelected_Click);
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.label19);
			this.panel2.Controls.Add(this.btnTest);
			this.panel2.Controls.Add(this.btnRestart);
			this.panel2.Controls.Add(this.btnAddToProfile);
			this.panel2.Controls.Add(this.label14);
			this.panel2.Controls.Add(this.nudWaitForSeconds);
			this.panel2.Controls.Add(this.label15);
			this.panel2.Location = new System.Drawing.Point(15, 433);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(454, 88);
			this.panel2.TabIndex = 42;
			// 
			// cbAutoLogin
			// 
			this.cbAutoLogin.AutoSize = true;
			this.cbAutoLogin.Enabled = false;
			this.cbAutoLogin.Location = new System.Drawing.Point(212, 64);
			this.cbAutoLogin.Name = "cbAutoLogin";
			this.cbAutoLogin.Size = new System.Drawing.Size(77, 17);
			this.cbAutoLogin.TabIndex = 43;
			this.cbAutoLogin.Text = "Auto Login";
			this.cbAutoLogin.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(619, 24);
			this.menuStrip1.TabIndex = 44;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nicknameToolStripMenuItem,
            this.isWebsiteToolStripMenuItem,
            this.isNewTabToolStripMenuItem,
            this.requiresCredentialsToolStripMenuItem,
            this.autoLoginToolStripMenuItem,
            this.optionsToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// nicknameToolStripMenuItem
			// 
			this.nicknameToolStripMenuItem.Name = "nicknameToolStripMenuItem";
			this.nicknameToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.nicknameToolStripMenuItem.Text = "Nickname";
			// 
			// isWebsiteToolStripMenuItem
			// 
			this.isWebsiteToolStripMenuItem.Name = "isWebsiteToolStripMenuItem";
			this.isWebsiteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.isWebsiteToolStripMenuItem.Text = "Is Website";
			// 
			// isNewTabToolStripMenuItem
			// 
			this.isNewTabToolStripMenuItem.Name = "isNewTabToolStripMenuItem";
			this.isNewTabToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.isNewTabToolStripMenuItem.Text = "Is New Tab";
			// 
			// requiresCredentialsToolStripMenuItem
			// 
			this.requiresCredentialsToolStripMenuItem.Name = "requiresCredentialsToolStripMenuItem";
			this.requiresCredentialsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.requiresCredentialsToolStripMenuItem.Text = "Requires Credentials";
			// 
			// autoLoginToolStripMenuItem
			// 
			this.autoLoginToolStripMenuItem.Name = "autoLoginToolStripMenuItem";
			this.autoLoginToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.autoLoginToolStripMenuItem.Text = "Auto Login";
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.cbAutoLogin);
			this.panel3.Controls.Add(this.tbFilePath);
			this.panel3.Controls.Add(this.btnNext1);
			this.panel3.Controls.Add(this.btnClearFilePath);
			this.panel3.Controls.Add(this.cbCredentials);
			this.panel3.Controls.Add(this.cbIsWebsite);
			this.panel3.Controls.Add(this.cbIsNewTab);
			this.panel3.Location = new System.Drawing.Point(15, 138);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(454, 122);
			this.panel3.TabIndex = 45;
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.btnTestAll);
			this.panel4.Controls.Add(this.btnFinished);
			this.panel4.Controls.Add(this.tbProfileName);
			this.panel4.Controls.Add(this.label13);
			this.panel4.Location = new System.Drawing.Point(15, 540);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(454, 88);
			this.panel4.TabIndex = 46;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(12, 524);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(303, 13);
			this.label18.TabIndex = 47;
			this.label18.Text = "5. Run the Profile Test and if you are happy, name it and finish.";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(76, 15);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(192, 13);
			this.label19.TabIndex = 39;
			this.label19.Text = "to load before inputing your credentials.";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(474, 122);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(43, 13);
			this.label20.TabIndex = 48;
			this.label20.Text = "Options";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(3, 339);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(83, 13);
			this.label21.TabIndex = 49;
			this.label21.Text = "Execution Order";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(3, 381);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(98, 13);
			this.label22.TabIndex = 49;
			this.label22.Text = "Application Options";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(3, 4);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(64, 13);
			this.label23.TabIndex = 49;
			this.label23.Text = "Applications";
			// 
			// panel5
			// 
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel5.Controls.Add(this.btnRegrabProcessProperties);
			this.panel5.Controls.Add(this.btnRefreshOpenProcess);
			this.panel5.Controls.Add(this.lbOpenProcesses);
			this.panel5.Controls.Add(this.label7);
			this.panel5.Controls.Add(this.label8);
			this.panel5.Controls.Add(this.tbPositionX);
			this.panel5.Controls.Add(this.tbPositionY);
			this.panel5.Controls.Add(this.tbWidth);
			this.panel5.Controls.Add(this.tbHeight);
			this.panel5.Controls.Add(this.label9);
			this.panel5.Controls.Add(this.label10);
			this.panel5.Location = new System.Drawing.Point(15, 279);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(454, 135);
			this.panel5.TabIndex = 49;
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.optionsToolStripMenuItem.Text = "Options";
			// 
			// btnRegrabProcessProperties
			// 
			this.btnRegrabProcessProperties.Location = new System.Drawing.Point(230, 105);
			this.btnRegrabProcessProperties.Name = "btnRegrabProcessProperties";
			this.btnRegrabProcessProperties.Size = new System.Drawing.Size(157, 23);
			this.btnRegrabProcessProperties.TabIndex = 50;
			this.btnRegrabProcessProperties.Text = "Regrab Position";
			this.btnRegrabProcessProperties.UseVisualStyleBackColor = true;
			this.btnRegrabProcessProperties.Click += new System.EventHandler(this.BtnRegrabProcessProperties_Click);
			// 
			// ProfileSetup
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 642);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.tbNickname);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "ProfileSetup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Profile Setup";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProfileSetup_FormClosing);
			this.Load += new System.EventHandler(this.ProfileSetup_Load);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.ProfileSetup_DragEnter);
			((System.ComponentModel.ISupportInitialize)(this.nudWaitForSeconds)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
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
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnMoveDownSelected;
		private System.Windows.Forms.Button btnMoveUpSelected;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.CheckBox cbAutoLogin;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nicknameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem isWebsiteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem isNewTabToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem requiresCredentialsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem autoLoginToolStripMenuItem;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.Button btnRegrabProcessProperties;
	}
}