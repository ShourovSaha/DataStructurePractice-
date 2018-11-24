//A program to match braket pairs. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketMaching
{
    class Program
    {
        readonly static Dictionary<char, char> bracketPairs = new Dictionary<char, char>()
            {
                {')', '('},
                {'}', '{'},
                {']', '['}
            };

        static void Main(string[] args)
        {
            Console.WriteLine("Input a somethig like [(a+b)+(c+d)]\n");
            var ipStr = Console.ReadLine();

            Stack<char> myStack = new Stack<char>();

            for (int i = 0; i < ipStr.Length; i++)
            {
                if (ipStr[i] == '(' || ipStr[i] == '{' || ipStr[i] == '[' || ipStr[i] == ')' || ipStr[i] == '}' || ipStr[i] == ']')
                {
                    if (myStack.Count != 0 && IsSimilarAtPeek(ipStr[i], myStack))
                    {
                        myStack.Pop();
                    }
                    else
                    {
                        myStack.Push(ipStr[i]);
                    }
                }
            }

            if (myStack.Count == 0)
            {
                Console.WriteLine("All the bracket pairs are matched.");
            }
            else
            {
                Console.WriteLine("Unmatched bracket pair exits!");
            }

            Console.ReadKey();
        }

        //chcking is peek value of stack is similar to key value pair of globle dictionary variable. 
        public static bool IsSimilarAtPeek(char ch, Stack<char> stack)
        {
            bool result;
            result = bracketPairs.Contains(new KeyValuePair<char, char>(ch, stack.Peek()));
            return result;
        }
    }
}

