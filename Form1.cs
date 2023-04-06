using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CardioSignalGraph
{
    public partial class Form : System.Windows.Forms.Form
    {
        public SignalWave P = new SignalWave(0.1, 0.4, 0.02);
        public SignalWave Q = new SignalWave(-0.1, 0.46, 0.01);
        public SignalWave R = new SignalWave(1, 0.5, 0.01);
        public SignalWave S = new SignalWave(-0.17, 0.54, 0.02);
        public SignalWave T = new SignalWave(0.2, 0.7, 0.04);
        public SignalWave[] arr = new SignalWave[5];

        public Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart.ChartAreas[0].AxisY.Maximum = 1.2;
            chart.ChartAreas[0].AxisY.Minimum = -0.4;
            chart.ChartAreas[0].AxisY.Interval = 0.1;

            chart.ChartAreas[0].AxisX.Maximum = 1;
            chart.ChartAreas[0].AxisX.Minimum = 0;
            chart.ChartAreas[0].AxisX.Interval = 0.1;
            Arr_init();
            Chart_Update();
        }

        private void WidthBar1_ValueChanged(object sender, EventArgs e)
        { 
            if (!radioButtonT.Checked)
                WidthBar2.Value = WidthBar1.Value;
            
            double temp_value = WidthBar1.Value / 10.0;
            arr[RadioButtonCheck()].l_width = arr[RadioButtonCheck()].width * temp_value;

            Chart_Update();
        }

        private void WidthBar2_ValueChanged(object sender, EventArgs e)
        {
            if (!radioButtonT.Checked)
                WidthBar1.Value = WidthBar2.Value;

            double temp_value = WidthBar2.Value / 10.0;
            arr[RadioButtonCheck()].r_width = arr[RadioButtonCheck()].width * temp_value;

            Chart_Update();
        }

        private void Chart_Update()
        {
            chart.Series[0].Points.Clear();
            int check = RadioButtonCheck();

            double[] yValues = new double[1000];

            for (int i = 0; i < arr.Length; i++)
            {
                double a = arr[i].amplitude;
                double m = arr[i].amp_moment;
                

                for (int j = 0; j < yValues.Length; j++)
                {
                    
                    double x = j / 1000.0;
                    double w = arr[i].l_width;
                    if (x > m)
                    {
                        w = arr[i].r_width;
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

        private int RadioButtonCheck()
        {
            if (radioButtonP.Checked) { return 0; }
            else if (radioButtonQ.Checked) { return 1; }
            else if (radioButtonR.Checked) { return 2; }
            else if (radioButtonS.Checked) { return 3; }
            else if (radioButtonT.Checked) { return 4; }
            else { return -1; }
        }

        public void Arr_init()
        {
            arr[0] = P;
            arr[1] = Q;
            arr[2] = R;
            arr[3] = S;
            arr[4] = T;
        }

        private void TimeBar_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    public class SignalWave
    {
        public double amplitude { get; set; }
        public double  amp_moment { get; set; }
        public double width { get; set; }
        public double r_width { get; set; }
        public double l_width { get; set; }
        public double temp_amplitude { get; set; }
        public double temp_moment { get; set; }

        public SignalWave(double amplitude, double amp_moment, double width)
        {
            this.amplitude = amplitude;
            this.temp_amplitude = amplitude;
            this.amp_moment = amp_moment;
            this.temp_moment = amp_moment;
            this.width = width;
            this.r_width = width;
            this.l_width = width;
        }
    }
}