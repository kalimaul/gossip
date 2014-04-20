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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(50D, 1D);
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.kValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kValue)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.AxisX.Maximum = 1D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.Title = "p";
            chartArea2.AxisY.Maximum = 1D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY.Title = "ratio";
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Reachability";
            series3.Points.Add(dataPoint3);
            series3.Points.Add(dataPoint4);
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Usage";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
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
            this.label1.Location = new System.Drawing.Point(886, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "k =";
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kValue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "GraphForm";
            this.Text = "GraphForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown kValue;
        private System.Windows.Forms.Label label1;
    }
}