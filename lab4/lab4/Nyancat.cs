using System.Drawing;
using System.Windows.Forms;

namespace lab4
{
	public class Nyancat : MovingImg
	{
		Image nyan;

		public Nyancat(Point pos)
		{
			this.pos = pos;
			directionX = 7;
			directionY = 0;
			sizeX = 200;
			sizeY = 80;
			nyan = Properties.Resources.nyan;
		}

		public override void Move(int Width, int Height)
		{
			if (pos.X + sizeX >= Width || pos.X <= 0)
			{
				directionX *= -1;
				nyan.RotateFlip(RotateFlipType.RotateNoneFlipX);
			}
			pos = new Point(pos.X + directionX, pos.Y + directionY);
		}

		public override void Paint(PaintEventArgs e)
		{
			e.Graphics.DrawImage(nyan, pos.X, pos.Y, sizeX, sizeY);
		}
	}
}
