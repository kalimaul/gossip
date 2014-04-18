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
            int k = 3;
            Network n = new Network();

            chart1.Series[0].Points.Clear();

            for (int i = 0; i < 100; ++i)
            {
                float p = (float)i / 100;
                n.routingAlgorithm = new Gossip1(p, k);
                float ratio = Program.Test(n, 7500, 3000, 250, 1000, 50);
                chart1.Series[0].Points.AddXY(p, ratio);
                Refresh();
            }
        }
    }
}
