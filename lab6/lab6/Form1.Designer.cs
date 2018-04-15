namespace lab6
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.Rick = new System.Windows.Forms.Button();
			this.Morty = new System.Windows.Forms.Button();
			this.Butthole = new System.Windows.Forms.Button();
			this.Title = new System.Windows.Forms.TextBox();
			this.CharacterInput = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.AddBtn = new System.Windows.Forms.Button();
			this.FavoriteChar = new System.Windows.Forms.TextBox();
			this.NameInput = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SubmitBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Rick
			// 
			this.Rick.BackColor = System.Drawing.Color.Aquamarine;
			this.Rick.FlatAppearance.BorderSize = 0;
			this.Rick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Rick.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Rick.ForeColor = System.Drawing.Color.Black;
			this.Rick.Location = new System.Drawing.Point(78, 115);
			this.Rick.Name = "Rick";
			this.Rick.Size = new System.Drawing.Size(150, 67);
			this.Rick.TabIndex = 0;
			this.Rick.Text = "Rick";
			this.Rick.UseVisualStyleBackColor = false;
			this.Rick.Click += new System.EventHandler(this.Rick_Click);
			// 
			// Morty
			// 
			this.Morty.BackColor = System.Drawing.Color.Fuchsia;
			this.Morty.FlatAppearance.BorderSize = 0;
			this.Morty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Morty.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Morty.ForeColor = System.Drawing.Color.Black;
			this.Morty.Location = new System.Drawing.Point(298, 115);
			this.Morty.Name = "Morty";
			this.Morty.Size = new System.Drawing.Size(150, 67);
			this.Morty.TabIndex = 1;
			this.Morty.Text = "Morty";
			this.Morty.UseVisualStyleBackColor = false;
			this.Morty.Click += new System.EventHandler(this.Morty_Click);
			// 
			// Butthole
			// 
			this.Butthole.BackColor = System.Drawing.Color.Gold;
			this.Butthole.FlatAppearance.BorderSize = 0;
			this.Butthole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Butthole.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Butthole.ForeColor = System.Drawing.Color.Black;
			this.Butthole.Location = new System.Drawing.Point(513, 115);
			this.Butthole.Name = "Butthole";
			this.Butthole.Size = new System.Drawing.Size(293, 67);
			this.Butthole.TabIndex = 2;
			this.Butthole.Text = "Mr. Poopybutthole";
			this.Butthole.UseVisualStyleBackColor = false;
			this.Butthole.Click += new System.EventHandler(this.Butthole_Click);
			// 
			// Title
			// 
			this.Title.BackColor = System.Drawing.Color.Black;
			this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Title.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Title.ForeColor = System.Drawing.Color.Aqua;
			this.Title.Location = new System.Drawing.Point(64, 33);
			this.Title.Multiline = true;
			this.Title.Name = "Title";
			this.Title.ReadOnly = true;
			this.Title.Size = new System.Drawing.Size(754, 48);
			this.Title.TabIndex = 3;
			this.Title.Text = "Rick and Morty: Favorite Character Poll";
			this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// CharacterInput
			// 
			this.CharacterInput.Location = new System.Drawing.Point(317, 264);
			this.CharacterInput.Name = "CharacterInput";
			this.CharacterInput.Size = new System.Drawing.Size(223, 22);
			this.CharacterInput.TabIndex = 4;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.Black;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.ForeColor = System.Drawing.Color.White;
			this.textBox2.Location = new System.Drawing.Point(177, 264);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(112, 20);
			this.textBox2.TabIndex = 5;
			this.textBox2.Text = "Or type here:";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// AddBtn
			// 
			this.AddBtn.Location = new System.Drawing.Point(575, 264);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(75, 23);
			this.AddBtn.TabIndex = 6;
			this.AddBtn.Text = "Add";
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// FavoriteChar
			// 
			this.FavoriteChar.BackColor = System.Drawing.Color.Black;
			this.FavoriteChar.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.FavoriteChar.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FavoriteChar.ForeColor = System.Drawing.Color.White;
			this.FavoriteChar.Location = new System.Drawing.Point(177, 351);
			this.FavoriteChar.Multiline = true;
			this.FavoriteChar.Name = "FavoriteChar";
			this.FavoriteChar.ReadOnly = true;
			this.FavoriteChar.Size = new System.Drawing.Size(617, 34);
			this.FavoriteChar.TabIndex = 7;
			this.FavoriteChar.Text = "Your Favorite Character: Choose a character";
			// 
			// NameInput
			// 
			this.NameInput.BackColor = System.Drawing.Color.LightSkyBlue;
			this.NameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.NameInput.Font = new System.Drawing.Font("Raleway", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NameInput.ForeColor = System.Drawing.Color.MidnightBlue;
			this.NameInput.Location = new System.Drawing.Point(325, 441);
			this.NameInput.Name = "NameInput";
			this.NameInput.Size = new System.Drawing.Size(223, 22);
			this.NameInput.TabIndex = 8;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.Black;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.ForeColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(155, 440);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(148, 20);
			this.textBox1.TabIndex = 9;
			this.textBox1.Text = "Enter your name:";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// SubmitBtn
			// 
			this.SubmitBtn.BackColor = System.Drawing.Color.MediumPurple;
			this.SubmitBtn.FlatAppearance.BorderSize = 0;
			this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SubmitBtn.Font = new System.Drawing.Font("Rockwell Extra Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubmitBtn.ForeColor = System.Drawing.Color.Indigo;
			this.SubmitBtn.Location = new System.Drawing.Point(362, 510);
			this.SubmitBtn.Name = "SubmitBtn";
			this.SubmitBtn.Size = new System.Drawing.Size(160, 67);
			this.SubmitBtn.TabIndex = 10;
			this.SubmitBtn.Text = "Submit";
			this.SubmitBtn.UseVisualStyleBackColor = false;
			this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(872, 619);
			this.Controls.Add(this.SubmitBtn);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.NameInput);
			this.Controls.Add(this.FavoriteChar);
			this.Controls.Add(this.AddBtn);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.CharacterInput);
			this.Controls.Add(this.Title);
			this.Controls.Add(this.Butthole);
			this.Controls.Add(this.Morty);
			this.Controls.Add(this.Rick);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Rick & Morty Poll";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Rick;
		private System.Windows.Forms.Button Morty;
		private System.Windows.Forms.Button Butthole;
		private System.Windows.Forms.TextBox Title;
		private System.Windows.Forms.TextBox CharacterInput;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button AddBtn;
		private System.Windows.Forms.TextBox FavoriteChar;
		private System.Windows.Forms.TextBox NameInput;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button SubmitBtn;
	}
}

