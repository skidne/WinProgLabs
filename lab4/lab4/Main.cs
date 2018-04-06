using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace lab4
{
	public partial class Form : System.Windows.Forms.Form
	{
		Random rand;
		Nyancat nyan;
		List<Rick> ricks = new List<Rick>();

		public Form()
		{
			InitializeComponent();
			this.SetStyle(ControlStyles.AllPaintingInWmPaint |
				ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
			this.MouseWheel += Form_MouseWheel;
			timer.Interval = 1000 / 3;
			rand = new Random();
		}

		private void Form_MouseClick(object sender, MouseEventArgs e)
		{
			if (timer.Enabled && ricks.Count < 10)
				ricks.Add(new Rick(Cursor.Position));
		}

		private void Form_MouseWheel(object sender, MouseEventArgs e)
		{
			if (timer.Enabled)
			{
				if (timer.Interval > 2 && e.Delta > 0)
					timer.Interval -= 2;
				else if (timer.Interval < 1000 && e.Delta <= 0)
					timer.Interval += 2;
			}
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			nyan.Move(Width, Height);
			ricks.ForEach(r => r.Move(Width, Height));

			for (int i = 0; i < ricks.Count; i++)
				for (int j = i + 1; j < ricks.Count; j++)
					ricks.ElementAt(i).CheckCollision(ricks.ElementAt(j));

			Invalidate();
		}

		private void Form_Paint(object sender, PaintEventArgs e)
		{
			if (timer.Enabled)
			{
				nyan.Paint(e);
				ricks.ForEach(r => r.Paint(e));
			}
		}

		private void Start_Click(object sender, EventArgs e)
		{
			start.Visible = false;
			timer.Enabled = true;
			timer.Start();
			nyan = new Nyancat(new Point(1, rand.Next(1, Height - 100)));
		}
	}
}
