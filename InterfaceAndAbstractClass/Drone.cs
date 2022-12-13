using System;

namespace InterfaceAndAbstractClass
{
    class Drone : IFlyable
    {
        public Coordinate currentPosition = new Coordinate(0, 0, 0);
        public int speed;
        public Drone(Coordinate coordinate)
        {
            speed = 50;
            currentPosition = coordinate;
        }
        public void FlyTo(Coordinate coordinate)
        {
            currentPosition = coordinate;
        }
        public bool AllowedRange(Coordinate c)
        {
            float distance = (c.x - currentPosition.x) * (c.x - currentPosition.x) + (c.y - currentPosition.y) *
                (c.y - currentPosition.y) + (c.z - currentPosition.z) * (c.z - currentPosition.z);
            if (distance < 1000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public float GetFlyTime(Coordinate c)
        {
            if (AllowedRange(c))
            {
                float distance = (c.x - currentPosition.x) * (c.x - currentPosition.x) + (c.y - currentPosition.y) *
                    (c.y - currentPosition.y) + (c.z - currentPosition.z) * (c.z - currentPosition.z);
                return (float)(distance / speed * 1.1);
            }
            else
            {
                return 0;
            }

        }

        public override string ToString()
        {
            return ("Drones position: " + this.currentPosition + " & " + "speed: " + this.speed);
        }
    };
}
