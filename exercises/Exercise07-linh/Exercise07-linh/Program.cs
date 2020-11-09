using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Exercise_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Oberholzer's Roulette table.");
            Console.WriteLine("To spin the wheel enter your bet: ");
            Console.ReadLine();

            int[] left = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
            int[] center = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] right = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
            int[] zero = new int[] { 0, 37 };

            int[] black = new int[] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            int[] red = new int[] { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };

            Random rndm = new Random();
            int rn = rndm.Next(0, 37);
            Console.WriteLine($"The WINNER of the Random Number bet is......{rn}!!!");

            if (rn >= 36)
            {
                Console.WriteLine($"randon# winner = {rn}");
            }
            else if (rn == 37)
            {
                Console.WriteLine("randon#winner 00");
            }







            if (rn % 2 == 0)
            {
                Console.WriteLine("The WINNER of the Evens/Odds bet is......EVENS!!!");
            }
            else if (rn % 2 != 0)
            {
                Console.WriteLine("The WINNER of the Evens/Odds bet is......ODDS!!!");
            }
            else if (rn == 0)
            {
                Console.WriteLine("You LOSE!!!");
            }
            else if (rn == 37)
            {
                Console.WriteLine("You LOSE!!!");
            }



            if (red.Contains(rn))
            {
                Console.WriteLine("The WINNER of the Reds/Blacks bet is......REDS!!!");
            }
            else if (black.Contains(rn))
            {
                Console.WriteLine("The WINNER of the Reds/Blacks bet is......BLACKS!!!");
            }
            else if (rn == 0)
            {
                Console.WriteLine("You LOSE!!!");
            }
            else if (rn == 37)
            {
                Console.WriteLine("You LOSE!!!");
            }




            if (rn <= 18)
            {
                Console.WriteLine("The WINNER of the Lows/Highs bet is......LOWS!!!");
            }
            else if (rn >= 19)
            {
                Console.WriteLine("The WINNER of the Lows/Highs bet is......HIGHS!!!");
            }
            else if (rn == 0)
            {
                Console.WriteLine("You LOSE!!!");
            }
            else if (rn == 37)
            {
                Console.WriteLine("You LOSE!!!");
            }




            if (rn > 0 || rn <= 12)
            {
                Console.WriteLine("The WINNER of the Dozens bet is......1-12!!!");
            }
            else if (rn > 12 || rn <= 24)
            {
                Console.WriteLine("The WINNER of the Dozens bet is......13-24!!!");
            }
            else if (rn > 24 || rn <= 36)
            {
                Console.WriteLine("The WINNER of the Dozens bet is......25-36!!!");
            }
            else if (rn == 0)
            {
                Console.WriteLine("You LOSE!!!");
            }
            else if (rn == 37)
            {
                Console.WriteLine("You LOSE!!!");
            }




            if (left.Contains(rn))
            {
                Console.WriteLine("The WINNER of the Columns bet is......FIRST COLUMN!!!");
                Console.WriteLine($"The WINNER of the Streets bet is......Street: {rn} {rn + 1} {rn + 2}!!!");
            }
            else if (center.Contains(rn))
            {
                Console.WriteLine("The WINNER of the Columns bet is......SECOND COLUMN!!!");
                Console.WriteLine($"The WINNER of the Streets bet is......Street: {rn - 1} {rn} {rn + 1}!!!");
            }
            else if (right.Contains(rn))
            {
                Console.WriteLine("The WINNER of the Columns bet is......THIRD COLUMN!!!");
                Console.WriteLine($"The WINNER of the Streets bet is......Street: {rn - 2} {rn - 1} {rn}!!!");
            }
            else if (rn == 0)
            {
                Console.WriteLine("You LOSE!!!");
            }
            else if (rn == 37)
            {
                Console.WriteLine("You LOSE!!!");
            }






            if (left.Contains(rn) && rn == 1)
            {
                Console.WriteLine("6 Number: 1, 2, 3, 4, 5, 6");
            }
            else if (center.Contains(rn) && rn == 2)
            {
                Console.WriteLine("6 Number: 1, 2, 3, 4, 5, 6");
            }
            else if (right.Contains(rn) && rn == 3)
            {
                Console.WriteLine("6 Number: 1, 2, 3, 4, 5, 6");
            }
            else if (left.Contains(rn) && rn == 34)
            {
                Console.WriteLine("6 Number: 31, 32, 33, 34, 35, 36");
            }
            else if (center.Contains(rn) && rn == 35)
            {
                Console.WriteLine("6 Number: 31, 32, 33, 34, 35, 36");
            }
            else if (right.Contains(rn) && rn == 36)
            {
                Console.WriteLine("6 Number: 31, 32, 33, 34, 35, 36");
            }
            else if (left.Contains(rn) && rn != 1 && rn != 34)
            {
                Console.WriteLine($"6 Number: {rn}, {rn + 1}, {rn + 2}, {rn + 3}, {rn + 4}, {rn + 5}");
            }
            else if (center.Contains(rn) && rn != 2 && rn != 35)
            {
                Console.WriteLine($"6 Number: {rn}, {rn + 1}, {rn + 2}, {rn + 3}, {rn + 4}, {rn + 5}");
            }
            else if (right.Contains(rn) && rn != 3 && rn != 36)
            {
                Console.WriteLine($"6 Number: {rn}, {rn + 1}, {rn + 2}, {rn + 3}, {rn + 4}, {rn + 5}");
            }
            else if (rn == 0)
            {
                Console.WriteLine("You LOSE!!!");
            }
            else if (rn == 37)
            {
                Console.WriteLine("You LOSE!!!");
            }






            if (left.Contains(rn) && rn != 1 && rn != 34)
            {
                Console.WriteLine($"Corner bet winner is {rn}, {rn + 1}, {rn + 3}, {rn + 4} or {rn}, {rn - 3}, {rn - 2}, {rn + 1}");
            }
            else if (center.Contains(rn) && rn != 2 && rn != 35)
            {
                Console.WriteLine($"Corner bet winner is {rn}, {rn + 1}, {rn + 3}, {rn + 4}or {rn}, {rn - 1}, {rn + 2}, {rn + 3} or {rn}, {rn - 1}, {rn - 4}, {rn - 3} or {rn}, {rn - 3}, {rn - 2}, {rn + 1}");
            }
            else if (right.Contains(rn) && rn != 3 && rn != 36)
            {
                Console.WriteLine($"Corner bet winner is {rn}, {rn - 1}, {rn + 2}, {rn + 3} or {rn}, {rn - 1}, {rn - 4}, {rn - 3}");
            }
            else if (left.Contains(rn) && rn == 1)
            {
                Console.WriteLine($"Corner bet winner is {rn}, {rn + 1}, {rn + 3}, {rn + 4}");
            }
            else if (left.Contains(rn) && rn == 34)
            {
                Console.WriteLine($"Corner bet winner is {rn}, {rn - 3}, {rn - 2}, {rn + 1}");
            }
            else if (center.Contains(rn) && rn == 2)
            {
                Console.WriteLine($"Corner bet winner is {rn}, {rn + 1}, {rn + 3}, {rn + 4} or {rn}, {rn - 1}, {rn + 2}, {rn + 3} ");
            }
            else if (rn == 0)
            {
                Console.WriteLine("You LOSE!!!");
            }
            else if (rn == 37)
            {
                Console.WriteLine("You LOSE!!!");
            }




            if (left.Contains(rn) && rn == 1)
            {
                Console.WriteLine("The Split bet is: 1/2 & 1/4");
            }
            else if (left.Contains(rn) && rn == 34)
            {
                Console.WriteLine("The Split bet is: 34/35 & 34/31");
            }
            else if (left.Contains(rn) && rn != 1 && rn != 34)
            {
                Console.WriteLine($"Split bet is: {rn}/{rn - 3} & {rn}/{rn + 1} & {rn}/{rn + 3}");
            }
            if (center.Contains(rn) && rn == 2)
            {
                Console.WriteLine("The Split bet is: 2/1 & 2/3 & 2/5");
            }
            else if (center.Contains(rn) && rn == 35)
            {
                Console.WriteLine("The Split bet is: 35/34 & 35/36 & 35/32");
            }
            else if (center.Contains(rn) && rn != 2 && rn != 35)
            {
                Console.WriteLine($"Split bet is: {rn}/{rn - 3} & {rn}/{rn + 1} & {rn}/{rn - 1} & {rn}/{rn + 3}");
            }
            if (right.Contains(rn) && rn == 3)
            {
                Console.WriteLine("Split bet is: 3/2 & 3/6");
            }
            else if (right.Contains(rn) && rn == 36)
            {
                Console.WriteLine("Split bet is: 36/35 & 36/33");
            }
            else if (right.Contains(rn) && rn != 3 && rn != 36)
            {
                Console.WriteLine($"Split bet is: {rn}/{rn - 3} & {rn}/{rn - 1} & {rn}/{rn + 3}");
            }
            else if (rn == 0)
            {
                Console.WriteLine("You LOSE!!!");
            }
            else if (rn == 37)
            {
                Console.WriteLine("You LOSE!!!");
            }


        }

    }

}