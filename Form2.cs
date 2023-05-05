using System;
using System.CodeDom.Compiler;
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
        public static Form2 instance;

        public Form2()
        {
            InitializeComponent();
            instance = this;
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

            double[] yValues = new double[500];

            for (int i = 0; i < Form.instance.arr.Length; i++)
            {
                double a = Form.instance.arr[i].current_amplitude;
                double m = Form.instance.arr[i].current_moment;

                Random random = new Random();
                for (int j = 0; j < yValues.Length; j++)
                {

                    double x = j / 500.0;
                    double w = Form.instance.arr[i].l_width;
                    double randomNumber = (0 - (NoiceBar.Value/1000.0)) + (random.NextDouble() * ((NoiceBar.Value/1000.0) - (0 - (NoiceBar.Value/1000.0))));
                    if (x > m)
                    {
                        w = Form.instance.arr[i].r_width;
                    }
                    double y = a * Math.Exp(-((Math.Pow(x - m, 2)) / (2 * Math.Pow(w, 2))));
                    y += randomNumber;
                    yValues[j] += y;
                }
            }

            double[] yAltValues = new double[500];

            for (int i = 0; i < Form.instance.arr.Length; i++)
            {
                double a = Form.instance.arr[i].current_amplitude;
                double m = Form.instance.arr[i].current_moment;
                Random random = new Random();
                for (int j = 0; j < yAltValues.Length; j++)
                {
                    double x = j / 500.0;
                    double w = Form.instance.arr[i].l_width;
                    double randomNumber = (0 - (NoiceBar.Value/1000.0)) + (random.NextDouble() * ((NoiceBar.Value/1000.0) - (0 - (NoiceBar.Value/1000.0))));
                    if (x > m)
                    {
                        w = Form.instance.arr[i].r_width;
                    }
                    if (i == 4)
                    {
                        double y = (1 + ((AlternationBar.Value/1000.0)/a))*a * Math.Exp(-((Math.Pow(x - m, 2)) / (2 * Math.Pow(w, 2))));
                        y += randomNumber;
                        yAltValues[j] += y;
                    }
                    else
                    {
                        double y = a * Math.Exp(-((Math.Pow(x - m, 2)) / (2 * Math.Pow(w, 2))));
                        y += randomNumber;
                        yAltValues[j] += y;
                    }
                    
                }
            }

            double TempOxIndex = 1/(Convert.ToDouble(Form.instance.Pulse_OX_numeric.Value) * 1000 / 60);
            double[] xAllValues = new double[yValues.Length * Convert.ToInt32(Cycle_numeric.Value)];
            double[] yAllValues = new double[yValues.Length * Convert.ToInt32(Cycle_numeric.Value)];
            for (int i = 0; i < Cycle_numeric.Value; i++)
            {
                if (i % 2 == 0) Array.Copy(yValues, 0, yAllValues, i*yValues.Length, yValues.Length);
                else Array.Copy(yAltValues, 0, yAllValues, i * yAltValues.Length, yAltValues.Length);
                for (int j = 0; j < yValues.Length; j++)
                {
                    xAllValues[j + (i * yValues.Length)] = (j + (i * yValues.Length)) * TempOxIndex * (1000/ yValues.Length);
                }
            }
            chart2.Series[0].Points.DataBindXY(xAllValues, yAllValues);

        }

        private void AlternationBar_ValueChanged(object sender, EventArgs e)
        {
            Chart2_Update();
        }

        private void Cycle_numeric_ValueChanged(object sender, EventArgs e)
        {
            Chart2_Update();
        }

        private void NoiceBar_ValueChanged(object sender, EventArgs e)
        {
            Chart2_Update();
        }

        private void SmoothingButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}