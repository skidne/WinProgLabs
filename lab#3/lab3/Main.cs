using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace lab3
{
	enum Obj {pen, line, rect, circle, bezier, eraser};
	enum FillMode {unfilled, filled, gradient};

	public partial class Main : Form
	{
		Graphics gf;
		Obj obj = Obj.pen;
		FillMode fMode = FillMode.unfilled;
		Point[] endp= { new Point(0, 0), new Point(0, 0),
			new Point(0, 0), new Point(0, 0) };
		Pen p = new Pen(Color.Black);
		Brush brush;
		Image img;
		Color lastCol = Color.Black;
		int bezierInd = 0;
		bool drawing = false;
		bool imgMove = false;

		public Main()
		{
			InitializeComponent();
			gf = this.CreateGraphics();
			gf.SmoothingMode = SmoothingMode.AntiAlias;
			p.StartCap = p.EndCap = LineCap.Round;
		}

		private void Canvas_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button.Equals(MouseButtons.Left) && obj != Obj.bezier)
			{
				endp[0] = e.Location;
				this.Cursor = Cursors.Cross;
				drawing = true;
			}

			else if (obj == Obj.bezier)
			{
				endp[bezierInd++] = e.Location;
				if (bezierInd == 4)
				{
					gf.DrawBezier(p, endp[0], endp[1], endp[2], endp[3]);
					bezierInd = 0;
				}
			}
		}

		private void Canvas_MouseMove(object sender, MouseEventArgs e)
		{
			endp[1] = e.Location;
			if (drawing && obj == Obj.pen)
			{
				gf.DrawLine(p, endp[0], endp[1]);
				endp[0] = endp[1];
			}
		}

		private void Canvas_MouseUp(object sender, MouseEventArgs e)
		{
			if (fMode == FillMode.gradient)
				brush = new LinearGradientBrush(endp[0], endp[1],
					lastCol, Color.White);

			if (imgMove)
			{
				imgMove = false;
				gf.DrawImage(img, e.Location);
			}

			else if (obj == Obj.line)
				gf.DrawLine(p, endp[0], endp[1]);

			else if (obj == Obj.rect && fMode == FillMode.unfilled)
				gf.DrawRectangle(p,
					(endp[0].X < endp[1].X) ? endp[0].X : endp[1].X,
					(endp[0].Y < endp[1].Y) ? endp[0].Y : endp[1].Y,
					Math.Abs(endp[0].X - endp[1].X),
					Math.Abs(endp[0].Y - endp[1].Y));

			else if (obj == Obj.rect)
			{
				gf.FillRectangle(brush,
					(endp[0].X < endp[1].X) ? endp[0].X : endp[1].X,
					(endp[0].Y < endp[1].Y) ? endp[0].Y : endp[1].Y,
					Math.Abs(endp[0].X - endp[1].X),
					Math.Abs(endp[0].Y - endp[1].Y));
			}

			else if (obj == Obj.circle && fMode == FillMode.unfilled)
				gf.DrawEllipse(p, (endp[0].X < endp[1].X) ? endp[0].X : endp[1].X,
					(endp[0].Y < endp[1].Y) ? endp[0].Y : endp[1].Y,
					Math.Abs(endp[0].X - endp[1].X),
					Math.Abs(endp[0].Y - endp[1].Y));

			else if (obj == Obj.circle)
				gf.FillEllipse(brush,
					(endp[0].X < endp[1].X) ? endp[0].X : endp[1].X,
					(endp[0].Y < endp[1].Y) ? endp[0].Y : endp[1].Y,
					Math.Abs(endp[0].X - endp[1].X),
					Math.Abs(endp[0].Y - endp[1].Y));

			drawing = false;
			this.Cursor = Cursors.Default;
			p.Color = lastCol;
		}

		private void Color_Click(object sender, EventArgs e)
		{
			if (colorDialog.ShowDialog().Equals(DialogResult.OK))
			{
				color.BackColor = colorDialog.Color;
				p.Color = color.BackColor;
				lastCol = p.Color;
			}
		}

		private void Pen_Click(object sender, EventArgs e)
		{
			obj = Obj.pen;
		}

		private void Line_Click(object sender, EventArgs e)
		{
			obj = Obj.line;
		}

		private void Rect_Click(object sender, EventArgs e)
		{
			obj = Obj.rect;
		}

		private void Circle_Click(object sender, EventArgs e)
		{
			obj = Obj.circle;
		}

		private void Bezier_Click(object sender, EventArgs e)
		{
			obj = Obj.bezier;
		}

		private void Eraser_Click(object sender, EventArgs e)
		{
			obj = Obj.eraser;
			p.Color = Color.White;
		}

		private void Image_Click(object sender, EventArgs e)
		{
			OpenImg.Filter = "All supported graphics|*.jpg;*.jpeg;*.png;*.bmp";
			if (OpenImg.ShowDialog().Equals(DialogResult.OK))
			{
				img = Image.FromFile(OpenImg.FileName);
				imgMove = true;
				this.Cursor = Cursors.Cross;
			}
		}

		private void Fill_SelectionChangeCommited(object sender, EventArgs e)
		{
			switch (fill.SelectedItem)
			{
				case "Unfilled":
					fMode = FillMode.unfilled;
					break;
				case "Filled":
					fMode = FillMode.filled;
					brush = new SolidBrush(lastCol);
					break;
				case "Gradient filled":
					fMode = FillMode.gradient;
					break;
			}
		}

		private void Size_SelectionChangeCommited(object sender, EventArgs e)
		{
			switch (size.SelectedItem)
			{
				case "1 px":
					p.Width = 1;
					break;
				case "2 px":
					p.Width = 2;
					break;
				case "5 px":
					p.Width = 5;
					break;
				case "10 px":
					p.Width = 10;
					break;
				case "20 px":
					p.Width = 20;
					break;
			}
		}
	}
}
