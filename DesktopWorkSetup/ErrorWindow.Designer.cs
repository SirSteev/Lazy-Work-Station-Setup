namespace DesktopWorkSetup
{
	partial class ErrorWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorWindow));
			this.btnOne = new System.Windows.Forms.Button();
			this.btnTwo = new System.Windows.Forms.Button();
			this.btnThree = new System.Windows.Forms.Button();
			this.lbLineOne = new System.Windows.Forms.Label();
			this.lbLineTwo = new System.Windows.Forms.Label();
			this.lbLinethree = new System.Windows.Forms.Label();
			this.lbLineFour = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnOne
			// 
			this.btnOne.Location = new System.Drawing.Point(12, 64);
			this.btnOne.Name = "btnOne";
			this.btnOne.Size = new System.Drawing.Size(75, 23);
			this.btnOne.TabIndex = 0;
			this.btnOne.Text = "button1";
			this.btnOne.UseVisualStyleBackColor = true;
			this.btnOne.Click += new System.EventHandler(this.BtnOne_Click);
			// 
			// btnTwo
			// 
			this.btnTwo.Location = new System.Drawing.Point(93, 64);
			this.btnTwo.Name = "btnTwo";
			this.btnTwo.Size = new System.Drawing.Size(75, 23);
			this.btnTwo.TabIndex = 1;
			this.btnTwo.Text = "button2";
			this.btnTwo.UseVisualStyleBackColor = true;
			this.btnTwo.Click += new System.EventHandler(this.BtnTwo_Click);
			// 
			// btnThree
			// 
			this.btnThree.Location = new System.Drawing.Point(174, 64);
			this.btnThree.Name = "btnThree";
			this.btnThree.Size = new System.Drawing.Size(75, 23);
			this.btnThree.TabIndex = 2;
			this.btnThree.Text = "button3";
			this.btnThree.UseVisualStyleBackColor = true;
			this.btnThree.Click += new System.EventHandler(this.BtnThree_Click);
			// 
			// lbLineOne
			// 
			this.lbLineOne.AutoSize = true;
			this.lbLineOne.Location = new System.Drawing.Point(12, 9);
			this.lbLineOne.Name = "lbLineOne";
			this.lbLineOne.Size = new System.Drawing.Size(247, 13);
			this.lbLineOne.TabIndex = 3;
			this.lbLineOne.Text = "0123456789012345678901234567890123456789";
			// 
			// lbLineTwo
			// 
			this.lbLineTwo.AutoSize = true;
			this.lbLineTwo.Location = new System.Drawing.Point(12, 22);
			this.lbLineTwo.Name = "lbLineTwo";
			this.lbLineTwo.Size = new System.Drawing.Size(35, 13);
			this.lbLineTwo.TabIndex = 4;
			this.lbLineTwo.Text = "label2";
			// 
			// lbLinethree
			// 
			this.lbLinethree.AutoSize = true;
			this.lbLinethree.Location = new System.Drawing.Point(12, 35);
			this.lbLinethree.Name = "lbLinethree";
			this.lbLinethree.Size = new System.Drawing.Size(35, 13);
			this.lbLinethree.TabIndex = 5;
			this.lbLinethree.Text = "label3";
			// 
			// lbLineFour
			// 
			this.lbLineFour.AutoSize = true;
			this.lbLineFour.Location = new System.Drawing.Point(12, 48);
			this.lbLineFour.Name = "lbLineFour";
			this.lbLineFour.Size = new System.Drawing.Size(35, 13);
			this.lbLineFour.TabIndex = 6;
			this.lbLineFour.Text = "label4";
			// 
			// ErrorWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(265, 98);
			this.Controls.Add(this.lbLineFour);
			this.Controls.Add(this.lbLinethree);
			this.Controls.Add(this.lbLineTwo);
			this.Controls.Add(this.lbLineOne);
			this.Controls.Add(this.btnThree);
			this.Controls.Add(this.btnTwo);
			this.Controls.Add(this.btnOne);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ErrorWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Error Window";
			this.Shown += new System.EventHandler(this.ErrorWindow_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOne;
		private System.Windows.Forms.Button btnTwo;
		private System.Windows.Forms.Button btnThree;
		private System.Windows.Forms.Label lbLineOne;
		private System.Windows.Forms.Label lbLineTwo;
		private System.Windows.Forms.Label lbLinethree;
		private System.Windows.Forms.Label lbLineFour;
	}
}