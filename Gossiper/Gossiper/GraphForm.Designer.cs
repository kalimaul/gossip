namespace Gossiper
{
    partial class GraphForm
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(50D, 1D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.kValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.nodeDist = new System.Windows.Forms.NumericUpDown();
            this.nodeCount = new System.Windows.Forms.NumericUpDown();
            this.width = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.simulations = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulations)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Maximum = 1D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "p";
            chartArea1.AxisY.Maximum = 1D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "ratio";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Reachability";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Usage";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1001, 453);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(823, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Simulate!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kValue
            // 
            this.kValue.Location = new System.Drawing.Point(919, 300);
            this.kValue.Name = "kValue";
            this.kValue.Size = new System.Drawing.Size(57, 22);
            this.kValue.TabIndex = 2;
            this.kValue.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(855, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "k";
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(920, 211);
            this.height.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(56, 22);
            this.height.TabIndex = 4;
            this.height.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // nodeDist
            // 
            this.nodeDist.Location = new System.Drawing.Point(920, 239);
            this.nodeDist.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nodeDist.Name = "nodeDist";
            this.nodeDist.Size = new System.Drawing.Size(56, 22);
            this.nodeDist.TabIndex = 5;
            this.nodeDist.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // nodeCount
            // 
            this.nodeCount.Location = new System.Drawing.Point(920, 267);
            this.nodeCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nodeCount.Name = "nodeCount";
            this.nodeCount.Size = new System.Drawing.Size(56, 22);
            this.nodeCount.TabIndex = 6;
            this.nodeCount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(920, 183);
            this.width.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(56, 22);
            this.width.TabIndex = 7;
            this.width.Value = new decimal(new int[] {
            7500,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(855, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(855, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(848, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "node dist";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(835, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "node count";
            // 
            // simulations
            // 
            this.simulations.Location = new System.Drawing.Point(920, 155);
            this.simulations.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.simulations.Name = "simulations";
            this.simulations.Size = new System.Drawing.Size(56, 22);
            this.simulations.TabIndex = 12;
            this.simulations.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(824, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "simulations";
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 465);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.simulations);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.width);
            this.Controls.Add(this.nodeCount);
            this.Controls.Add(this.nodeDist);
            this.Controls.Add(this.height);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kValue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "GraphForm";
            this.Text = "GraphForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown kValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.NumericUpDown nodeDist;
        private System.Windows.Forms.NumericUpDown nodeCount;
        private System.Windows.Forms.NumericUpDown width;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown simulations;
        private System.Windows.Forms.Label label6;
    }
}