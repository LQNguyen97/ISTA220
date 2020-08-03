using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04_linh
{
    class Horse
    {
        public string name;

        public Horse(string Name)
        {
            name = Name;
        }

        public void Speak()
        {
            Console.WriteLine($"Hi, my name is {this.name} and I am a {this.GetType()}. I say Neigh.");
        }

        public void Eat()
        {
            Console.WriteLine($"This {this.GetType()} eats grass.");
        }

        public void Produce()
        {
            Console.WriteLine($"This {this.GetType()} Produce milk.");
        }

        public void Move()
        {
            Console.WriteLine($"This {this.GetType()} gallops on grass.");
        }
    }
}
