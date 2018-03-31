namespace lab3
{
	partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			this.toolbox = new System.Windows.Forms.Panel();
			this.size = new System.Windows.Forms.ComboBox();
			this.fill = new System.Windows.Forms.ComboBox();
			this.image = new System.Windows.Forms.Button();
			this.eraser = new System.Windows.Forms.Button();
			this.bezier = new System.Windows.Forms.Button();
			this.circle = new System.Windows.Forms.Button();
			this.rectangle = new System.Windows.Forms.Button();
			this.line = new System.Windows.Forms.Button();
			this.pen = new System.Windows.Forms.Button();
			this.color = new System.Windows.Forms.PictureBox();
			this.OpenImg = new System.Windows.Forms.OpenFileDialog();
			this.toolbox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.color)).BeginInit();
			this.SuspendLayout();
			// 
			// colorDialog
			// 
			this.colorDialog.AnyColor = true;
			this.colorDialog.FullOpen = true;
			// 
			// toolbox
			// 
			this.toolbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.toolbox.BackColor = System.Drawing.SystemColors.Menu;
			this.toolbox.Controls.Add(this.size);
			this.toolbox.Controls.Add(this.fill);
			this.toolbox.Controls.Add(this.image);
			this.toolbox.Controls.Add(this.eraser);
			this.toolbox.Controls.Add(this.bezier);
			this.toolbox.Controls.Add(this.circle);
			this.toolbox.Controls.Add(this.rectangle);
			this.toolbox.Controls.Add(this.line);
			this.toolbox.Controls.Add(this.pen);
			this.toolbox.Controls.Add(this.color);
			this.toolbox.Location = new System.Drawing.Point(1214, 12);
			this.toolbox.Name = "toolbox";
			this.toolbox.Size = new System.Drawing.Size(150, 776);
			this.toolbox.TabIndex = 1;
			// 
			// size
			// 
			this.size.FormattingEnabled = true;
			this.size.Items.AddRange(new object[] {
            "1 px",
            "2 px",
            "5 px",
            "10 px",
            "20 px"});
			this.size.Location = new System.Drawing.Point(16, 725);
			this.size.Name = "size";
			this.size.Size = new System.Drawing.Size(121, 24);
			this.size.TabIndex = 9;
			this.size.Text = "Brush size";
			this.size.SelectionChangeCommitted += new System.EventHandler(this.Size_SelectionChangeCommited);
			// 
			// fill
			// 
			this.fill.FormattingEnabled = true;
			this.fill.Items.AddRange(new object[] {
            "Unfilled",
            "Filled",
            "Gradient filled"});
			this.fill.Location = new System.Drawing.Point(16, 671);
			this.fill.Name = "fill";
			this.fill.Size = new System.Drawing.Size(121, 24);
			this.fill.TabIndex = 8;
			this.fill.Text = "Fill mode";
			this.fill.SelectionChangeCommitted += new System.EventHandler(this.Fill_SelectionChangeCommited);
			// 
			// image
			// 
			this.image.Location = new System.Drawing.Point(34, 592);
			this.image.Name = "image";
			this.image.Size = new System.Drawing.Size(86, 45);
			this.image.TabIndex = 7;
			this.image.Text = "Image";
			this.image.UseVisualStyleBackColor = true;
			this.image.Click += new System.EventHandler(this.Image_Click);
			// 
			// eraser
			// 
			this.eraser.Location = new System.Drawing.Point(33, 515);
			this.eraser.Name = "eraser";
			this.eraser.Size = new System.Drawing.Size(86, 45);
			this.eraser.TabIndex = 6;
			this.eraser.Text = "Eraser";
			this.eraser.UseVisualStyleBackColor = true;
			this.eraser.Click += new System.EventHandler(this.Eraser_Click);
			// 
			// bezier
			// 
			this.bezier.Location = new System.Drawing.Point(33, 437);
			this.bezier.Name = "bezier";
			this.bezier.Size = new System.Drawing.Size(86, 45);
			this.bezier.TabIndex = 5;
			this.bezier.Text = "Bezier";
			this.bezier.UseVisualStyleBackColor = true;
			this.bezier.Click += new System.EventHandler(this.Bezier_Click);
			// 
			// circle
			// 
			this.circle.Location = new System.Drawing.Point(32, 357);
			this.circle.Name = "circle";
			this.circle.Size = new System.Drawing.Size(86, 45);
			this.circle.TabIndex = 4;
			this.circle.Text = "Circle";
			this.circle.UseVisualStyleBackColor = true;
			this.circle.Click += new System.EventHandler(this.Circle_Click);
			// 
			// rectangle
			// 
			this.rectangle.Location = new System.Drawing.Point(33, 281);
			this.rectangle.Name = "rectangle";
			this.rectangle.Size = new System.Drawing.Size(86, 45);
			this.rectangle.TabIndex = 3;
			this.rectangle.Text = "Rectangle";
			this.rectangle.UseVisualStyleBackColor = true;
			this.rectangle.Click += new System.EventHandler(this.Rect_Click);
			// 
			// line
			// 
			this.line.Location = new System.Drawing.Point(39, 204);
			this.line.Name = "line";
			this.line.Size = new System.Drawing.Size(75, 45);
			this.line.TabIndex = 2;
			this.line.Text = "Line";
			this.line.UseVisualStyleBackColor = true;
			this.line.Click += new System.EventHandler(this.Line_Click);
			// 
			// pen
			// 
			this.pen.Location = new System.Drawing.Point(39, 129);
			this.pen.Name = "pen";
			this.pen.Size = new System.Drawing.Size(75, 47);
			this.pen.TabIndex = 1;
			this.pen.Text = "Pen";
			this.pen.UseVisualStyleBackColor = true;
			this.pen.Click += new System.EventHandler(this.Pen_Click);
			// 
			// color
			// 
			this.color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.color.BackColor = System.Drawing.Color.Black;
			this.color.Location = new System.Drawing.Point(37, 22);
			this.color.Name = "color";
			this.color.Size = new System.Drawing.Size(83, 77);
			this.color.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.color.TabIndex = 0;
			this.color.TabStop = false;
			this.color.Click += new System.EventHandler(this.Color_Click);
			// 
			// OpenImg
			// 
			this.OpenImg.Title = "Select an Image";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1382, 1033);
			this.Controls.Add(this.toolbox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.Text = "Paint.KEK";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
			this.toolbox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.color)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ColorDialog colorDialog;
		private System.Windows.Forms.Panel toolbox;
		private System.Windows.Forms.Button pen;
		private System.Windows.Forms.PictureBox color;
		private System.Windows.Forms.Button line;
		private System.Windows.Forms.Button rectangle;
		private System.Windows.Forms.Button circle;
		private System.Windows.Forms.Button eraser;
		private System.Windows.Forms.Button bezier;
		private System.Windows.Forms.Button image;
		private System.Windows.Forms.ComboBox fill;
		private System.Windows.Forms.ComboBox size;
		private System.Windows.Forms.OpenFileDialog OpenImg;
	}
}

