using InterfaceAndAbstractClass;
using System;

namespace InterfaceAndAbstractClass
{
    class Bird : IFlyable
    {

        public Coordinate currentPosition = new Coordinate(0, 0, 0);
        public int speed;

        public Bird(Coordinate coordinate)
        {
            currentPosition = coordinate;
            speed = 15;
        }

        public void FlyTo(Coordinate coordinate)
        {
            currentPosition = coordinate;
        }

        public float GetFlyTime(Coordinate c)
        {
            float distance = (c.x - currentPosition.x) * (c.x - currentPosition.x) +
                (c.y - currentPosition.y) * (c.y - currentPosition.y) + (c.z - currentPosition.z) * (c.z - currentPosition.z);
            return distance / speed;
        }

        public override string ToString()
        {
            return ("Birds position: " + this.currentPosition + " & " + "speed: " + this.speed);
        }
    };

}
