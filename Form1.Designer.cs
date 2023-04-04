namespace CardioSignalGraph
{
    partial class Form
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
            this.Pulse_OX_numeric = new System.Windows.Forms.NumericUpDown();
            this.ZubecBox = new System.Windows.Forms.GroupBox();
            this.radioButtonP = new System.Windows.Forms.RadioButton();
            this.radioButtonR = new System.Windows.Forms.RadioButton();
            this.radioButtonT = new System.Windows.Forms.RadioButton();
            this.radioButtonS = new System.Windows.Forms.RadioButton();
            this.radioButtonQ = new System.Windows.Forms.RadioButton();
            this.radioButtonST = new System.Windows.Forms.RadioButton();
            this.AmplitudeBox = new System.Windows.Forms.GroupBox();
            this.AmplitudeBar = new System.Windows.Forms.TrackBar();
            this.groupBoxAll = new System.Windows.Forms.GroupBox();
            this.WidthBox = new System.Windows.Forms.GroupBox();
            this.WidthBar2 = new System.Windows.Forms.TrackBar();
            this.WidthBar1 = new System.Windows.Forms.TrackBar();
            this.timeBox = new System.Windows.Forms.GroupBox();
            this.TimeBar = new System.Windows.Forms.TrackBar();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GridControlBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pulse_OX_numeric)).BeginInit();
            this.ZubecBox.SuspendLayout();
            this.AmplitudeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmplitudeBar)).BeginInit();
            this.groupBoxAll.SuspendLayout();
            this.WidthBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthBar1)).BeginInit();
            this.timeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.GridControlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pulse_OX_numeric
            // 
            this.Pulse_OX_numeric.Location = new System.Drawing.Point(4, 25);
            this.Pulse_OX_numeric.Margin = new System.Windows.Forms.Padding(2);
            this.Pulse_OX_numeric.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.Pulse_OX_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Pulse_OX_numeric.Name = "Pulse_OX_numeric";
            this.Pulse_OX_numeric.Size = new System.Drawing.Size(90, 19);
            this.Pulse_OX_numeric.TabIndex = 1;
            this.Pulse_OX_numeric.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // ZubecBox
            // 
            this.ZubecBox.Controls.Add(this.radioButtonP);
            this.ZubecBox.Controls.Add(this.radioButtonR);
            this.ZubecBox.Controls.Add(this.radioButtonT);
            this.ZubecBox.Controls.Add(this.radioButtonS);
            this.ZubecBox.Controls.Add(this.radioButtonQ);
            this.ZubecBox.Controls.Add(this.radioButtonST);
            this.ZubecBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZubecBox.Location = new System.Drawing.Point(380, 16);
            this.ZubecBox.Margin = new System.Windows.Forms.Padding(2);
            this.ZubecBox.Name = "ZubecBox";
            this.ZubecBox.Padding = new System.Windows.Forms.Padding(2);
            this.ZubecBox.Size = new System.Drawing.Size(64, 162);
            this.ZubecBox.TabIndex = 9;
            this.ZubecBox.TabStop = false;
            this.ZubecBox.Text = "Зубець";
            // 
            // radioButtonP
            // 
            this.radioButtonP.AutoSize = true;
            this.radioButtonP.Location = new System.Drawing.Point(4, 28);
            this.radioButtonP.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonP.Name = "radioButtonP";
            this.radioButtonP.Size = new System.Drawing.Size(33, 17);
            this.radioButtonP.TabIndex = 10;
            this.radioButtonP.TabStop = true;
            this.radioButtonP.Text = "P";
            this.radioButtonP.UseVisualStyleBackColor = true;
            // 
            // radioButtonR
            // 
            this.radioButtonR.AutoSize = true;
            this.radioButtonR.Location = new System.Drawing.Point(4, 70);
            this.radioButtonR.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonR.Name = "radioButtonR";
            this.radioButtonR.Size = new System.Drawing.Size(34, 17);
            this.radioButtonR.TabIndex = 12;
            this.radioButtonR.TabStop = true;
            this.radioButtonR.Text = "R";
            this.radioButtonR.UseVisualStyleBackColor = true;
            // 
            // radioButtonT
            // 
            this.radioButtonT.AutoSize = true;
            this.radioButtonT.Location = new System.Drawing.Point(4, 133);
            this.radioButtonT.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonT.Name = "radioButtonT";
            this.radioButtonT.Size = new System.Drawing.Size(33, 17);
            this.radioButtonT.TabIndex = 15;
            this.radioButtonT.TabStop = true;
            this.radioButtonT.Text = "T";
            this.radioButtonT.UseVisualStyleBackColor = true;
            // 
            // radioButtonS
            // 
            this.radioButtonS.AutoSize = true;
            this.radioButtonS.Location = new System.Drawing.Point(4, 91);
            this.radioButtonS.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonS.Name = "radioButtonS";
            this.radioButtonS.Size = new System.Drawing.Size(33, 17);
            this.radioButtonS.TabIndex = 13;
            this.radioButtonS.TabStop = true;
            this.radioButtonS.Text = "S";
            this.radioButtonS.UseVisualStyleBackColor = true;
            // 
            // radioButtonQ
            // 
            this.radioButtonQ.AutoSize = true;
            this.radioButtonQ.Location = new System.Drawing.Point(4, 49);
            this.radioButtonQ.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonQ.Name = "radioButtonQ";
            this.radioButtonQ.Size = new System.Drawing.Size(34, 17);
            this.radioButtonQ.TabIndex = 11;
            this.radioButtonQ.TabStop = true;
            this.radioButtonQ.Text = "Q";
            this.radioButtonQ.UseVisualStyleBackColor = true;
            // 
            // radioButtonST
            // 
            this.radioButtonST.AutoSize = true;
            this.radioButtonST.Location = new System.Drawing.Point(4, 112);
            this.radioButtonST.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonST.Name = "radioButtonST";
            this.radioButtonST.Size = new System.Drawing.Size(41, 17);
            this.radioButtonST.TabIndex = 14;
            this.radioButtonST.TabStop = true;
            this.radioButtonST.Text = "ST";
            this.radioButtonST.UseVisualStyleBackColor = true;
            // 
            // AmplitudeBox
            // 
            this.AmplitudeBox.Controls.Add(this.AmplitudeBar);
            this.AmplitudeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmplitudeBox.Location = new System.Drawing.Point(4, 16);
            this.AmplitudeBox.Margin = new System.Windows.Forms.Padding(2);
            this.AmplitudeBox.Name = "AmplitudeBox";
            this.AmplitudeBox.Padding = new System.Windows.Forms.Padding(2);
            this.AmplitudeBox.Size = new System.Drawing.Size(366, 66);
            this.AmplitudeBox.TabIndex = 10;
            this.AmplitudeBox.TabStop = false;
            this.AmplitudeBox.Text = "Амплітуда";
            // 
            // AmplitudeBar
            // 
            this.AmplitudeBar.Location = new System.Drawing.Point(5, 17);
            this.AmplitudeBar.Name = "AmplitudeBar";
            this.AmplitudeBar.Size = new System.Drawing.Size(356, 45);
            this.AmplitudeBar.TabIndex = 0;
            // 
            // groupBoxAll
            // 
            this.groupBoxAll.Controls.Add(this.WidthBox);
            this.groupBoxAll.Controls.Add(this.timeBox);
            this.groupBoxAll.Controls.Add(this.ZubecBox);
            this.groupBoxAll.Controls.Add(this.AmplitudeBox);
            this.groupBoxAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAll.Location = new System.Drawing.Point(515, 10);
            this.groupBoxAll.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAll.Name = "groupBoxAll";
            this.groupBoxAll.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAll.Size = new System.Drawing.Size(458, 334);
            this.groupBoxAll.TabIndex = 16;
            this.groupBoxAll.TabStop = false;
            // 
            // WidthBox
            // 
            this.WidthBox.Controls.Add(this.WidthBar2);
            this.WidthBox.Controls.Add(this.WidthBar1);
            this.WidthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthBox.Location = new System.Drawing.Point(4, 184);
            this.WidthBox.Margin = new System.Windows.Forms.Padding(2);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Padding = new System.Windows.Forms.Padding(2);
            this.WidthBox.Size = new System.Drawing.Size(366, 132);
            this.WidthBox.TabIndex = 18;
            this.WidthBox.TabStop = false;
            this.WidthBox.Text = "Ширина";
            // 
            // WidthBar2
            // 
            this.WidthBar2.Location = new System.Drawing.Point(5, 82);
            this.WidthBar2.Name = "WidthBar2";
            this.WidthBar2.Size = new System.Drawing.Size(356, 45);
            this.WidthBar2.TabIndex = 1;
            // 
            // WidthBar1
            // 
            this.WidthBar1.Location = new System.Drawing.Point(5, 17);
            this.WidthBar1.Name = "WidthBar1";
            this.WidthBar1.Size = new System.Drawing.Size(356, 45);
            this.WidthBar1.TabIndex = 0;
            // 
            // timeBox
            // 
            this.timeBox.Controls.Add(this.TimeBar);
            this.timeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeBox.Location = new System.Drawing.Point(4, 100);
            this.timeBox.Margin = new System.Windows.Forms.Padding(2);
            this.timeBox.Name = "timeBox";
            this.timeBox.Padding = new System.Windows.Forms.Padding(2);
            this.timeBox.Size = new System.Drawing.Size(366, 66);
            this.timeBox.TabIndex = 11;
            this.timeBox.TabStop = false;
            this.timeBox.Text = "Час";
            // 
            // TimeBar
            // 
            this.TimeBar.Location = new System.Drawing.Point(5, 17);
            this.TimeBar.Name = "TimeBar";
            this.TimeBar.Size = new System.Drawing.Size(356, 45);
            this.TimeBar.TabIndex = 0;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Location = new System.Drawing.Point(10, 10);
            this.chart.Name = "chart";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Signal";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(500, 500);
            this.chart.TabIndex = 17;
            this.chart.Text = "chart1";
            // 
            // GridControlBox
            // 
            this.GridControlBox.Controls.Add(this.Pulse_OX_numeric);
            this.GridControlBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridControlBox.Location = new System.Drawing.Point(515, 348);
            this.GridControlBox.Margin = new System.Windows.Forms.Padding(2);
            this.GridControlBox.Name = "GridControlBox";
            this.GridControlBox.Padding = new System.Windows.Forms.Padding(2);
            this.GridControlBox.Size = new System.Drawing.Size(116, 66);
            this.GridControlBox.TabIndex = 18;
            this.GridControlBox.TabStop = false;
            this.GridControlBox.Text = "ЧСС уд/хв";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 521);
            this.Controls.Add(this.GridControlBox);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.groupBoxAll);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form";
            this.Text = "Модель кардіоцикла";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pulse_OX_numeric)).EndInit();
            this.ZubecBox.ResumeLayout(false);
            this.ZubecBox.PerformLayout();
            this.AmplitudeBox.ResumeLayout(false);
            this.AmplitudeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmplitudeBar)).EndInit();
            this.groupBoxAll.ResumeLayout(false);
            this.WidthBox.ResumeLayout(false);
            this.WidthBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthBar1)).EndInit();
            this.timeBox.ResumeLayout(false);
            this.timeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.GridControlBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.NumericUpDown Pulse_OX_numeric;
        private System.Windows.Forms.GroupBox ZubecBox;
        private System.Windows.Forms.RadioButton radioButtonP;
        private System.Windows.Forms.RadioButton radioButtonR;
        private System.Windows.Forms.RadioButton radioButtonT;
        private System.Windows.Forms.RadioButton radioButtonS;
        private System.Windows.Forms.RadioButton radioButtonQ;
        private System.Windows.Forms.RadioButton radioButtonST;
        private System.Windows.Forms.GroupBox AmplitudeBox;
        private System.Windows.Forms.GroupBox groupBoxAll;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TrackBar AmplitudeBar;
        private System.Windows.Forms.GroupBox WidthBox;
        private System.Windows.Forms.TrackBar WidthBar2;
        private System.Windows.Forms.TrackBar WidthBar1;
        private System.Windows.Forms.GroupBox timeBox;
        private System.Windows.Forms.TrackBar TimeBar;
        private System.Windows.Forms.GroupBox GridControlBox;
    }
}

