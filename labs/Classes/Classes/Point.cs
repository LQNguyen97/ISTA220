

using System;
using System.Runtime.Remoting.Messaging;

namespace Classes
{
    class Point
   {
        //This create instance fields x and y
        int x;
        int y;
        //Class fields will eventually go here
        private static int numOfPts = 0;

        public Point()
        {
            x = -1;
            y = -1;
            numOfPts++;
            Console.WriteLine("Default constructor called");
            Console.WriteLine($"Default x is {x} amd default y is {y}");
        }
        public Point(int xVar, int yVar)
        {
            x = xVar;
            y = yVar;
            numOfPts++;
            Console.WriteLine($"x:{x}, y:{y}");
        }
        public double DistanceTo(Point other)
        {
            int xDiff = this.x - other.x;
            int yDiff = this.y - other.y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;         
        }
        public static int ObjectCount()
        {
            return numOfPts;
        }
    }
}
   

