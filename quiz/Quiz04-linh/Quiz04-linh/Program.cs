using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz04_linh

{
    namespace Test04
    {
        class Firearm
        {
            public void fire(string name, string sound)
            {
                Console.WriteLine($"I am a {name} and I go {sound}.");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("This is C Sharp quiz 4");
                Firearm shotgun = new Firearm();
                shotgun.fire("shotgun", "Boom");
                Firearm rifle = new Firearm();
                rifle.fire("rifle", "Bang");
                Firearm pistol = new Firearm();
                pistol.fire("pistol", "Pop");
            }
        }
    }
}

