using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab4
{
	public class Rick : MovingImg
	{
		Random rand;
		public Rick(Point pos)
		{
			rand = new Random();
			this.pos = pos;
			directionX = (rand.Next(0, 2) > 0) ? 3 : -3;
			directionY = (rand.Next(0, 2) > 0) ? 3 : -3;
			sizeX = 130;
			sizeY = 150;
		}

		public override void Move(int Width, int Height)
		{
			directionX = (pos.X + sizeX >= Width || pos.X <= 0) ? -directionX : directionX;
			directionY = (pos.Y + sizeY >= Height || pos.Y <= 0) ? -directionY : directionY;
			pos = new Point(pos.X + directionX, pos.Y + directionY);
		}

		public override void Paint(PaintEventArgs e)
		{
			e.Graphics.DrawImage(Properties.Resources.rick, pos.X, pos.Y, sizeX, sizeY);
		}

		public void CheckCollision(Rick r)
		{
			Rectangle intersection = Rectangle.Intersect(new Rectangle(pos.X, pos.Y, sizeX, sizeY),
				new Rectangle(r.pos.X, r.pos.Y, r.sizeX, r.sizeY));

			if (!intersection.IsEmpty)
			{
				directionX *= -1;
				directionY *= -1;
				r.directionX *= -1;
				r.directionY *= -1;

				System.Media.SoundPlayer player = new System.Media.SoundPlayer();
				player.Stream = Properties.Resources.pickle;
				player.Play();
			}
		}
	}
}
