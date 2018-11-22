using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class StackRepository
    {
        //private Node _node;

        //public StackRepository()
        //{
        //    _node = new Node();
        //}

        public Node Push(Node node, int data)
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

        public Node Pop(Node node)
        {
            if (node == null)
            {
                Console.WriteLine("No data to delete!");
                //return node;
            }
            else
            {
                Node temp = node;
                temp = temp.Next;
                node = temp;

            }

            return node;
        }

        public void Print(Node node)
        {
            while (node != null)
            {
                Console.Write("-->" + node.Data);
                node = node.Next;
            }
        }

    }

}
