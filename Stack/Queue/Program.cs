using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node();

            QueueRepository queueRepository = new QueueRepository();
            Node headNode = null;
            Node tailNode = null;
            Console.WriteLine("-----Number of list items:-----");
            Console.WriteLine("--------------");
            int listLength = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < listLength; i++)
            {
                int data = Convert.ToInt32(Console.ReadLine());
                headNode = queueRepository.Enqueue(headNode, data);
            }

            queueRepository.Print(headNode);

            tailNode = queueRepository.Dequeue(headNode);
            Console.WriteLine("--------------");
            Console.WriteLine("------After 1st dequeue--------");
            queueRepository.Print(headNode);

            Console.ReadKey();
        }
    }
}
