using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            do
            {
                try
                {

                    Console.WriteLine("\nPart 1, circumference and area of a circle.");
                    Console.Write("Enter an integer for the radius: ");
                    string strradius = Console.ReadLine();
                    int intradius = int.Parse(strradius);
                    if (intradius < 0)
                        throw new ArgumentOutOfRangeException();
                    else if (intradius == 0)
                        throw new DivideByZeroException();
                    double circumference = 2 * Math.PI * intradius;
                    Console.WriteLine($"The circumference is {circumference}");
                    double area = Math.PI * (Math.Pow(intradius, 2));
                    Console.WriteLine($"The area is {area}");
                    again = false;
                }
                catch (FormatException cx)
                {
                    Console.WriteLine(cx.Message);
                }
                catch (ArgumentOutOfRangeException icx)
                {
                    Console.WriteLine(icx.Message);
                }
                catch (DivideByZeroException ixc)
                {
                    Console.WriteLine(ixc.Message);
                }
                finally
                {
                    Console.WriteLine("Your number is okay");
                }
            }
            while (again == true);

            bool retry = true;
            do
            {
                try
                {
                    Console.WriteLine("\nPart 2, volume of a hemisphere.");
                    Console.Write("Enter an  integer for the radius: ");
                    string vrad = Console.ReadLine();
                    int vradius = int.Parse(vrad);
                    if (vradius < 0)
                        throw new ArgumentOutOfRangeException();
                    else if (vradius == 0)
                        throw new DivideByZeroException();
                    double volume = ((4 / 3) * Math.PI * (Math.Pow(vradius, 3))) / 2;
                    Console.WriteLine($"The volume is {volume}");
                    retry = false;
                }
                catch (FormatException vx)
                {
                    Console.WriteLine(vx.Message);
                }
                catch (ArgumentOutOfRangeException ivx)
                {
                    Console.WriteLine(ivx.Message);
                }
                catch (DivideByZeroException ivc)
                {
                    Console.WriteLine(ivc.Message);
                }
                finally
                {
                    Console.WriteLine("Your number is okay");
                }
            }
            while (retry == true);

            bool repeat = true;
            do
            {
                try
                {
                    Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
            Console.WriteLine("Enter a number for side a: ");
            string strsidea = Console.ReadLine();
            int intsidea = int.Parse(strsidea);
                    if (intsidea < 0)
                        throw new ArgumentOutOfRangeException();
                    else if (intsidea == 0)
                        throw new DivideByZeroException();
                    Console.WriteLine("Enter a number for side b: ");
            string strsideb = Console.ReadLine();
            int intsideb = int.Parse(strsideb);
                    if (intsideb < 0)
                        throw new ArgumentOutOfRangeException();
                    else if (intsideb == 0)
                        throw new DivideByZeroException();
                    Console.WriteLine("Enter a number for side c: ");
            string strsidec = Console.ReadLine();
            int intsidec = int.Parse(strsidec);
                    if (intsidec < 0)
                        throw new ArgumentOutOfRangeException();
                    else if (intsidec == 0)
                        throw new DivideByZeroException();
                    int p = (intsidea + intsideb + intsidec) / 2;
            double areaheron = Math.Sqrt(p * (p - intsidea) * (p - intsideb) * (p - intsidec));
            Console.WriteLine($"The area is {areaheron}");
                    repeat = false;
                }
                catch (FormatException sx)
                {
                    Console.WriteLine(sx.Message);
                }
                catch (ArgumentOutOfRangeException isx)
                {
                    Console.WriteLine(isx.Message);
                }
                catch (DivideByZeroException isc)
                {
                    Console.WriteLine(isc.Message);
                }
                finally
                {
                    Console.WriteLine("Your number is okay");
                }
            }
            while (repeat == true);

            bool lastly = true;
            do
            {
                try
                {
                    Console.WriteLine("\nPart 4, solving a quadratic equation.");
            Console.WriteLine("Enter a non-negative number for coefficient a: ");
            string inta = Console.ReadLine();
            int coeffa = int.Parse(inta);
                    if (coeffa < 0)
                        throw new ArgumentOutOfRangeException();
                    else if (coeffa == 0)
                        throw new DivideByZeroException();
                    Console.WriteLine("Enter a non-negative number for coefficient b: ");
            string intb = Console.ReadLine();
            int coeffb = int.Parse(intb);
                    if (coeffb < 0)
                        throw new ArgumentOutOfRangeException();
                    else if (coeffb == 0)
                        throw new DivideByZeroException();
                    Console.WriteLine("Enter a non-negative number for c: ");
            string intc = Console.ReadLine();
            int c = int.Parse(intc);
                    if (c < 0)
                        throw new ArgumentOutOfRangeException();
                    else if (c == 0)
                        throw new DivideByZeroException();
                    double denominator = 2 * coeffa;
            double positive_num = (-coeffb + Math.Sqrt((Math.Pow(coeffb, 2)) - 4 * coeffa * c)) / denominator;
            double negative_num = (-coeffb - Math.Sqrt((Math.Pow(coeffb, 2)) - 4 * coeffa * c)) / denominator;
            Console.WriteLine($"The positive result is {positive_num}");
            Console.WriteLine($"The negative result is {negative_num}");
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
                    lastly = false;
                }
                catch (FormatException qx)
                {
                    Console.WriteLine(qx.Message);
                }
                catch (ArgumentOutOfRangeException iqx)
                {
                    Console.WriteLine(iqx.Message);
                }
                catch (DivideByZeroException iqc)
                {
                    Console.WriteLine(iqc.Message);
                }
                finally
                {
                    Console.WriteLine("Your number is okay");
                }
            }
            while (lastly == true);
        }
            }
        }
    
