using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A programe to check is a string is anagram to another string. 
namespace StringAnagramCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string...\n");
            var ipStr1 = Console.ReadLine();

            Console.WriteLine("Input another string...\n");
            var ipStr2 = Console.ReadLine();

            if (IsAnagram(ipStr1, ipStr2))
            {
                Console.WriteLine("\n\n#Anagram");
            }
            else
            {
                Console.WriteLine("\n\n#Not Anagram");
            }

            Console.ReadKey();
        }

        static bool IsAnagram(string str1, string str2)
        {
            List<char> CharList1 = new List<char>();
            bool result = false;

            if (str1.Length != str2.Length)
            {
                result = false;
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    CharList1.Add(str1[i]);
                }

                for (int i = 0; i < str1.Length; i++)
                {
                    if (CharList1.Contains(str2[i]) == false)
                    {
                        result = false;
                        break;
                    }
                    else
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
    }
}
