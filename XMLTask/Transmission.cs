using System;
using System.Xml.Serialization;
using XmlTask;

namespace XmlTask
{
    [XmlInclude(typeof(Engine))]
    [XmlInclude(typeof(Chassis))]
    [XmlInclude(typeof(Transmission))]

    [Serializable]
    public class Transmission : Vehicle
    {
        public int NumberOfGears { get; set; }
        public string Manufacturer { get; set; }
        public string Type { get; set; }
    }
}
