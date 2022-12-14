using System;
using System.Xml.Serialization;

namespace XmlTask
{
    [XmlInclude(typeof(Engine))]
    [XmlInclude(typeof(Chassis))]
    [XmlInclude(typeof(Transmission))]

    [Serializable]
    public class Engine : Vehicle
    {

        public int Power { get; set; }
        public int Volume { get; set; }
        public string Type { get; set; }
        public string SerialNumber { get; set; }

    }

   
}