using System;

namespace InterfaceAndAbstractClass
{
    class Airplane : IFlyable
    {
        public Coordinate currentPosition = new Coordinate(0, 0, 0);
        public int speed = 200;
        public int acceleration = 10;
        public Airplane(Coordinate coordinate)
        {
            currentPosition = coordinate;
        }
        public void FlyTo(Coordinate coordinate)
        {
            currentPosition = coordinate;
        }
        public float GetFlyTime(Coordinate c)
        {
            float distance = (c.x - currentPosition.x) * (c.x - currentPosition.x) + (c.y - currentPosition.y) *
            (c.y - currentPosition.y) + (c.z - currentPosition.z) * (c.z - currentPosition.z);
            float hours = 0;
            while (distance > speed)
            {
                distance -= speed;
                speed += acceleration;
                hours += 1;
            }
            return hours + distance / speed;
        }

        public override string ToString()
        {
            return ("Airplanes position: " + this.currentPosition + " & " + "speed: " + this.speed);
        }
    };

}
