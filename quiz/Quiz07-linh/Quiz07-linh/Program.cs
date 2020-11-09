using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz07_linh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is C Sharp quiz 7.");
            Shotgun S = new Shotgun();
            S.Sound();
            Rifle R = new Rifle();
            R.Sound();
            Pistol P = new Pistol();
            P.Sound();
        }
    }
    public interface IFirearm
    {
        void Sound();
    }


    class Shotgun : IFirearm
    {
        public void Sound()
        {
            Console.WriteLine("I am a shotgun and I go Boom.");
        }

    }
    class Rifle : IFirearm
    {
        public void Sound()
        {
            Console.WriteLine("I am a rifle and I go Bang.");
        }

    }
    class Pistol : IFirearm
    {
        public void Sound()
        {
            Console.WriteLine("I am a pistol and I go Pop.");
        }
    }
}
