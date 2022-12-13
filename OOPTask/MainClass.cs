using System;
using System.Collections.Generic;

namespace OOPTask {
    class MainClass
    {
        static void Main()
        {

            Engine engine = new Engine
            {
                Power = 512,
                Volume = 12,
                Type = "Diesel",
                SerialNumber = "SN12313213"
            };

            Chassis chassis = new Chassis
            {
                WheelsNumber = 4,
                PermissibleLoad = 1000,
                ChassisNumber = "SN52123132"
            };

            Transmission transmission = new Transmission
            {
                NumberOfGears = 4,
                Manufacturer = "Ford",
                Type = "Sport Car"
            };

            Console.WriteLine("INFO ABOUT Engine:");
            Console.WriteLine("Engine power: " + engine.Power);
            Console.WriteLine("Engine Volume: " + engine.Volume);
            Console.WriteLine("Engine type: " + engine.Type);
            Console.WriteLine("Engine Serial Number: " + engine.SerialNumber + "\n");

            Console.WriteLine("INFO ABOUT chassis:");
            Console.WriteLine("Chassis wheels number: " + chassis.WheelsNumber);
            Console.WriteLine("Chassis permissible load : " + chassis.PermissibleLoad);
            Console.WriteLine("Chassis number: " + chassis.ChassisNumber + "\n");

            Console.WriteLine("INFO ABOUT transmission:");
            Console.WriteLine("Transmissions number of gears: " + transmission.NumberOfGears);
            Console.WriteLine("Transmissions Manufacturer: " + transmission.Manufacturer);
            Console.WriteLine("Transmissions type: " + transmission.Type + "\n");

        }
    }
}

