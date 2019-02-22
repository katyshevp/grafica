using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using First;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		Bitmap img;


		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void ОткрытьToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Image files|*.png; *.jpg; *.bmp| All Files (*.*)|*.*";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
			}
			img = new Bitmap(dialog.FileName);
			pictureBox1.Image = img;
			pictureBox1.Refresh();

		}

		private void ИнверсияToolStripMenuItem_Click(object sender, EventArgs e)
		{
			InvertFilter filter = new InvertFilter();
			Bitmap resultImage = filter.processImage(img);
			pictureBox1.Image = resultImage;
			pictureBox1.Refresh();
		}

		private void ФайлToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void ТочечныеToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void МатричныеToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}