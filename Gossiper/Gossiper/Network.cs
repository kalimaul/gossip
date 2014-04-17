using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gossiper
{
    class Network
    {
        struct NetworkMessage
        {
            public Message message;
            public Node target;
            public Node origin;
        }

        List<NetworkMessage> messages = new List<NetworkMessage>();

        public void Enqueue(Message m, Node origin, Node target)
        {
            NetworkMessage msg = new NetworkMessage();
            msg.message = m;
            msg.target = target;
            msg.origin = origin;
            ++msg.message.hops;
            messages.Add(msg);
        }

        public bool Step()
        {
            List<NetworkMessage> oldMessages = new List<NetworkMessage>(messages);
            messages.Clear();
            foreach (NetworkMessage msg in oldMessages)
            {
                msg.target.OnMessage(msg.origin, msg.message, this);
            }

            if (messages.Count == 0)
            {
                return false;
            }

            return true;
        }

        public RoutingAlgorithm routingAlgorithm = new DumbFloodFill();

        public List<Node> nodes = new List<Node>();

        public void Print()
        {
            int totalRecieved = nodes.Count(o => o.messagesReceived > 0);
            int isolated = nodes.Count(o => o.neighbors.Count == 0);
            System.Console.WriteLine("Network stats:");
            System.Console.WriteLine(nodes.Count + " nodes, " + isolated + " isolated");
            System.Console.WriteLine(totalRecieved + " nodes got the message");
        }

        public void CreateNetwork(int width, int height, int nodeCoverage, int nodeCount)
        {
            nodes.Clear();
            messages.Clear();

            Random random = new Random();

            for (int i = 0; i < nodeCount; ++i)
            {
                int x = random.Next(width);
                int y = random.Next(height);
                Node n = new Node();
                n.xPos = x;
                n.yPos = y;
                nodes.Add(n);
            }

            for (int i = 0; i < nodes.Count; ++i)
            {
                for (int j = i + 1; j < nodes.Count; ++j)
                {
                    int xdiff = nodes[i].xPos - nodes[j].xPos;
                    int ydiff = nodes[i].yPos - nodes[j].yPos;
                    int dstSqr = xdiff * xdiff + ydiff * ydiff;
                    if (dstSqr <= nodeCoverage * nodeCoverage)
                    {
                        nodes[i].neighbors.Add(nodes[j]);
                        nodes[j].neighbors.Add(nodes[i]);
                    }
                }
            }

#if false
            for (int i = 0; i < nodes.Count - 1; ++i)
            {
                if (nodes[i].neighbors.Count == 0)
                {
                    nodes[i].neighbors.Add(nodes[nodes.Count - 1]);
                    nodes[nodes.Count - 1].neighbors.Add(nodes[i]);
                }

                if (nodes[i].neighbors.Contains(nodes[i]))
                {
                    System.Console.WriteLine("warning: self is neighbor");
                }
            }
#endif
        }
    }
}
