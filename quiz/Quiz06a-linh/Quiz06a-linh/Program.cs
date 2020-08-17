using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz06a_linh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is C Sharp quiz 6.");
            Firearm F = new Firearm();
            F.shoot();
            Shotgun S = new Shotgun();
            S.sound();
            Rifle R = new Rifle();
            R.sound();
            Pistol P = new Pistol();
            P.sound();
        }
    }
    class Firearm
    { public void shoot()
        {
            Console.WriteLine("I am a firearm and I shoot things.");
        }
    }


    class Shotgun : Firearm
    {
        public void sound()
        {
            Console.WriteLine("I am a shotgun and I go Boom.");
        }
    
    }
    class Rifle : Firearm
    {
        public void sound()
        {
            Console.WriteLine("I am a rifle and I go Bang.");
        }
    
    }
    class Pistol : Firearm
    {
        public void sound()
        {
            Console.WriteLine("I am a pistol and I go Pop.");
        }
    }

}
