using System;
using Vehicle;

namespace Vehicle
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("This is the Vehicle Lab.");
            Console.WriteLine("============================================");
            Console.WriteLine("Journey by airplane:");
            Airplane myPlane = new Airplane();
            myPlane.StartEngine("Contact");
            myPlane.TakeOff();
            myPlane.Drive();
            myPlane.Land();
            myPlane.StopEngine("Whirr");
            Console.WriteLine("============================================");
            Console.WriteLine("Journey by car:");
            Car myCar = new Car();
            myCar.StartEngine("Brm brm");
            myCar.Accelerate();
            myCar.Drive();
            myCar.Brake();
            myCar.StopEngine("Phut phut");
            Console.WriteLine("============================================");
            Console.WriteLine("Journey by Truck:");
            Truck tyra = new Truck();
            tyra.StartEngine("Vroom Vroom");
            tyra.Haul();
            tyra.Drive();
            tyra.Tows();
            tyra.StopEngine("Klunk Klunk");
            Console.WriteLine("============================================");
            Console.WriteLine("Journey by Boat:");
            Boat Titanic = new Boat();
            Titanic.StartEngine("Swish Swish");
            Titanic.Sail();
            Titanic.Drive();
            Titanic.Float();
            Titanic.StopEngine("Glug Glug");
            Console.WriteLine("============================================");
            Console.WriteLine("Testing polymorphism");
            Vehicle v = myCar;
            v.Drive();
            v = myPlane;
            v.Drive();
            v = tyra;
            v.Drive();
          
        }

        static void Main()
        {
                doWork();
        }
    }
}

//Polymorphism: method drive changes depend on the type of argument it get.
