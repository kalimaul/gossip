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
        void OnTimeout(Network network);
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


        public void OnTimeout(Network network)
        {
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

        public void OnTimeout(Network network)
        {
        }
    }

    class Gossip2 : RoutingAlgorithm
    {
        public Gossip2(float p1, int k, float p2, int n)
        {
            this.p1 = p1;
            this.k = k;
            this.p2 = p2;
            this.n = n;
        }

        Random random = new Random();
        float p1, p2;
        int n;
        int k;

        public void HandleNode(Node current, Node origin, Message message, Network network)
        {
            float p = p1;
            if (current.neighbors.Count < n)
            {
                p = p2;
            }

            if (message.hops >= k && random.NextDouble() > p)
            {
                return;
            }

            foreach (Node neighbor in current.neighbors)
            {
                network.Enqueue(message, current, neighbor);
            }
        }

        public void OnTimeout(Network network)
        {
        }
    }

    class Gossip3 : RoutingAlgorithm
    {
        public Gossip3(float p, int k, int m)
        {
            this.p = p;
            this.k = k;
            this.m = m;
        }

        Random random = new Random();
        float p = 1;
        int k = 0;
        int m;

        public void HandleNode(Node current, Node origin, Message message, Network network)
        {
            if (message.hops >= k && random.NextDouble() > p)
            {
                return;
            }

            current.broadcasted = true;

            foreach (Node neighbor in current.neighbors)
            {
                network.Enqueue(message, current, neighbor);
            }
        }

        public void OnTimeout(Network network)
        {
            foreach (Node node in network.nodes)
            {
                if (node.broadcasted == false && node.messagesReceived <= m && node.messagesReceived > 0)
                {
                    node.broadcasted = true;
                    foreach (Node neighbor in node.neighbors)
                    {
                        network.Enqueue(node.message, node, neighbor);
                    }
                }
            }
        }
    }
}
