using System;

namespace Classes
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("running class program...");
            Point origin = new Point();
            Point bottomRight = new Point(1366, 768);
            Point proof = new Point();
            double distance = origin.DistanceTo(bottomRight);
            Console.WriteLine($"Distance is: {distance}");
            Point gloria = new Point(0, 0);
            Point Phillp = new Point(3, 4);
            distance = gloria.DistanceTo(Phillp);
            Console.WriteLine($"Distance between gloria and Phillp is: {distance}");
            Point Peter = new Point(60,131);
            Console.WriteLine($"Number of Point objects: {Point.ObjectCount()}");
        }

        static void Main(string[] args)
        {
                doWork();
        }
    }
}
