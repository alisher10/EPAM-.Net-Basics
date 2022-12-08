using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Xml.Serialization;

namespace XmlDemo
{
    class MyProgram
    {

        static void Main()
        {
            SerializeListToXmlFile();
            DeserializeXmlFileToList();
        }

        private static void SerializeListToXmlFile()
        {
            var vehicleList = new List<Vehicle>()
            {
                new Engine
                {
                    Power = 512,
                    Volume = 12,
                    Type = "Diesel",
                    SerialNumber = "SN12313213"
                },
                new Chassis
                {
                    WheelsNumber = 4,
                    PermissibleLoad = 1000,
                    ChassisNumber = 2,
                },
                new Transmission
                {
                    NumberOfGears = 4,
                    Manufacturer = "Ford",
                    Type = "Sport Car"
                },
            };

            var xmlSerializer = new XmlSerializer(typeof(List<Vehicle>), new Type[] { typeof(Vehicle) });
            using (var writer = new StreamWriter(@"D:\XML\sample02.xml"))
            {
                xmlSerializer.Serialize(writer, vehicleList);
            }
        }

        private static void DeserializeXmlFileToList()
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Vehicle>));
            using (var reader = new StreamReader(@"D:\XML\sample02.xml"))
            {
                var members = xmlSerializer.Deserialize(reader);

            }
        }
    }

}