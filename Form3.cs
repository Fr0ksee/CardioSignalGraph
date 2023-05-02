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
    public partial class Form3 : System.Windows.Forms.Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

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
    }
}
