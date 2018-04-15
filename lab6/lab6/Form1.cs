using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace lab6
{
	public partial class Form1 : Form
	{
		SoundPlayer soundPlayer;

		public Form1()
		{
			InitializeComponent();
			FormClosing += Form1_FormClosing;
		}

		private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.WindowsShutDown)
				return;

			switch (MessageBox.Show(this, "YOU CANNOT LEAVE THIS PLACE!", "Close Window",
				MessageBoxButtons.YesNo))
			{
				case DialogResult.Yes:
					e.Cancel = true;
					break;
				default:
					break;
			}
		}

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 0x0112) // WM_SYSCOMMAND
			{
				if (m.WParam == new IntPtr(0xF030)) // SC_MAXIMIZE
				{
					if (MessageBox.Show("Lazy dragging the mouse, are we?",
					"Maximize Window", MessageBoxButtons.OK) == DialogResult.OK)
						return;
				}
				if (m.WParam == new IntPtr(0XF020)) // SC_MINIMIZE
				{
					if (MessageBox.Show("HEY! DON'T YOU DARE!!",
					"Minimize Window", MessageBoxButtons.OK) == DialogResult.OK)
						return;
				}
			}
			base.WndProc(ref m);
		}

		private void Rick_Click(object sender, EventArgs e)
		{
			soundPlayer = new SoundPlayer(Properties.Resources.headBentOver);
			soundPlayer.Play();
			FavoriteChar.Text = "Your Favorite Character: Rick Sanchez";
			FavoriteChar.ForeColor = Rick.BackColor;
		}

		private void Morty_Click(object sender, EventArgs e)
		{
			soundPlayer = new SoundPlayer(Properties.Resources.mainTheme);
			soundPlayer.Play();
			FavoriteChar.Text = "Your Favorite Character: Morty Smith";
			FavoriteChar.ForeColor = Morty.BackColor;
		}

		private void Butthole_Click(object sender, EventArgs e)
		{
			soundPlayer = new SoundPlayer(Properties.Resources.getSchwifty);
			soundPlayer.Play();
			FavoriteChar.Text = "Your Favorite Character: Mr. Poopybutthole";
			FavoriteChar.ForeColor = Butthole.BackColor;
		}

		private void AddBtn_Click(object sender, EventArgs e)
		{
			if (CharacterInput.Text != "")
			{
				FavoriteChar.Text = "Your Favorite Character: " + CharacterInput.Text;
				FavoriteChar.ForeColor = Color.White;
			}
		}

		private void SubmitBtn_Click(object sender, EventArgs e)
		{
			if (FavoriteChar.Text != "Your Favorite Character: Choose a character" &&
				NameInput.Text != "")
			{
				if (MessageBox.Show("Thank You for taking your time completing this poll!",
					"Submit", MessageBoxButtons.OK) == DialogResult.OK)
					Application.Exit();
			}
			else if (FavoriteChar.Text == "Your Favorite Character: Choose a character" &&
				NameInput.Text == "")
				MessageBox.Show("You haven't chosen a character and you didn't write your name!",
					"Submit", MessageBoxButtons.OK);
			else if (FavoriteChar.Text == "Your Favorite Character: Choose a character")
				MessageBox.Show("You haven't chosen a character!", "Submit", MessageBoxButtons.OK);
			else if (NameInput.Text == "")
				MessageBox.Show("You didn't write your name!", "Submit", MessageBoxButtons.OK);
		}
	}
}
