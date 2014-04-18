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
#if false
            int k = 4;
            Network n = new Network();

            for (int i = 0; i < 100; ++i)
            {
                float p = (float)i / 100;
                n.routingAlgorithm = new Gossip1(p, k);
                System.Console.WriteLine("p = " + p);
                Test(n, 7500, 3000, 250, 1000, 10);
            }
#else
            new GraphForm().ShowDialog();
#endif
        }

        public static float Test(Network n, int width, int height, int distance, int nodeCount, int runs)
        {
            float ratio = 0;

            for (int i = 0; i < runs; ++i)
            {
                n.CreateNetwork(width, height, distance, nodeCount);
                n.nodes[0].StartMessage(n);
                while (n.Step()) ;
                ratio += n.receivedRatio;
            }

            ratio = ratio / runs;
            return ratio;
        }
    }
}
