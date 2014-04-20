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
                float ratio, msgRatio;
                Test(n, 7500, 3000, 250, 1000, 5, out ratio, out msgRatio);
                System.Console.WriteLine("p = " + p + ", div = " + (ratio - msgRatio));
            }
#else
            new GraphForm().ShowDialog();
#endif
        }

        public static void Test(Network n, int width, int height,
            int distance, int nodeCount, int runs, out float ratio, out float msgRatio)
        {
            ratio = 0;
            msgRatio = 0;

            for (int i = 0; i < runs; ++i)
            {
                n.CreateNetwork(width, height, distance, nodeCount);
                n.nodes[0].StartMessage(n);
                while (n.Step()) ;
                ratio += n.receivedRatio;
                msgRatio += n.messageCount;
            }

            ratio = ratio / runs;
            msgRatio = msgRatio / (runs * n.maxMessageCount);
        }
    }
}
