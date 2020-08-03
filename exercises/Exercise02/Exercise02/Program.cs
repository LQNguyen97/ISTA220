using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace progex02
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPart 1, sum 10 numbers.");
            int sum = SumTenInts(0, 0);
            char letterGrade = 'X';
            Console.WriteLine($"The sum of ten integers is {sum}");

            Console.WriteLine("\nPart 2, average 10 numbers.");
            double avg = AvgTenInts(0, 0);
            letterGrade = ConvertNumericToLetterGrade(avg);
            Console.WriteLine($"The average of ten integers is {avg} and the letter grade is {letterGrade}");

            Console.WriteLine("\nPart 3, average user predetermined number of scores.");
            Console.Write("How many scores do you wish to enter?");
            string noScores = Console.ReadLine();
            int numScores = int.Parse(noScores);
            double avg1 = AvgUnkInts(0, 0, numScores);
            letterGrade = ConvertNumericToLetterGrade(avg1);
            Console.WriteLine($"The average of {numScores} integers is {avg1} and the letter grade is {letterGrade}");

            Console.WriteLine("\nPart4, average non-predetermined number of scores.");
            double avg2 = AvgAnyInts(0, 0);
            letterGrade = ConvertNumericToLetterGrade(avg2);
            Console.WriteLine($"The average of ten integers is {avg2} and the letter grade is {letterGrade}");
        }
        
        private static char ConvertNumericToLetterGrade(double grade)
        {
            char LetterGrade = 'X';
            if (grade >= 90)
            {
                LetterGrade = 'A';
                return LetterGrade;
            }

            else if (grade >= 80)
            {
                LetterGrade = 'B';
                return LetterGrade;
            }

            else if (grade >= 70)
            {
                LetterGrade = 'C';
                return LetterGrade;
            }

            else if (grade >= 65)
            {
                LetterGrade = 'D';
                return LetterGrade;
            }

            else if (grade <= 64)
            {
                LetterGrade = 'F';
                return LetterGrade;
            }
            else
                return LetterGrade;
        }

        private static double AvgAnyInts(double sum, double count)
        {
            Console.WriteLine("Please enter a score: ");
            string input = Console.ReadLine();
            int value = int.Parse(input);
            sum += int.Parse(input);
            count++;
            if (value == -1)
                return sum/count;
            else
                return AvgAnyInts(sum, count);          
        }

        private static double AvgUnkInts(double sum, double count, double numScores)
        {
            Console.WriteLine("Please enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count++;
            if (count < numScores)
                return AvgUnkInts(sum, count, numScores);
            else return(sum / (numScores));
        }

        private static double AvgTenInts(double sum, double count)
        {
            Console.WriteLine("Please enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count++;
            if (count < 10)
                return AvgTenInts(sum, count);
            else return sum / count;

        }

        private static int SumTenInts(int sum, int count)
        {
            Console.Write("Enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count++;
            if (count < 10)
                return SumTenInts(sum, count);
            else
                return sum;
        }
    }
}