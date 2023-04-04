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
    class SignalWave
    {
        private double amplitude;
        private double amp_moment;
        private double width;

        public SignalWave(double amplitude, double amp_moment, double width)
        {
            this.amplitude = amplitude;
            this.amp_moment = amp_moment;
            this.width = width;
        }
        public void SetAmplitude(double amplitude){this.amplitude = amplitude;}
        public void SetAmplitudeMoment(double amp_moment){this.amp_moment = amp_moment;}
        public void SetWidth(double width){this.width = width;}

        public double GetAmplitude() {return this.amplitude;}
        public double GetAmplitudeMoment() {return this.amp_moment;}
        public double GetWidth() { return this.width; }
    }

    public partial class Form : System.Windows.Forms.Form
    {

        private double x, y;
        public Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            x = 0;
            y = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart.ChartAreas[0].AxisY.Maximum = 1.2;
            chart.ChartAreas[0].AxisY.Minimum = -0.4;
            chart.ChartAreas[0].AxisY.Interval = 0.1;

            chart.ChartAreas[0].AxisX.Maximum = 1;
            chart.ChartAreas[0].AxisX.Minimum = 0;
            chart.ChartAreas[0].AxisX.Interval = 0.1;

            SignalWave[] arr = new SignalWave[5];
            var P = new SignalWave( 0.1,  0.4, 0.12);
            var Q = new SignalWave(-0.1, 0.46, 0.02);
            var R = new SignalWave(1, 0.5, 0.04);
            var S = new SignalWave(-0.17, 0.54, 0.04);
            var T = new SignalWave(0.2, 0.7, 0.18);
            arr[0] = P;
            arr[1] = Q;
            arr[2] = R;
            arr[3] = S;
            arr[4] = T;
            Chart_Update(arr);
        }

        private void Chart_Update(SignalWave[] arr)
        {
            chart.Series[0].Points.Clear();
            double[] yValues = new double[1000];

            for (int i = 0; i < arr.Length; i++)
            {
                double a = arr[i].GetAmplitude();
                double m = arr[i].GetAmplitudeMoment();
                double w = arr[i].GetWidth();
                double start = m - w / 2.0;
                double end = m + w / 2.0;

                for (int j = 0; j < yValues.Length; j++)
                {
                    double x = j / 1000.0;

                    if (x >= start && x <= end)
                    {
                        double y = a * Math.Exp(-((Math.Pow(x - m, 2)) / (2 * Math.Pow(w, 2))));
                        yValues[j] += y;
                    }
                }
            }

            for (int i = 0; i < yValues.Length; i++)
            {
                double x = i / 1000.0;
                chart.Series[0].Points.AddXY(x, yValues[i]);
            }
        }


    }
}