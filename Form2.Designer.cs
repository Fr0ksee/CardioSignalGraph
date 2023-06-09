﻿namespace CardioSignalGraph
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CycleBox = new System.Windows.Forms.GroupBox();
            this.Cycle_numeric = new System.Windows.Forms.NumericUpDown();
            this.AlternationBox = new System.Windows.Forms.GroupBox();
            this.AlternationBar = new System.Windows.Forms.TrackBar();
            this.NoiceBox = new System.Windows.Forms.GroupBox();
            this.NoiceBar = new System.Windows.Forms.TrackBar();
            this.SmoothingButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.CycleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cycle_numeric)).BeginInit();
            this.AlternationBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlternationBar)).BeginInit();
            this.NoiceBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoiceBar)).BeginInit();
            this.SuspendLayout();
            // 
            // chart2
            // 
            chartArea3.InnerPlotPosition.Auto = false;
            chartArea3.InnerPlotPosition.Height = 92F;
            chartArea3.InnerPlotPosition.Width = 99F;
            chartArea3.InnerPlotPosition.X = 1F;
            chartArea3.InnerPlotPosition.Y = 2.25F;
            chartArea3.Name = "ChartArea1";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 97F;
            chartArea3.Position.Width = 99F;
            chartArea3.Position.X = 0.5F;
            chartArea3.Position.Y = 3F;
            this.chart2.ChartAreas.Add(chartArea3);
            this.chart2.Location = new System.Drawing.Point(12, 12);
            this.chart2.Name = "chart2";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Name = "Signal";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(1180, 440);
            this.chart2.TabIndex = 18;
            this.chart2.Text = "chart1";
            // 
            // CycleBox
            // 
            this.CycleBox.Controls.Add(this.Cycle_numeric);
            this.CycleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CycleBox.Location = new System.Drawing.Point(50, 465);
            this.CycleBox.Margin = new System.Windows.Forms.Padding(2);
            this.CycleBox.Name = "CycleBox";
            this.CycleBox.Padding = new System.Windows.Forms.Padding(2);
            this.CycleBox.Size = new System.Drawing.Size(120, 70);
            this.CycleBox.TabIndex = 20;
            this.CycleBox.TabStop = false;
            this.CycleBox.Text = "Кількість циклів";
            // 
            // Cycle_numeric
            // 
            this.Cycle_numeric.Location = new System.Drawing.Point(20, 25);
            this.Cycle_numeric.Margin = new System.Windows.Forms.Padding(2);
            this.Cycle_numeric.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.Cycle_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Cycle_numeric.Name = "Cycle_numeric";
            this.Cycle_numeric.Size = new System.Drawing.Size(80, 19);
            this.Cycle_numeric.TabIndex = 1;
            this.Cycle_numeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Cycle_numeric.ValueChanged += new System.EventHandler(this.Cycle_numeric_ValueChanged);
            // 
            // AlternationBox
            // 
            this.AlternationBox.Controls.Add(this.AlternationBar);
            this.AlternationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlternationBox.Location = new System.Drawing.Point(200, 465);
            this.AlternationBox.Margin = new System.Windows.Forms.Padding(2);
            this.AlternationBox.Name = "AlternationBox";
            this.AlternationBox.Padding = new System.Windows.Forms.Padding(2);
            this.AlternationBox.Size = new System.Drawing.Size(370, 70);
            this.AlternationBox.TabIndex = 19;
            this.AlternationBox.TabStop = false;
            this.AlternationBox.Text = "Рівень альтернації, мв";
            // 
            // AlternationBar
            // 
            this.AlternationBar.Location = new System.Drawing.Point(10, 20);
            this.AlternationBar.Maximum = 100;
            this.AlternationBar.Minimum = -100;
            this.AlternationBar.Name = "AlternationBar";
            this.AlternationBar.Size = new System.Drawing.Size(350, 45);
            this.AlternationBar.TabIndex = 0;
            this.AlternationBar.ValueChanged += new System.EventHandler(this.AlternationBar_ValueChanged);
            // 
            // NoiceBox
            // 
            this.NoiceBox.Controls.Add(this.NoiceBar);
            this.NoiceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoiceBox.Location = new System.Drawing.Point(600, 465);
            this.NoiceBox.Margin = new System.Windows.Forms.Padding(2);
            this.NoiceBox.Name = "NoiceBox";
            this.NoiceBox.Padding = new System.Windows.Forms.Padding(2);
            this.NoiceBox.Size = new System.Drawing.Size(370, 70);
            this.NoiceBox.TabIndex = 20;
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
            this.NoiceBar.ValueChanged += new System.EventHandler(this.NoiceBar_ValueChanged);
            // 
            // SmoothingButton
            // 
            this.SmoothingButton.Location = new System.Drawing.Point(1000, 465);
            this.SmoothingButton.Name = "SmoothingButton";
            this.SmoothingButton.Size = new System.Drawing.Size(120, 70);
            this.SmoothingButton.TabIndex = 21;
            this.SmoothingButton.Text = "Згладжування";
            this.SmoothingButton.UseVisualStyleBackColor = true;
            this.SmoothingButton.Click += new System.EventHandler(this.SmoothingButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 560);
            this.Controls.Add(this.SmoothingButton);
            this.Controls.Add(this.NoiceBox);
            this.Controls.Add(this.CycleBox);
            this.Controls.Add(this.AlternationBox);
            this.Controls.Add(this.chart2);
            this.Name = "Form2";
            this.Text = "Electrocardiogram model";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.CycleBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Cycle_numeric)).EndInit();
            this.AlternationBox.ResumeLayout(false);
            this.AlternationBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlternationBar)).EndInit();
            this.NoiceBox.ResumeLayout(false);
            this.NoiceBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoiceBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.GroupBox CycleBox;
        public System.Windows.Forms.NumericUpDown Cycle_numeric;
        private System.Windows.Forms.GroupBox AlternationBox;
        private System.Windows.Forms.TrackBar AlternationBar;
        private System.Windows.Forms.GroupBox NoiceBox;
        private System.Windows.Forms.TrackBar NoiceBar;
        private System.Windows.Forms.Button SmoothingButton;
    }
}