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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gossip1Button = new System.Windows.Forms.Button();
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
            this.n = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.gossip1Box = new System.Windows.Forms.CheckBox();
            this.gossip2Box = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Transparent;
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
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chart1.Size = new System.Drawing.Size(1001, 453);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // gossip1Button
            // 
            this.gossip1Button.Location = new System.Drawing.Point(995, 441);
            this.gossip1Button.Name = "gossip1Button";
            this.gossip1Button.Size = new System.Drawing.Size(178, 49);
            this.gossip1Button.TabIndex = 1;
            this.gossip1Button.Text = "Simulate!";
            this.gossip1Button.UseVisualStyleBackColor = true;
            this.gossip1Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // kValue
            // 
            this.kValue.Location = new System.Drawing.Point(1112, 228);
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
            this.label1.Location = new System.Drawing.Point(1048, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "n";
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(1113, 139);
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
            this.nodeDist.Location = new System.Drawing.Point(1113, 167);
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
            this.nodeCount.Location = new System.Drawing.Point(1113, 195);
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
            this.width.Location = new System.Drawing.Point(1113, 111);
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
            this.label2.Location = new System.Drawing.Point(1048, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1048, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1041, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "node dist";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1028, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "node count";
            // 
            // simulations
            // 
            this.simulations.Location = new System.Drawing.Point(1113, 83);
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
            this.label6.Location = new System.Drawing.Point(1017, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "simulations";
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(1112, 256);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(57, 22);
            this.n.TabIndex = 14;
            this.n.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1048, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "k";
            // 
            // p2
            // 
            this.p2.DecimalPlaces = 2;
            this.p2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.p2.Location = new System.Drawing.Point(1112, 289);
            this.p2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(57, 22);
            this.p2.TabIndex = 16;
            this.p2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1047, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "p2";
            // 
            // gossip1Box
            // 
            this.gossip1Box.AutoSize = true;
            this.gossip1Box.Checked = true;
            this.gossip1Box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gossip1Box.Location = new System.Drawing.Point(1031, 358);
            this.gossip1Box.Name = "gossip1Box";
            this.gossip1Box.Size = new System.Drawing.Size(115, 21);
            this.gossip1Box.TabIndex = 18;
            this.gossip1Box.Text = "Gossip1(p, k)";
            this.gossip1Box.UseVisualStyleBackColor = true;
            // 
            // gossip2Box
            // 
            this.gossip2Box.AutoSize = true;
            this.gossip2Box.Checked = true;
            this.gossip2Box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gossip2Box.Location = new System.Drawing.Point(1031, 385);
            this.gossip2Box.Name = "gossip2Box";
            this.gossip2Box.Size = new System.Drawing.Size(155, 21);
            this.gossip2Box.TabIndex = 19;
            this.gossip2Box.Text = "Gossip2(p, k, p2, n)";
            this.gossip2Box.UseVisualStyleBackColor = true;
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 559);
            this.Controls.Add(this.gossip2Box);
            this.Controls.Add(this.gossip1Box);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.n);
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
            this.Controls.Add(this.gossip1Button);
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
            ((System.ComponentModel.ISupportInitialize)(this.n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button gossip1Button;
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
        private System.Windows.Forms.NumericUpDown n;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown p2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox gossip1Box;
        private System.Windows.Forms.CheckBox gossip2Box;
    }
}