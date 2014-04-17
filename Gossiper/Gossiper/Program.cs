using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gossiper
{
    class Program
    {
        static void Main(string[] args)
        {
            Network n = new Network();
            n.CreateNetwork(7500, 3000, 250, 1000);

            n.routingAlgorithm = new Gossip1(0.85f, 4);

            n.nodes[0].StartMessage(n);

            while (n.Step())
            {
            }

            n.Print();
        }
    }
}
