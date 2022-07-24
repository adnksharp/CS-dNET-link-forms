using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{ 
			button2.Text = textBox1.Text;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			button3.Text = comboBox1.Text;
		}

		public void ButtonColor(int r, int g, int b, int fr, int fg, int fb)
		{
			button2.BackColor = Color.FromArgb(r, g, b);
			button2.ForeColor = Color.FromArgb(fr, fg, fb);
			button3.BackColor = Color.FromArgb(r, g, b);
			button3.ForeColor = Color.FromArgb(fr, fg, fb);
		}
	}
}
