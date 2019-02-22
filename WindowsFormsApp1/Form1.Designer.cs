namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.menuStrip3 = new System.Windows.Forms.MenuStrip();
			this.menuStrip4 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Location = new System.Drawing.Point(0, 72);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuStrip2
			// 
			this.menuStrip2.Location = new System.Drawing.Point(0, 48);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(800, 24);
			this.menuStrip2.TabIndex = 1;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// menuStrip3
			// 
			this.menuStrip3.Location = new System.Drawing.Point(0, 24);
			this.menuStrip3.Name = "menuStrip3";
			this.menuStrip3.Size = new System.Drawing.Size(800, 24);
			this.menuStrip3.TabIndex = 2;
			this.menuStrip3.Text = "menuStrip3";
			// 
			// menuStrip4
			// 
			this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.открытьToolStripMenuItem});
			this.menuStrip4.Location = new System.Drawing.Point(0, 0);
			this.menuStrip4.Name = "menuStrip4";
			this.menuStrip4.Size = new System.Drawing.Size(800, 24);
			this.menuStrip4.TabIndex = 3;
			this.menuStrip4.Text = "menuStrip4";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem1});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			this.файлToolStripMenuItem.Click += new System.EventHandler(this.ФайлToolStripMenuItem_Click);
			// 
			// открытьToolStripMenuItem1
			// 
			this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
			this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
			this.открытьToolStripMenuItem1.Text = "Открыть";
			this.открытьToolStripMenuItem1.Click += new System.EventHandler(this.ОткрытьToolStripMenuItem1_Click);
			// 
			// открытьToolStripMenuItem
			// 
			this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem});
			this.открытьToolStripMenuItem.Name = "ОткрытьToolStripMenuItem";
			this.открытьToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.открытьToolStripMenuItem.Text = "Фильтры";
			// 
			// точечныеToolStripMenuItem
			// 
			this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem});
			this.точечныеToolStripMenuItem.Name = "ТочечныеToolStripMenuItem";
			this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.точечныеToolStripMenuItem.Text = "Точечные";
			this.точечныеToolStripMenuItem.Click += new System.EventHandler(this.ТочечныеToolStripMenuItem_Click);
			// 
			// инверсияToolStripMenuItem
			// 
			this.инверсияToolStripMenuItem.Name = "ИнверсияToolStripMenuItem";
			this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.инверсияToolStripMenuItem.Text = "Инверсия";
			this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.ИнверсияToolStripMenuItem_Click);
			// 
			// матричныеToolStripMenuItem
			// 
			this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
			this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.матричныеToolStripMenuItem.Text = "Матричные";
			this.матричныеToolStripMenuItem.Click += new System.EventHandler(this.МатричныеToolStripMenuItem_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(0, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(776, 530);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.menuStrip2);
			this.Controls.Add(this.menuStrip3);
			this.Controls.Add(this.menuStrip4);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "---";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip4.ResumeLayout(false);
			this.menuStrip4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.MenuStrip menuStrip3;
		private System.Windows.Forms.MenuStrip menuStrip4;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
