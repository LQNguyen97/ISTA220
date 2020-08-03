using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz03
{
    class Program
    {

        static void Main(string[] args)
        {          
            string strnumber = "";
            int count = 0;
            int number = 0;
            
            do
            {
                try
                {
                    count = 0;
                    Console.Write("To calculate the reciprocal of an integer, enter a positive integer: ");
                    strnumber = Console.ReadLine();
                    number = int.Parse(strnumber);
                    if (number < 0)
                        throw new InvalidOperationException("Your number must be a positive number");

                    if (number == 0)
                        throw new DivideByZeroException("Attempted to divided by zero");
                    Console.WriteLine($"The reciprocal is {1.0 / number}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input string was not in a correct format.");
                    ++count;
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                    ++count;
                }
                catch (DivideByZeroException z)
                {
                    Console.WriteLine(z.Message);
                    ++count;
                }
            }
            while (count > 0);
        }
    }
}

        
