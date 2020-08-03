using System;

namespace Parameters
{
    class Pass
    {
        public static void Reference(WrappedInt param)
        {
            Console.WriteLine($"   in method Reference param is {param}");
            param.Number = 42;
            Console.WriteLine($"   in method Reference param is now {param}");
        }
        public static void Value(int param)
        {
            Console.WriteLine($"   in method value param is {param}");
            param = 42;
            Console.WriteLine($"   in method value param is now {param}");
        }
        public static void Value(ref int param)
        {
            Console.WriteLine($"   in method Value1 param is {param}");
            param = 42;
            Console.WriteLine($"   in method Value1 param is now {param}");
        }

    }
}
