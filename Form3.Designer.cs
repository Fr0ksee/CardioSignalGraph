using System.Windows.Forms.DataVisualization.Charting;

namespace CardioSignalGraph
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.NoiceBox = new System.Windows.Forms.GroupBox();
            this.NoiceBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.NoiceBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoiceBar)).BeginInit();
            this.SuspendLayout();
            // 
            // chart3
            // 
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 92F;
            chartArea1.InnerPlotPosition.Width = 99F;
            chartArea1.InnerPlotPosition.X = 1F;
            chartArea1.InnerPlotPosition.Y = 2.25F;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 97F;
            chartArea1.Position.Width = 99F;
            chartArea1.Position.X = 0.5F;
            chartArea1.Position.Y = 3F;
            this.chart3.ChartAreas.Add(chartArea1);
            this.chart3.Location = new System.Drawing.Point(12, 12);
            this.chart3.Name = "chart3";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Signal";
            this.chart3.Series.Add(series1);
            this.chart3.Size = new System.Drawing.Size(1180, 440);
            this.chart3.TabIndex = 18;
            this.chart3.Text = "chart1";
            // 
            // NoiceBox
            // 
            this.NoiceBox.Controls.Add(this.NoiceBar);
            this.NoiceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoiceBox.Location = new System.Drawing.Point(50, 465);
            this.NoiceBox.Margin = new System.Windows.Forms.Padding(2);
            this.NoiceBox.Name = "NoiceBox";
            this.NoiceBox.Padding = new System.Windows.Forms.Padding(2);
            this.NoiceBox.Size = new System.Drawing.Size(402, 70);
            this.NoiceBox.TabIndex = 21;
            this.NoiceBox.TabStop = false;
            this.NoiceBox.Text = "Рівень шуму";
            // 
            // NoiceBar
            // 
            this.NoiceBar.Location = new System.Drawing.Point(10, 20);
            this.NoiceBar.Maximum = 20;
            this.NoiceBar.Name = "NoiceBar";
            this.NoiceBar.Size = new System.Drawing.Size(350, 45);
            this.NoiceBar.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 560);
            this.Controls.Add(this.NoiceBox);
            this.Controls.Add(this.chart3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.NoiceBox.ResumeLayout(false);
            this.NoiceBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoiceBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.GroupBox NoiceBox;
        private System.Windows.Forms.TrackBar NoiceBar;
    }
}