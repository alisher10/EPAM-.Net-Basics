using System;
using System.Xml.Serialization;
using XmlTask;

namespace XmlTask
{
    [XmlInclude(typeof(Engine))]
    [XmlInclude(typeof(Chassis))]
    [XmlInclude(typeof(Transmission))]

    [Serializable]
    public class Chassis : Vehicle
    {

        public int WheelsNumber { get; set; }
        public int PermissibleLoad { get; set; }
        public int ChassisNumber { get; set; }

    }

}
