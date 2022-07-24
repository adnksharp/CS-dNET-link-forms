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
	public partial class Form1 : Form
	{
		Form2 wT = new Form2();
		Form3 wR = new Form3();
		bool[] forms = { false, false };
		public Form1()
		{
			InitializeComponent();
		}

		private void Setup(object sender, EventArgs e)
		{
			comboBox1.SelectedIndex = 6;
			comboBox2.SelectedIndex = 0;
			comboBox2.Enabled = false;
		}

		private void FormColor(object sender, EventArgs e)
		{
			BackColor = Color.FromArgb(int.Parse(numericUpDown1.Value.ToString()), int.Parse(numericUpDown2.Value.ToString()), int.Parse(numericUpDown3.Value.ToString()));
			wT.BackColor = Color.FromArgb(int.Parse(numericUpDown1.Value.ToString()), int.Parse(numericUpDown2.Value.ToString()), int.Parse(numericUpDown3.Value.ToString()));
			ForeColor = Color.FromArgb(int.Parse(numericUpDown7.Value.ToString()), int.Parse(numericUpDown8.Value.ToString()), int.Parse(numericUpDown9.Value.ToString()));
			wT.ForeColor = Color.FromArgb(int.Parse(numericUpDown7.Value.ToString()), int.Parse(numericUpDown8.Value.ToString()), int.Parse(numericUpDown9.Value.ToString()));
			wR.ChColor(int.Parse(numericUpDown1.Value.ToString()), int.Parse(numericUpDown2.Value.ToString()), int.Parse(numericUpDown3.Value.ToString()), int.Parse(numericUpDown7.Value.ToString()), int.Parse(numericUpDown8.Value.ToString()), int.Parse(numericUpDown9.Value.ToString()));
		}

		private void ButtonColor(object sender, EventArgs e)
		{
			button1.BackColor = Color.FromArgb(int.Parse(numericUpDown4.Value.ToString()), int.Parse(numericUpDown5.Value.ToString()), int.Parse(numericUpDown6.Value.ToString()));
			button1.ForeColor = Color.FromArgb(int.Parse(numericUpDown10.Value.ToString()), int.Parse(numericUpDown11.Value.ToString()), int.Parse(numericUpDown12.Value.ToString()));
			button2.BackColor = Color.FromArgb(int.Parse(numericUpDown4.Value.ToString()), int.Parse(numericUpDown5.Value.ToString()), int.Parse(numericUpDown6.Value.ToString()));
			button2.ForeColor = Color.FromArgb(int.Parse(numericUpDown10.Value.ToString()), int.Parse(numericUpDown11.Value.ToString()), int.Parse(numericUpDown12.Value.ToString()));
			wT.ButtonColor(int.Parse(numericUpDown4.Value.ToString()), int.Parse(numericUpDown5.Value.ToString()), int.Parse(numericUpDown6.Value.ToString()), int.Parse(numericUpDown10.Value.ToString()), int.Parse(numericUpDown11.Value.ToString()), int.Parse(numericUpDown12.Value.ToString()));
		}

		private void LabelColor(object sender, EventArgs e)
		{
			label1.ForeColor = Color.FromArgb(int.Parse(numericUpDown13.Value.ToString()), int.Parse(numericUpDown14.Value.ToString()), int.Parse(numericUpDown15.Value.ToString()));
			label2.ForeColor = Color.FromArgb(int.Parse(numericUpDown13.Value.ToString()), int.Parse(numericUpDown14.Value.ToString()), int.Parse(numericUpDown15.Value.ToString()));
			label3.ForeColor = Color.FromArgb(int.Parse(numericUpDown13.Value.ToString()), int.Parse(numericUpDown14.Value.ToString()), int.Parse(numericUpDown15.Value.ToString()));
			label4.ForeColor = Color.FromArgb(int.Parse(numericUpDown13.Value.ToString()), int.Parse(numericUpDown14.Value.ToString()), int.Parse(numericUpDown15.Value.ToString()));
			label5.ForeColor = Color.FromArgb(int.Parse(numericUpDown13.Value.ToString()), int.Parse(numericUpDown14.Value.ToString()), int.Parse(numericUpDown15.Value.ToString()));
			label7.ForeColor = Color.FromArgb(int.Parse(numericUpDown13.Value.ToString()), int.Parse(numericUpDown14.Value.ToString()), int.Parse(numericUpDown15.Value.ToString()));
			label8.ForeColor = Color.FromArgb(int.Parse(numericUpDown13.Value.ToString()), int.Parse(numericUpDown14.Value.ToString()), int.Parse(numericUpDown15.Value.ToString()));
			label9.ForeColor = Color.FromArgb(int.Parse(numericUpDown13.Value.ToString()), int.Parse(numericUpDown14.Value.ToString()), int.Parse(numericUpDown15.Value.ToString()));
			label10.ForeColor = Color.FromArgb(int.Parse(numericUpDown13.Value.ToString()), int.Parse(numericUpDown14.Value.ToString()), int.Parse(numericUpDown15.Value.ToString()));
			label11.ForeColor = Color.FromArgb(int.Parse(numericUpDown13.Value.ToString()), int.Parse(numericUpDown14.Value.ToString()), int.Parse(numericUpDown15.Value.ToString()));
			label12.ForeColor = Color.FromArgb(int.Parse(numericUpDown13.Value.ToString()), int.Parse(numericUpDown14.Value.ToString()), int.Parse(numericUpDown15.Value.ToString()));
			wR.ChangeColor(int.Parse(numericUpDown13.Value.ToString()), int.Parse(numericUpDown14.Value.ToString()), int.Parse(numericUpDown15.Value.ToString()));
		}

		private void ChartType(object sender, EventArgs e)
		{
			wR.DataType(comboBox1.SelectedIndex);
		}

		private void ChartColor(object sender, EventArgs e)
		{

		}

		private void FormT(object sender, EventArgs e)
		{
			try
			{
				if (!forms[0])
					wT.Show();
			}
			catch
			{
				forms[0] = !forms[0];
			}
		}

		private void FormR(object sender, EventArgs e)
		{
			try
			{
				if (!forms[1])
					wR.Show();
			}
			catch
			{
				forms[1] = !forms[1];
			}
		}
	}
}
