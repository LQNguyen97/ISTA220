using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPart 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius: ");
            string strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);
            double circumference = 2 * Math.PI * intradius;
            Console.WriteLine($"The circumference is {circumference}");
            double area = Math.PI * (Math.Pow(intradius,2));
            Console.WriteLine($"The area is {area}");

            Console.WriteLine("\nPart 2, volume of a hemisphere.");
            Console.Write("Enter an  integer for the radius: ");
            string vrad = Console.ReadLine();
            int vradius = int.Parse(vrad);
            double volume = ((4 / 3) * Math.PI * (Math.Pow(vradius, 3)) )/ 2;
            Console.WriteLine($"The volume is {volume}");

            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
            Console.WriteLine("Enter a number for side a: ");
            string strsidea = Console.ReadLine();
            int intsidea = int.Parse(strsidea);
            Console.WriteLine("Enter a number for side b: ");
            string strsideb = Console.ReadLine();
            int intsideb = int.Parse(strsideb);
            Console.WriteLine("Enter a number for side c: ");
            string strsidec = Console.ReadLine();
            int intsidec = int.Parse(strsidec);
            int p = (intsidea + intsideb + intsidec) / 2;
            double areaheron = Math.Sqrt(p * (p - intsidea) * (p - intsideb) * (p - intsidec));
            Console.WriteLine($"The area is {areaheron}");

            Console.WriteLine("\nPart 4, solving a quadratic equation.");
            Console.WriteLine("Enter a non-negative number for coefficient a: ");
            string inta = Console.ReadLine();
            int coeffa = int.Parse(inta);
            Console.WriteLine("Enter a non-negative number for coefficient b: ");
            string intb = Console.ReadLine();
            int coeffb = int.Parse(intb);
            Console.WriteLine("Enter a non-negative number for c: ");
            string intc = Console.ReadLine();
            int c = int.Parse(intc);
            double denominator = 2 * coeffa;
            double positive_num = (-coeffb + Math.Sqrt((Math.Pow(coeffb, 2)) - 4 * coeffa * c)) / denominator;
            double negative_num = (-coeffb - Math.Sqrt((Math.Pow(coeffb, 2)) - 4 * coeffa * c)) / denominator;
            Console.WriteLine($"The positive result is {positive_num}");
            Console.WriteLine($"The negative result is {negative_num}");
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
