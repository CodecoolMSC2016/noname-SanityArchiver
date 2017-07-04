using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopDetector3000
{

    class Node
    {
        private int Data { get; set; }
        private Node next { get; set; }

        public Node(int data, Node next)
        {
            Data = data;
            this.next = next;
        }

        public Node(int data)
        {
            Data = data;
            next = null;
        }

        public List<Node> ListNodes()
        {

            List<Node> nodes = new List<Node>();
            Node n = this;

            while (n != null)
            {
                nodes.Add(n);
                n = n.next;
            }

            return nodes;
        }

        public Boolean hasLoop()
        {
            Node slow = this;
            Node fast = next;

            while ( slow != null || fast.next != null )
            {
                if (slow == fast)
                {
                    return true;
                }

                slow = slow.next;
                fast = fast.next.next;
            }

            return false;
        }

        public override string ToString()
        {
            return "Node " + Data;
        }

    }
}
