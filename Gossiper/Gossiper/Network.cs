﻿using System;
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

        public int time = 0;

        public bool Step()
        {
            ++time;
            messageCount += messages.Count;
            List<NetworkMessage> oldMessages = new List<NetworkMessage>(messages);
            messages.Clear();
            foreach (NetworkMessage msg in oldMessages)
            {
                msg.target.OnMessage(msg.origin, msg.message, this);
            }

            routingAlgorithm.OnTimeStep(this);

            if (messages.Count == 0)
            {
                return false;
            }

            return true;
        }

        public RoutingAlgorithm routingAlgorithm = new DumbFloodFill();

        public List<Node> nodes = new List<Node>();

        public int totalRecieved
        {
            get
            {
                return nodes.Count(o => o.messagesReceived > 0);
            }
        }

        public float receivedRatio
        {
            get
            {
                return (float)totalRecieved / nodes.Count;
            }
        }

        public float avgDegree
        {
            get
            {
                return (float)nodes.Average(o => o.neighbors.Count);
            }
        }

        public int maxMessageCount
        {
            get
            {
                return nodes.Sum(o => o.neighbors.Count);
            }
        }

        public int messageCount = 0;

        public void Print()
        {
            System.Console.WriteLine("Network stats:");
            System.Console.WriteLine(nodes.Count + " nodes");
            System.Console.WriteLine("avg degree: " + avgDegree);
            System.Console.WriteLine(totalRecieved + " nodes got the message (" + receivedRatio + ")");
        }

        public void CreateNetwork(int width, int height, int nodeCoverage, int nodeCount)
        {
            time = 0;
            messageCount = 0;
            nodes.Clear();
            messages.Clear();

            Random random = new Random();

            while (nodes.Count < nodeCount / 2)
            {
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

                HashSet<Node> reachable = new HashSet<Node>();
                Stack<Node> toCheck = new Stack<Node>();
                toCheck.Push(nodes[0]);

                while (toCheck.Count > 0)
                {
                    Node current = toCheck.Pop();
                    if (!reachable.Contains(current))
                    {
                        reachable.Add(current);
                        foreach (Node n in current.neighbors)
                        {
                            toCheck.Push(n);
                        }
                    }
                }

                nodes.RemoveAll(o => !reachable.Contains(o));
            }
        }
    }
}
