using System;

namespace Parameters
{
    class WrappedInt
    {
        public int Number;
        public static void Reference(WrappedInt param)
        {
            Console.WriteLine($"   in method Reference param is {param}");
            param.Number = 42;
            Console.WriteLine($"   in method Reference param is now {param}");
        }
    }
}
