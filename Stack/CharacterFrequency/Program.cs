using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A program to count frequency of chracters with in a string.
namespace CharacterFrequency
{
    class Program
    {
        readonly static Dictionary<char, int> Dict = new Dictionary<char, int>();

        static void Main(string[] args)
        {
            Console.WriteLine("Input a somethig like a string...\n");
            var ipStr = Console.ReadLine();

            for (int i = 0; i < ipStr.Length; i++)
            {
                IsContains(ipStr[i]);
            }
            Console.WriteLine("--------------\n");
            foreach (var data in Dict)
            {
                Console.WriteLine(data.Key + "--frequency :" + data.Value);
            }

            Console.WriteLine("\n------Max occuring Number--------\n");
            foreach (var data in MaxOccuringNumber())
            {
                Console.WriteLine(data.Key + "--frequency :" + data.Value);
            }

            Console.ReadKey();
        }


        public static IEnumerable<KeyValuePair<char, int>> MaxOccuringNumber()
        {
            int temp = 0;
            foreach (var data in Dict)
            {
                temp = data.Value >= temp ? data.Value : temp; 
            }
            var keyValuePair = Dict.Where(x => x.Value == temp);
            return keyValuePair;
        }

        public static void IsContains(char ch)
        {
            if (Dict.ContainsKey(ch))
            {
                Dict[ch] = Dict[ch] + 1;
            }
            else
            {
                Dict[ch] = 1;
            }
        }
    }
}
