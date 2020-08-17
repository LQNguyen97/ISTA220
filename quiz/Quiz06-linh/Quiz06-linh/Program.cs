using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz06_linh
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cards = { 0, 1 , 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
            21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43,
            44, 45, 46, 47, 48, 49, 50, 51};

            Console.Write("This is Cards - console." + "\n" +
                          "\n                       initialize new deck=======================" + "\n" +
                          "\ntwo of Clubs, three of Clubs, four of Clubs, five of Clubs, six of Clubs," +
                          "\nseven of Clubs, eight of Clubs, nine of Clubs, ten of Clubs, Jack of Clubs," +
                          "\nQueen of Clubs, King of Clubs, Ace of Clubs, two of Diamonds, three of Diamonds," +
                          "\nfour of Diamonds, five of Diamonds, six of Diamonds, seven of Diamonds, eight of" +
                          "\nDiamonds, nine of Diamonds, ten of Diamonds, Jack of Diamonds, Queen of Diamonds," +
                          "\nKing of Diamonds, Ace of Diamonds, two of Hearts, three of Hearts, four of Hearts," +
                          "\nfive of Hearts, six of Hearts, seven of Hearts, eight of Hearts, nine of Hearts," +
                          "\nten of Hearts, Jack of Hearts, Queen of Hearts, King of Hearts, Ace of Hearts," +
                          "\ntwo of Spades, three of Spades, four of Spades, five of Spades, six of Spades," +
                          "\nseven of Spades, eight of Spades, nine of Spades, ten of Spades, Jack of Spades," +
                          "\nQueen of Spades, King of Spades, Ace of Spades" +"\n");
            Console.Write("\n                       deal from new deck=======================");
           
            Random r = new Random();
            for (int i = 0; i <= cards.Length - 1; i++)
            {
                int temp = r.Next(0, 51);
                Hand(temp);
                Card(temp);
            }

            Console.Write("\n                       all done=======================");
            }

            private static void Hand(int deck)
        {
            if (deck % 4 == 0) Console.Write("  ~~North~~  ");
            else if (deck % 4 == 1) Console.Write("  ~~West~~  ");
            else if (deck % 4 == 2) Console.Write("  ~~South~~  ");
            else if (deck % 4 == 3) Console.Write("  ~~East~~  ");
            else Console.Write("ERROR in Hand()");
        }

        private static void Card(int i, string space = " ")
        {
            string [] value = {"two", "three", "four", "five", "six", "seven", "eight", "nine",
                               "ten", "Jack", "Queen", "King", "Ace"};
            string[] suit = {"Clubs", "Diamonds", "Hearts", "Spades"};
            string card = $"{value[i % 13]} of {suit[i / 13]}";
            Console.WriteLine($"{card}{space} ");
        }
    }
}
