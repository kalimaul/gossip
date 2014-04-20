using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gossiper
{
    interface RoutingAlgorithm
    {
        void HandleNode(Node current, Node origin, Message message, Network network);
    }

    class DumbFloodFill : RoutingAlgorithm
    {
        public void HandleNode(Node current, Node origin, Message message, Network network)
        {
            foreach (Node neighbor in current.neighbors)
            {
                network.Enqueue(message, current, neighbor);
            }
        }
    }

    class Gossip1 : RoutingAlgorithm
    {
        public Gossip1(float probability, int minHops)
        {
            p = probability;
            k = minHops;
        }

        Random random = new Random();
        float p = 1;
        int k = 0;

        public void HandleNode(Node current, Node origin, Message message, Network network)
        {
            if (message.hops >= k && random.NextDouble() > p)
            {
                return;
            }

            foreach (Node neighbor in current.neighbors)
            {
                network.Enqueue(message, current, neighbor);
            }
        }
    }
}
