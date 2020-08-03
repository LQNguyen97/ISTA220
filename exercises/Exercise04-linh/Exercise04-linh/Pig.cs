using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04_linh
{
    class Pig
    {
        public string name;

        public Pig(string Name)
        {
            name = Name;
        }

        public void Speak()
        {
            Console.WriteLine($"Hi, my name is {this.name} and I am a {this.GetType()}. I say Oink.");
        }

        public void Eat()
        {
            Console.WriteLine($"This {this.GetType()} eats soybeans.");
        }

        public void Produce()
        {
            Console.WriteLine($"This {this.GetType()} Produce bacon.");
        }

        public void Move()
        {
            Console.WriteLine($"This {this.GetType()} wallows in the mud.");
        }
    }
}
