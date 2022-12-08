//Create a program which manages a car park. For this purpose, you need to implement the next entities 
//as separate classes: "Engine" (includes the next fields: power, volume, type, serial number), 
//"Chassis" (wheels number, number, permissible load), "Transmission" (type, number of gears, manufacturer).
//
//Implement entities "Passenger car", "Truck", "Bus", "Scooter" using class described previously (distinguished by unique fields)
// and provide the output of complete information about objects of these types

using System;
using System.Collections.Generic;


class Engine {
    public int Power { get; set; }
    public int Volume { get; set; }
    public string Type { get; set; }
    public string SerialNumber { get; set; }
  
}
    
class Chassis {
    
    public int WheelsNumber { get; set; }
    public int PermissibleLoad { get; set; }
    public string ChassisNumber { get; set; }
}
    
class Transmission {
    public int NumberOfGears { get; set; }
    public string Manufacturer { get; set; }
    public string Type { get; set; }
}
    
class MyProgram {
        
    static void Main() {
        
        Engine engine = new Engine {
            Power = 512,
            Volume = 12,
            Type = "Diesel",
            SerialNumber = "SN12313213"
        };
        
        Chassis chassis = new Chassis {
            WheelsNumber = 4,
            PermissibleLoad = 1000,
            ChassisNumber = "SN52123132"
        };
        
        Transmission transmission = new Transmission {
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
