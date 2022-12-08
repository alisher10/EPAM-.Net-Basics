//Create a "Coordinate" structure that defines the 3D coordinates of some object (positive numbers). 
//Define an IFlyable interface with the FlyTo (new point), GetFlyTime (new point) methods. Create classes "Bird", 
//"Airplane", "Drone", which implement this interface and contain at least the field "Current position".
//
//Use the following assumptions: the bird flies the entire distance at a constant speed in the range of 0-20 km/h (set randomly), 
//the aircraft increases speed by 10 km/h every 10 km of flight from an initial speed of 200 km/h, 
//the drone hovers in the air every 10 minutes of flight for 1 minute. 
//Based on the task, introduce additional restrictions (for example, the impossibility of flying a drone at a distance of more than 1000 km). 
//Describe the methods and restrictions imposed in the comments.

using System;

struct Coordinate
{
    public uint x;
    public uint y;
    public uint z;
    public Coordinate(uint x, uint y, uint z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    
    public override string ToString()
    {
        return (this.x + ", " + this.y + ", " + this.z);
    }
};

interface IFlyable
{
    //declaring 2 methods in our Interface
    void FlyTo(Coordinate coordinate);
    float GetFlyTime(Coordinate coordinate);
};

class Bird : IFlyable
{
   
    public Coordinate currentPosition = new Coordinate(0, 0, 0);
    public int speed;
    
    //creating parametrized consturctor
    public Bird(Coordinate coordinate) {
        currentPosition = coordinate;
        speed = 15;
    }
    
    //implementing method FlyTo
    public void FlyTo(Coordinate coordinate)
    {
        currentPosition = coordinate;//setting initial value with a current one
    }
    
    //implementing method GetFlyTime
    public float GetFlyTime(Coordinate c)
    {
        // (x2-x1)^2+(y2-y1)^2+(z2-z1)^2
        float distance = (c.x - currentPosition.x) * (c.x - currentPosition.x) +
            (c.y - currentPosition.y) * (c.y - currentPosition.y) + (c.z - currentPosition.z) * (c.z - currentPosition.z);
        return distance / speed;
    }
    
    public override string ToString()
    {
        return ("Birds position: " + this.currentPosition + " & " + "speed: " + this.speed);
    }
};

class Airplane : IFlyable {
  public Coordinate currentPosition = new Coordinate(0, 0, 0);
  public int speed = 200;
  public int acceleration = 10;
  public Airplane(Coordinate coordinate) {
     currentPosition = coordinate;
  }
  public void FlyTo(Coordinate coordinate) {
    currentPosition = coordinate;
  }
  public float GetFlyTime(Coordinate c) {
    // (x2-x1)^2+(y2-y1)^2+(z2-z1)^2
    float distance = (c.x - currentPosition.x) * (c.x - currentPosition.x) + (c.y - currentPosition.y) *
    (c.y - currentPosition.y) + (c.z - currentPosition.z) * (c.z - currentPosition.z);
    float    hours = 0;
    while (distance>speed) {
      distance -= speed;
      speed += acceleration;
      hours += 1;
    }
    return hours + distance/speed;
  }
  
  public override string ToString()
    {
        return ("Airplanes position: " + this.currentPosition + " & " + "speed: " + this.speed);
    }
};

class Drone : IFlyable {
  public Coordinate currentPosition = new Coordinate(0, 0, 0);
  public int speed;
  
  public Drone(Coordinate coordinate) {
      speed = 50;
      currentPosition = coordinate;
  }
  public void FlyTo(Coordinate coordinate) {
    currentPosition = coordinate;
  }
  
  
  public float GetFlyTime(Coordinate c) {
    // (x2-x1)^2+(y2-y1)^2+(z2-z1)^2
    float distance = (c.x - currentPosition.x) * (c.x - currentPosition.x) + (c.y - currentPosition.y) *
    (c.y - currentPosition.y) + (c.z - currentPosition.z) * (c.z - currentPosition.z);
    return (float)(distance / speed * 1.1);
  }
  
    public override string ToString()
    {
        return ("Drones position: " + this.currentPosition + " & " + "speed: " + this.speed);
    }
};
class MyProgram
{
    static void Main()
    {
        Bird bird = new Bird(new Coordinate(0, 0, 0));
        Airplane airplane = new Airplane(new Coordinate(1, 2, 3));
        Drone drone = new Drone(new Coordinate(5, 1, 3));
        Console.WriteLine(bird);
        Console.WriteLine(airplane);
        Console.WriteLine(drone);
        
        
        Console.WriteLine(bird.GetFlyTime(new Coordinate(2, 3, 1)));
        Console.WriteLine(airplane.GetFlyTime(new Coordinate(500, 38, 232)));
        Console.WriteLine(drone.GetFlyTime(new Coordinate(10, 10, 23)));
        Console.WriteLine(bird);
        Console.WriteLine(airplane);
        Console.WriteLine(drone);
        
        
        bird.FlyTo(new Coordinate(2, 3, 1));
        airplane.FlyTo(new Coordinate(500, 38, 232));
        drone.FlyTo(new Coordinate(10, 10, 23));
        Console.WriteLine(bird);
        Console.WriteLine(airplane);
        Console.WriteLine(drone);
    }
}