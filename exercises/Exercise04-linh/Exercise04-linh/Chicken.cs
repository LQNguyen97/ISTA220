using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04_linh
{
    class Chicken
    {
        public string name;

        public Chicken(string Name)
        {
            name = Name;
        }

        public void Speak()
        {
            Console.WriteLine($"Hi, my name is {this.name} and I am a {this.GetType()}. I say Bacawk.");
        }

        public void Eat()
        {
            Console.WriteLine($"This {this.GetType()} eats grain.");
        }

        public void Produce()
        {
            Console.WriteLine($"This {this.GetType()} Produce eggs.");
        }

        public void Move()
        {
            Console.WriteLine($"This {this.GetType()} clucking through the farm.");
        }
    }
}
