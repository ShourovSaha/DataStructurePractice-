using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node();
            node = null;
            //node.Data = 10;
            //node.Next = null;

            StackRepository stackRepository = new StackRepository();
            Node headNode = null;

            int listLength = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < listLength; i++)
            {
                int data = Convert.ToInt32(Console.ReadLine());
                headNode = stackRepository.Push(headNode, data);
            }

            stackRepository.Print(headNode);
            Console.WriteLine();
            Console.WriteLine("--------------");
            Console.WriteLine("------After 1 Pop--------");
            headNode = stackRepository.Pop(headNode);
            stackRepository.Print(headNode);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
