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
	public partial class Form3 : Form
	{
		public Form3()
		{
			Random random = new Random();
			InitializeComponent();
			chart1.Series["Series1"].Points.Add(random.Next(20));
			chart1.Series["Series1"].Points.Add(random.Next(20));
			chart1.Series["Series1"].Points.Add(random.Next(20));
			chart1.Series["Series1"].Points.Add(random.Next(20));
			chart1.Series["Series1"].Points.Add(random.Next(20));
			chart1.Series["Series1"].Points.Add(random.Next(20));
			chart1.Series["Series1"].Points.Add(random.Next(20));
			chart1.Series["Series1"].Points.Add(random.Next(20));
			chart2.Series["Series1"].Points.Add(60).BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
			chart2.Series["Series1"].Points[0].Color = Color.DarkRed;
			chart2.Series["Series1"].Points[0].BackSecondaryColor = Color.Red;
			chart2.Series["Series1"].Points.Add(40);
			chart2.Series["Series1"].Points[1].Color = Color.FromArgb(13, 17, 23);
			chart3.Series["Series1"].Points.Add(60).BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
			chart3.Series["Series1"].Points[0].Color = Color.DarkGreen;
			chart3.Series["Series1"].Points[0].BackSecondaryColor = Color.Lime;
			chart3.Series["Series1"].Points.Add(40);
			chart3.Series["Series1"].Points[1].Color = Color.FromArgb(13, 17, 23);
			chart4.Series["Series1"].Points.Add(60).BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
			chart4.Series["Series1"].Points[0].Color = Color.DarkMagenta;
			chart4.Series["Series1"].Points[0].BackSecondaryColor = Color.Magenta;
			chart4.Series["Series1"].Points.Add(40);
			chart4.Series["Series1"].Points[1].Color = Color.FromArgb(13, 17, 23);
			chart5.Series["Series1"].Points.Add(60).BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
			chart5.Series["Series1"].Points[0].Color = Color.DarkSlateGray;
			chart5.Series["Series1"].Points[0].BackSecondaryColor = Color.Cyan;
			chart5.Series["Series1"].Points.Add(40);
			chart5.Series["Series1"].Points[1].Color = Color.FromArgb(13, 17, 23);
			chart6.Series["Series1"].Points.Add(60).BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
			chart6.Series["Series1"].Points[0].Color = Color.Blue;
			chart6.Series["Series1"].Points[0].BackSecondaryColor = Color.DarkSlateBlue;
			chart6.Series["Series1"].Points.Add(40);
			chart6.Series["Series1"].Points[1].Color = Color.FromArgb(13, 17, 23);
			chart7.Series["Series1"].Points.Add(60).BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
			chart7.Series["Series1"].Points[0].Color = Color.OrangeRed;
			chart7.Series["Series1"].Points[0].BackSecondaryColor = Color.Gold;
			chart7.Series["Series1"].Points.Add(40);
			chart7.Series["Series1"].Points[1].Color = Color.FromArgb(13, 17, 23);
		}

		public void ChColor (int r, int g, int b, int fr, int fg, int fb)
		{
			BackColor = Color.FromArgb(r, g, b);
			ForeColor = Color.FromArgb(fr, fg, fb);
			label1.ForeColor = Color.FromArgb(fr, fg, fb);
			label2.ForeColor = Color.FromArgb(fr, fg, fb);
			label3.ForeColor = Color.FromArgb(fr, fg, fb);
			label4.ForeColor = Color.FromArgb(fr, fg, fb);
			label5.ForeColor = Color.FromArgb(fr, fg, fb);
			label6.ForeColor = Color.FromArgb(fr, fg, fb);
			chart2.Series["Series1"].Points[1].Color = Color.FromArgb(r, g, b);
			chart3.Series["Series1"].Points[1].Color = Color.FromArgb(r, g, b);
			chart4.Series["Series1"].Points[1].Color = Color.FromArgb(r, g, b);
			chart5.Series["Series1"].Points[1].Color = Color.FromArgb(r, g, b);
			chart6.Series["Series1"].Points[1].Color = Color.FromArgb(r, g, b);
			chart7.Series["Series1"].Points[1].Color = Color.FromArgb(r, g, b);
			chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.ForeColor = Color.FromArgb(r, g, b);
			chart1.ChartAreas["ChartArea1"].AxisX.LineColor = Color.FromArgb(r, g, b);
			chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.ForeColor = Color.FromArgb(r, g, b);
			chart1.ChartAreas["ChartArea1"].AxisY.LineColor = Color.FromArgb(r, g, b);
			chart1.Legends["Legend1"].ForeColor = Color.FromArgb(r, g, b);
		}

		public void ChangeColor( int r, int g, int b)
		{
			label1.ForeColor = Color.FromArgb(r, g, b);
			label2.ForeColor = Color.FromArgb(r, g, b);
			label3.ForeColor = Color.FromArgb(r, g, b);
			label4.ForeColor = Color.FromArgb(r, g, b);
			label5.ForeColor = Color.FromArgb(r, g, b);
			label6.ForeColor = Color.FromArgb(r, g, b);
			chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.ForeColor = Color.FromArgb(r, g, b);
			chart1.ChartAreas["ChartArea1"].AxisX.LineColor = Color.FromArgb(r, g, b);
			chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.ForeColor = Color.FromArgb(r, g, b);
			chart1.ChartAreas["ChartArea1"].AxisY.LineColor = Color.FromArgb(r, g, b);
			chart1.Legends["Legend1"].ForeColor = Color.FromArgb(r, g, b);
		}

		public void DataType(int type)
		{
			switch (type)
			{
				case 0:
					chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
					break;
				case 1:
					chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
					break;
				case 2:
					chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
					break;
				case 3:
					chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
					break;
				case 4:
					chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
					break;
				case 5:
					chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
					break;
				case 6:
					chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
					break;
				case 7:
					chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
					break;
				case 8:
					chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
					break;
				case 9:
					chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
					break;
				case 10:
					chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Stock;
					break;
				case 11:
					chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
					break;
				case 12:
					chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineRange;
					break;
				case 13:
					chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
					break;
				case 14:
					chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
					break;
				case 15:
					chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
					break;
				case 16:
					chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot;
					break;
				case 17:
					chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko;
					break;
				case 18:
					chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel;
					break;
				case 19:
					chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
					break;
				default:
					chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
					break;
			}
		}
	}
}
