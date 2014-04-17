using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gossiper
{
    class Node
    {
        public void OnMessage(Node origin, Message message, Network network)
        {
            ++messagesReceived;
            if (messagesReceived == 1)
            {
                network.routingAlgorithm.HandleNode(this, origin, message, network);
            }
        }

        public void StartMessage(Network network)
        {
            Message m = new Message();
            network.routingAlgorithm.HandleNode(this, null, m, network);
        }

        public int messagesReceived = 0;
        public List<Node> neighbors = new List<Node>();
        public int xPos;
        public int yPos;
    }
}
