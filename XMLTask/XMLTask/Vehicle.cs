using System;
using System.Xml.Serialization;

namespace XmlTask
{
    [XmlInclude(typeof(Engine))]
    [XmlInclude(typeof(Chassis))]
    [XmlInclude(typeof(Transmission))]
    [Serializable]
    public abstract class Vehicle
    {
    }

}
