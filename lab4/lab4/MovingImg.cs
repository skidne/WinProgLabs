using System.Drawing;
using System.Windows.Forms;

namespace lab4
{
	public abstract class MovingImg
	{
		protected Point pos;
		protected int directionX;
		protected int directionY;
		protected int sizeX;
		protected int sizeY;

		public abstract void Move(int Width, int Height);
		public abstract void Paint(PaintEventArgs e);
	}
}
