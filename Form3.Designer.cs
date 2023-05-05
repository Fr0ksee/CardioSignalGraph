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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AlphaBox = new System.Windows.Forms.GroupBox();
            this.AlphaLabel = new System.Windows.Forms.Label();
            this.AlphaBar = new System.Windows.Forms.TrackBar();
            this.ExponentionalRadioButton = new System.Windows.Forms.RadioButton();
            this.WidthBox = new System.Windows.Forms.GroupBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.WidthBar = new System.Windows.Forms.TrackBar();
            this.MovingAverageRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.AlphaBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlphaBar)).BeginInit();
            this.WidthBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthBar)).BeginInit();
            this.SuspendLayout();
            // 
            // chart3
            // 
            chartArea2.InnerPlotPosition.Auto = false;
            chartArea2.InnerPlotPosition.Height = 92F;
            chartArea2.InnerPlotPosition.Width = 99F;
            chartArea2.InnerPlotPosition.X = 1F;
            chartArea2.InnerPlotPosition.Y = 2.25F;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 97F;
            chartArea2.Position.Width = 99F;
            chartArea2.Position.X = 0.5F;
            chartArea2.Position.Y = 3F;
            this.chart3.ChartAreas.Add(chartArea2);
            this.chart3.Location = new System.Drawing.Point(12, 12);
            this.chart3.Name = "chart3";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Signal";
            this.chart3.Series.Add(series2);
            this.chart3.Size = new System.Drawing.Size(1180, 440);
            this.chart3.TabIndex = 18;
            this.chart3.Text = "chart1";
            // 
            // AlphaBox
            // 
            this.AlphaBox.Controls.Add(this.AlphaLabel);
            this.AlphaBox.Controls.Add(this.AlphaBar);
            this.AlphaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlphaBox.Location = new System.Drawing.Point(50, 465);
            this.AlphaBox.Margin = new System.Windows.Forms.Padding(2);
            this.AlphaBox.Name = "AlphaBox";
            this.AlphaBox.Padding = new System.Windows.Forms.Padding(2);
            this.AlphaBox.Size = new System.Drawing.Size(400, 70);
            this.AlphaBox.TabIndex = 21;
            this.AlphaBox.TabStop = false;
            this.AlphaBox.Text = "Параметр альфа";
            // 
            // AlphaLabel
            // 
            this.AlphaLabel.AutoSize = true;
            this.AlphaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlphaLabel.Location = new System.Drawing.Point(360, 20);
            this.AlphaLabel.Name = "AlphaLabel";
            this.AlphaLabel.Size = new System.Drawing.Size(16, 17);
            this.AlphaLabel.TabIndex = 22;
            this.AlphaLabel.Text = "0";
            // 
            // AlphaBar
            // 
            this.AlphaBar.Location = new System.Drawing.Point(10, 20);
            this.AlphaBar.Maximum = 100;
            this.AlphaBar.Name = "AlphaBar";
            this.AlphaBar.Size = new System.Drawing.Size(350, 45);
            this.AlphaBar.TabIndex = 0;
            this.AlphaBar.ValueChanged += new System.EventHandler(this.AlphaBar_ValueChanged);
            // 
            // ExponentionalRadioButton
            // 
            this.ExponentionalRadioButton.AutoSize = true;
            this.ExponentionalRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExponentionalRadioButton.Location = new System.Drawing.Point(950, 465);
            this.ExponentionalRadioButton.Name = "ExponentionalRadioButton";
            this.ExponentionalRadioButton.Size = new System.Drawing.Size(248, 20);
            this.ExponentionalRadioButton.TabIndex = 22;
            this.ExponentionalRadioButton.TabStop = true;
            this.ExponentionalRadioButton.Text = "Експоненційне згладжування";
            this.ExponentionalRadioButton.UseVisualStyleBackColor = true;
            this.ExponentionalRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // WidthBox
            // 
            this.WidthBox.Controls.Add(this.WidthLabel);
            this.WidthBox.Controls.Add(this.WidthBar);
            this.WidthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthBox.Location = new System.Drawing.Point(500, 465);
            this.WidthBox.Margin = new System.Windows.Forms.Padding(2);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Padding = new System.Windows.Forms.Padding(2);
            this.WidthBox.Size = new System.Drawing.Size(400, 70);
            this.WidthBox.TabIndex = 23;
            this.WidthBox.TabStop = false;
            this.WidthBox.Text = "Ширина вікна";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthLabel.Location = new System.Drawing.Point(360, 20);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(16, 17);
            this.WidthLabel.TabIndex = 22;
            this.WidthLabel.Text = "0";
            // 
            // WidthBar
            // 
            this.WidthBar.Location = new System.Drawing.Point(10, 20);
            this.WidthBar.Maximum = 20;
            this.WidthBar.Name = "WidthBar";
            this.WidthBar.Size = new System.Drawing.Size(350, 45);
            this.WidthBar.TabIndex = 0;
            // 
            // MovingAverageRadioButton
            // 
            this.MovingAverageRadioButton.AutoSize = true;
            this.MovingAverageRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovingAverageRadioButton.Location = new System.Drawing.Point(950, 510);
            this.MovingAverageRadioButton.Name = "MovingAverageRadioButton";
            this.MovingAverageRadioButton.Size = new System.Drawing.Size(145, 20);
            this.MovingAverageRadioButton.TabIndex = 24;
            this.MovingAverageRadioButton.TabStop = true;
            this.MovingAverageRadioButton.Text = "Ковзне середнє";
            this.MovingAverageRadioButton.UseVisualStyleBackColor = true;
            this.MovingAverageRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 560);
            this.Controls.Add(this.MovingAverageRadioButton);
            this.Controls.Add(this.WidthBox);
            this.Controls.Add(this.ExponentionalRadioButton);
            this.Controls.Add(this.AlphaBox);
            this.Controls.Add(this.chart3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.AlphaBox.ResumeLayout(false);
            this.AlphaBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlphaBar)).EndInit();
            this.WidthBox.ResumeLayout(false);
            this.WidthBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.GroupBox AlphaBox;
        private System.Windows.Forms.TrackBar AlphaBar;
        private System.Windows.Forms.Label AlphaLabel;
        private System.Windows.Forms.RadioButton ExponentionalRadioButton;
        private System.Windows.Forms.GroupBox WidthBox;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.TrackBar WidthBar;
        private System.Windows.Forms.RadioButton MovingAverageRadioButton;
    }
}