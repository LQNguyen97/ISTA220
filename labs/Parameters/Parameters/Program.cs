using System;

namespace Parameters
{
    class Program
    {
        static void doWork()
        {
            int i = 0;
            Console.WriteLine($"in part 1 i is {i}");
            Pass.Value(i);
            Console.WriteLine($"in part 1 i is still {i}");
            Console.WriteLine("===========================");

            WrappedInt wi = new WrappedInt();
            Console.WriteLine($"in part 2 wi.Number is {wi.Number}");
            Pass.Reference(wi);
            Console.WriteLine($"in part 2 wi.Number is now {wi.Number}");
            Console.WriteLine("===========================");

            Console.WriteLine($"in part 3 i is {i}");
            Pass.Value(ref i);
            Console.WriteLine($"in part 3 i is still {i}");
            Console.WriteLine("===========================");

        }

        static void Main(string[] args)
        {
                doWork();
        }
            
        
    }
}
