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

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

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
                    SetupRoutingAlgorithm(n, p);
                    float ratio, msgRatio;
                    Program.Test(n, w, h, nodeDistance, nodes, simCount, out ratio, out msgRatio);
                    chart1.Series[0].Points.AddXY(p, ratio);
                    chart1.Series[1].Points.AddXY(p, msgRatio);
                }

                button1.Enabled = true;
            });
            bw.RunWorkerAsync();
        }

        void SetupRoutingAlgorithm(Network n, float p)
        {
            int k = (int)kValue.Value;
            n.routingAlgorithm = new Gossip1(p, k);
        }
    }
}
