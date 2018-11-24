using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class QueueRepository
    {
        Node headNode, tailNode;
        
        public Node Enqueue(Node node, int data)
        {
            if (node == null)
            {
                Node newNode = new Node();
                newNode.Data = data;
                newNode.Next = null;
                return newNode;
            }
            else
            {
                Node headNode = node;
                Node newNode = new Node();
                newNode.Data = data;
                newNode.Next = headNode;
                headNode = newNode;
                return headNode;
            }
        }

        public Node Dequeue(Node node)
        {
            while (node.Next != null)
            {
                node = node.Next;
            }

            Node tail = node;
            node = null;
            return tail;

        }

        public void Print(Node node)
        {
            while (node != null)
            {
                Console.WriteLine("-->" + node.Data);
                node = node.Next;
            }
        }


        
    }
}
