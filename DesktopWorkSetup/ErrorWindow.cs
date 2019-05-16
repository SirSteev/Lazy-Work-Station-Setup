using System;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopWorkSetup
{
	public partial class ErrorWindow : Form
	{
		private static MessageBoxButtons Buttons;
		private static DialogResult Result;
		private static Label[] Labels;

		private static ErrorWindow errorWindow;

		public ErrorWindow()
		{
			InitializeComponent();

			Labels = new Label[4];
			Labels[0] = lbLineOne;
			Labels[1] = lbLineTwo;
			Labels[2] = lbLinethree;
			Labels[3] = lbLineFour;
		}

		public static DialogResult ShowBox(string caption, string message, MessageBoxButtons buttons, Form parent)
		{
			errorWindow = new ErrorWindow();

			errorWindow.Text = caption;

			errorWindow.SetPosition(parent.Location, parent.Size);
			errorWindow.SetMessage(message);
			errorWindow.SetButtons(buttons);

			errorWindow.ShowDialog();

			return Result;
		}

		public static DialogResult ShowBox(string caption, string message, Form parent)
		{
			errorWindow = new ErrorWindow();

			errorWindow.Text = caption;

			errorWindow.SetPosition(parent.Location, parent.Size);
			errorWindow.SetMessage(message);
			errorWindow.SetButtons(MessageBoxButtons.OK);


			errorWindow.ShowDialog();

			return Result;
		}

		private void SetMessage(string message)
		{
			foreach (Label lbl in Labels)
			{
				lbl.Visible = false;
			}

			int Spot = 0;

			for (int lableIndex = 0; lableIndex < 4; lableIndex++)
			{
				for (int index = Spot + 40; index >= 0; index--)
				{
					if (index > message.Length)
					{
						if (Spot == 0)
							Labels[lableIndex].Text = message.Substring(Spot, message.Length - Spot);
						else
							Labels[lableIndex].Text = message.Substring(Spot + 1, message.Length - Spot - 1);

						Labels[lableIndex].Visible = true;
						return;
					}

					if (message[index] == ' ')
					{
						if (Spot == 0)
							Labels[lableIndex].Text = message.Substring(Spot, index - Spot);
						else
							Labels[lableIndex].Text = message.Substring(Spot + 1, index - Spot);

						Labels[lableIndex].Visible = true;
						Spot = index;
						break;
					}
				}
			}
		}

		private void SetPosition(Point location, Size size)
		{
			Point NewPoint = new Point();

			NewPoint.X = location.X + size.Width / 2 - this.Size.Width / 2;
			NewPoint.Y = location.Y + size.Height / 2 - this.Size.Height / 2;

			this.Location = NewPoint;
		}

		private void SetButtons(MessageBoxButtons buttons)
		{
			Buttons = buttons;

			switch (Buttons)
			{
				case MessageBoxButtons.AbortRetryIgnore:
					btnOne.Text = "Abort";
					btnTwo.Text = "Retry";
					btnThree.Text = "Ignore";
					break;
				case MessageBoxButtons.OK:
					btnOne.Enabled = false;
					btnOne.Visible = false;
					btnTwo.Enabled = false;
					btnTwo.Visible = false;
					btnThree.Text = "OK";
					break;
				case MessageBoxButtons.OKCancel:
					btnOne.Enabled = false;
					btnOne.Visible = false;
					btnTwo.Text = "OK";
					btnThree.Text = "Cancel";
					break;
				case MessageBoxButtons.RetryCancel:
					btnOne.Enabled = false;
					btnOne.Visible = false;
					btnTwo.Text = "Retry";
					btnThree.Text = "Cancel";
					break;
				case MessageBoxButtons.YesNo:
					btnOne.Enabled = false;
					btnOne.Visible = false;
					btnTwo.Text = "Yes";
					btnThree.Text = "No";
					break;
				case MessageBoxButtons.YesNoCancel:
					btnOne.Text = "Yes";
					btnTwo.Text = "No";
					btnThree.Text = "Cancel";
					break;
			}
		}

		private void BtnOne_Click(object sender, EventArgs e)
		{
			switch (Buttons)
			{
				case MessageBoxButtons.AbortRetryIgnore:
					Result = DialogResult.Abort;
					break;
				case MessageBoxButtons.OK:
				case MessageBoxButtons.OKCancel:
				case MessageBoxButtons.RetryCancel:
				case MessageBoxButtons.YesNo:
				case MessageBoxButtons.YesNoCancel:
					Result = DialogResult.Yes;
					break;
			}
			errorWindow.Dispose();
		}

		private void BtnTwo_Click(object sender, EventArgs e)
		{
			switch (Buttons)
			{
				case MessageBoxButtons.AbortRetryIgnore:
					Result = DialogResult.Retry;
					break;
				case MessageBoxButtons.OK:
				case MessageBoxButtons.OKCancel:
					Result = DialogResult.OK;
					break;
				case MessageBoxButtons.RetryCancel:
					Result = DialogResult.Retry;
					break;
				case MessageBoxButtons.YesNo:
					Result = DialogResult.Yes;
					break;
				case MessageBoxButtons.YesNoCancel:
					Result = DialogResult.No;
					break;
			}
			errorWindow.Dispose();
		}

		private void BtnThree_Click(object sender, EventArgs e)
		{
			switch (Buttons)
			{
				case MessageBoxButtons.AbortRetryIgnore:
					Result = DialogResult.Ignore;
					break;
				case MessageBoxButtons.OK:
					Result = DialogResult.OK;
					break;
				case MessageBoxButtons.OKCancel:
					Result = DialogResult.Cancel;
					break;
				case MessageBoxButtons.RetryCancel:
					Result = DialogResult.Cancel;
					break;
				case MessageBoxButtons.YesNo:
					Result = DialogResult.No;
					break;
				case MessageBoxButtons.YesNoCancel:
					Result = DialogResult.Cancel;
					break;
			}
			errorWindow.Dispose();
		}

		private void ErrorWindow_Shown(object sender, EventArgs e)
		{
			this.Focus();
		}
	}
}
