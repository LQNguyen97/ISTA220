using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz05_linh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Quiz 05");
            string test = "I think, therefore I am";
            Console.WriteLine($"The test string is [{test}].");
            string[] TA = test.Split(' ');
            int L = TA.Length;
            Console.WriteLine($"The length of string array is {L}");

            for (int i = L - 1; i >= 0; i--)
            {
                Console.WriteLine($"{i} {TA[i]}");
            }
        }
    }
}
