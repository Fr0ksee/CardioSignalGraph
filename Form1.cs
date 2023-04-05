using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardioSignalGraph
{
    public partial class Form : System.Windows.Forms.Form
    {
        public SignalWave P = new SignalWave(0.1, 0.4, 0.02);
        public SignalWave Q = new SignalWave(-0.1, 0.46, 0.01);
        public SignalWave R = new SignalWave(1, 0.5, 0.01);
        public SignalWave S = new SignalWave(-0.17, 0.54, 0.02);
        public SignalWave T = new SignalWave(0.2, 0.7, 0.04);

        public Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Default_Values()
        {
            SignalWave[] arr = new SignalWave[5];
            //var P = new SignalWave(0.1, 0.4, 0.02);
            //var Q = new SignalWave(-0.1, 0.46, 0.01);
            //var R = new SignalWave(1, 0.5, 0.01);
            //var S = new SignalWave(-0.17, 0.54, 0.02);
            //var T = new SignalWave(0.2, 0.7, 0.04);
            arr[0] = P;
            arr[1] = Q;
            arr[2] = R;
            arr[3] = S;
            arr[4] = T;
            int check;
            if (radioButtonP.Checked) { check = 0; }
            else if (radioButtonQ.Checked) { check = 1; }
            else if (radioButtonR.Checked) { check = 2; }
            else if (radioButtonS.Checked) { check = 3; }
            else if (radioButtonT.Checked) { check = 4; }
            else { check = -1; }
            Chart_Update(arr, check);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            chart.ChartAreas[0].AxisY.Maximum = 1.2;
            chart.ChartAreas[0].AxisY.Minimum = -0.4;
            chart.ChartAreas[0].AxisY.Interval = 0.1;

            chart.ChartAreas[0].AxisX.Maximum = 1;
            chart.ChartAreas[0].AxisX.Minimum = 0;
            chart.ChartAreas[0].AxisX.Interval = 0.1;

            Default_Values();
        }

        private void WidthBar1_ValueChanged(object sender, EventArgs e)
        { 
            if (!radioButtonT.Checked)
                WidthBar2.Value = WidthBar1.Value;
            Default_Values();
        }

        private void WidthBar2_ValueChanged(object sender, EventArgs e)
        {
            if (!radioButtonT.Checked)
                WidthBar1.Value = WidthBar2.Value;
            Default_Values();
        }

        private void Chart_Update(SignalWave[] arr, int check)
        {
            chart.Series[0].Points.Clear();
            double[] yValues = new double[1000];

            for (int i = 0; i < arr.Length; i++)
            {
                double a = arr[i].amplitude;
                double m = arr[i].amp_moment;
                

                for (int j = 0; j < yValues.Length; j++)
                {
                    double w = arr[i].width;
                    double x = j / 1000.0;
                    if (x < m && i == check)
                    {
                        double temp = WidthBar1.Value / 10.0;
                        w = w * temp; 
                    }
                    else if (x > m && i == check)
                    {
                        double temp = WidthBar2.Value / 10.0;
                        w = w * temp; 
                    }
                    double y = a * Math.Exp(-((Math.Pow(x - m, 2)) / (2 * Math.Pow(w, 2))));
                    yValues[j] += y;
                }
            }

            for (int i = 0; i < yValues.Length; i++)
            {
                double x = i / 1000.0;
                chart.Series[0].Points.AddXY(x, yValues[i]);
            }
        }
    }
    public class SignalWave
    {
        public double amplitude { get; set; }
        public double  amp_moment { get; set; }
        public double width { get; set; }


        public SignalWave(double amplitude, double amp_moment, double width)
        {
            this.amplitude = amplitude;
            this.amp_moment = amp_moment;
            this.width = width;
        }
    }
}