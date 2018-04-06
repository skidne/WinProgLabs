namespace lab4
{
	partial class Form
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.start = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.Timer_Tick);
			// 
			// start
			// 
			this.start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.start.AutoEllipsis = true;
			this.start.BackColor = System.Drawing.Color.Coral;
			this.start.BackgroundImage = global::lab4.Properties.Resources.nyan;
			this.start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.start.Location = new System.Drawing.Point(611, 40);
			this.start.Name = "start";
			this.start.Size = new System.Drawing.Size(698, 303);
			this.start.TabIndex = 0;
			this.start.UseVisualStyleBackColor = false;
			this.start.Click += new System.EventHandler(this.Start_Click);
			// 
			// Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::lab4.Properties.Resources.stars;
			this.ClientSize = new System.Drawing.Size(1924, 473);
			this.Controls.Add(this.start);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "Form";
			this.Text = "Look, it\'s raining Nyan cats!";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Paint);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form_MouseClick);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Button start;
	}
}

