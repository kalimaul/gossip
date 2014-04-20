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
            Network n = new Network();

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            Refresh();

            for (int i = 0; i <= 100; i += 1)
            {
                float p = (float)i / 100;
                SetupRoutingAlgorithm(n, p);
                float ratio, msgRatio;
                Program.Test(n, 7500, 3000, 250, 1000, 100, out ratio, out msgRatio);
                chart1.Series[0].Points.AddXY(p, ratio);
                chart1.Series[1].Points.AddXY(p, msgRatio);
                Refresh();
            }
        }

        void SetupRoutingAlgorithm(Network n, float p)
        {
            int k = (int) kValue.Value;
            n.routingAlgorithm = new Gossip1(p, k);
        }
    }
}
