using System;
using System.Xml.Serialization;

namespace XmlDemo
{
    [XmlInclude(typeof(Engine))]
    [XmlInclude(typeof(Chassis))]
    [XmlInclude(typeof(Transmission))]
    [Serializable]
    public abstract class Vehicle
    {
    }

    [Serializable]
    public class Engine : Vehicle
    {

        public int Power { get; set; }
        public int Volume { get; set; }
        public string Type { get; set; }
        public string SerialNumber { get; set; }

    }

    [Serializable]
    public class Chassis : Vehicle
    {

        public int WheelsNumber { get; set; }
        public int PermissibleLoad { get; set; }
        public int ChassisNumber { get; set; }

    }

    [Serializable]
    public class Transmission : Vehicle
    {
        public int NumberOfGears { get; set; }
        public string Manufacturer { get; set; }
        public string Type { get; set; }
    }
}