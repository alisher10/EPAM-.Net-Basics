using InterfaceAndAbstractClass;
using System;

namespace InterfaceAndAbstractClass
{
    interface IFlyable
    {
        void FlyTo(Coordinate coordinate);
        float GetFlyTime(Coordinate coordinate);
    };
}
