using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CardioSignalGraph
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            chart2.ChartAreas[0].AxisY.Maximum = 1.2;
            chart2.ChartAreas[0].AxisY.Minimum = -0.4;
            chart2.ChartAreas[0].AxisY.Interval = 0.1;

            chart2.ChartAreas[0].AxisX.Minimum = 0;
            chart2.ChartAreas[0].AxisX.Interval = 1;
            Chart2_Update();
        }
        public void Chart2_Update()
        {
            chart2.Size = new System.Drawing.Size(300 * Convert.ToInt32(Cycle_numeric.Value), 440);
            chart2.Series[0].Points.Clear();
            int check = Form.instance.RadioButtonCheck();

            double[] yValues = new double[1000];

            for (int i = 0; i < Form.instance.arr.Length; i++)
            {
                double a = Form.instance.arr[i].current_amplitude;
                double m = Form.instance.arr[i].current_moment;


                for (int j = 0; j < yValues.Length; j++)
                {

                    double x = j / 1000.0;
                    double w = Form.instance.arr[i].l_width;
                    if (x > m)
                    {
                        w = Form.instance.arr[i].r_width;
                    }
                    double y = a * Math.Exp(-((Math.Pow(x - m, 2)) / (2 * Math.Pow(w, 2))));
                    yValues[j] += y;
                }
            }
            for (int i = 0; i <  Cycle_numeric.Value; i++)
            {
                for (int j = 0; j < yValues.Length; j++)
                {
                    double x = j / (Convert.ToDouble(Form.instance.Pulse_OX_numeric.Value) * 1000 / 60);
                    chart2.Series[0].Points.AddXY((x + (i * Form.instance.chart.ChartAreas[0].AxisX.Maximum)), yValues[j]);
                }
            }

        }
    }
}
