using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Boat: Vehicle
    {
        public void Sail()
        {
            Console.WriteLine("Sailing");
        }
        public void Float()
        {
            Console.WriteLine("Floating");
        }
        public override void Drive()
        {
            Console.WriteLine("Boating");
        }
    }
}
