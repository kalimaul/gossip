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
            n.CreateNetwork(1000, 1000, 250, 50);
            n.nodes[0].StartMessage(n);

            while (n.Step())
            {
            }

            n.Print();
        }
    }
}
