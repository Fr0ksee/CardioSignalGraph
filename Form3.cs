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
    public partial class Form3 : System.Windows.Forms.Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public List<double> xValues = new List<double>();
        public List<double> yValues = new List<double>();
        public List<double> yChangedValues = new List<double>();
        private void Form3_Load(object sender, EventArgs e)
        {
            AlphaBar.Enabled = false;
            WidthBar.Enabled = false;

            chart3.ChartAreas[0].AxisY.Maximum = 1.2;
            chart3.ChartAreas[0].AxisY.Minimum = -0.4;
            chart3.ChartAreas[0].AxisY.Interval = 0.1;

            chart3.ChartAreas[0].AxisX.Minimum = 0;
            chart3.ChartAreas[0].AxisX.Interval = 1;
            chart3.Size = Form2.instance.chart2.Size;
            Series series = Form2.instance.chart2.Series[0];

            foreach (DataPoint point in series.Points)
            {
                xValues.Add(point.XValue);
                yValues.Add(point.YValues[0]);
            }
            chart3.Series[0].Points.DataBindXY(xValues, yValues);
        }
        private void ExponentialSmoothing()
        {
            yChangedValues.Clear();
            double prevSmoothedValue = yValues[0];
            yChangedValues.Add(prevSmoothedValue);

            for (int i = 1; i < yValues.Count; i++)
            {
                double currentValue = yValues[i];
                double smoothedValue = (AlphaBar.Value/100.0) * currentValue + (1 - (AlphaBar.Value / 100.0)) * prevSmoothedValue;
                yChangedValues.Add(smoothedValue);
                prevSmoothedValue = smoothedValue;
            }
            chart3.Series[0].Points.Clear();
            chart3.Series[0].Points.DataBindXY(xValues, yChangedValues);
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ExponentionalRadioButton.Checked)
            {
                AlphaBar.Enabled = true;
                WidthBar.Enabled = false;
            }
            if (MovingAverageRadioButton.Checked)
            {
                AlphaBar.Enabled = false;
                WidthBar.Enabled = true;
            }
        }

        private void AlphaBar_ValueChanged(object sender, EventArgs e)
        {
            AlphaLabel.Text = Convert.ToString(AlphaBar.Value / 100.0);
            ExponentialSmoothing();
        }
    }
}
