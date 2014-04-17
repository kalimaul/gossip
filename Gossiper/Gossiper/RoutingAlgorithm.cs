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
}
