using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gossiper
{
    public partial class GraphForm : Form
    {
        public GraphForm()
        {
            InitializeComponent();
        }

        int gossipMode = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            RunSimulation(gossip1Box.Checked, gossip2Box.Checked);
        }

        void RunSimulation(bool runGossip1, bool runGossip2)
        {
            gossip1Button.Enabled = false;

            chart1.Series.Clear();
            int g1Line = -1;
            int g2Line = -1;
            int usage1Line = -1;
            int usage2Line = -1;

            if (runGossip1)
            {
                chart1.Series.Add("Gossip1 reach");
                g1Line = chart1.Series.Count - 1;
                chart1.Series[g1Line].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                chart1.Series.Add("Gossip1 usage");
                usage1Line = chart1.Series.Count - 1;
                chart1.Series[usage1Line].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }

            if (runGossip2)
            {
                chart1.Series.Add("Gossip2 reach");
                g2Line = chart1.Series.Count - 1;
                chart1.Series[g2Line].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                chart1.Series.Add("Gossip2 usage");
                usage2Line = chart1.Series.Count - 1;
                chart1.Series[usage2Line].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }

            int simCount = (int)simulations.Value;

            BackgroundWorker bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.DoWork += new DoWorkEventHandler(
            delegate(object o, DoWorkEventArgs args)
            {
                Network n = new Network();

                int w = (int)width.Value;
                int h = (int)height.Value;
                int nodes = (int)nodeCount.Value;
                int nodeDistance = (int)nodeDist.Value;

                for (int i = 0; i <= 100; i += 2)
                {
                    float p = (float)i / 100;
                    float ratio, msgRatio;

                    if (runGossip1)
                    {
                        gossipMode = 0;
                        SetupRoutingAlgorithm(n, p);
                        Program.Test(n, w, h, nodeDistance, nodes, simCount, out ratio, out msgRatio);
                        chart1.Series[g1Line].Points.AddXY(p, ratio);
                        chart1.Series[usage1Line].Points.AddXY(p, msgRatio);
                    }

                    if (runGossip2)
                    {
                        gossipMode = 1;
                        SetupRoutingAlgorithm(n, p);
                        Program.Test(n, w, h, nodeDistance, nodes, simCount, out ratio, out msgRatio);
                        chart1.Series[g2Line].Points.AddXY(p, ratio);
                        chart1.Series[usage2Line].Points.AddXY(p, msgRatio);
                    }
                }

                gossip1Button.Enabled = true;
            });
            bw.RunWorkerAsync();
        }

        void SetupRoutingAlgorithm(Network network, float p)
        {
            int k = (int)kValue.Value;
            int n = (int)this.n.Value;
            float p2 = (float)this.p2.Value;

            if (gossipMode == 0)
            {
                network.routingAlgorithm = new Gossip1(p, k);
            }
            else if (gossipMode == 1)
            {
                network.routingAlgorithm = new Gossip2(p, k, p2, n);
            }
        }
    }
}
