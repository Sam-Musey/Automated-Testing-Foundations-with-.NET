using System;
using System.Xml.Serialization;

namespace Car_park
{
	public class WriteToXmlVehicles
	{
        public static void WriteToXmlVehiclesWithEngineVolumeMoreThan2(List<Vehicle> vehicles, double engineVolume)
        {
            List<Vehicle> theVehicles = new List<Vehicle>();
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.EngineVolume > engineVolume)
                    theVehicles.Add(vehicle);
            }

            FileStream stream = new FileStream(@"Folder_with_xml_files/Task_2_1_method_implementation_by_XSerialization.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Vehicle>));
            serializer.Serialize(stream, theVehicles);
        }
	}
}

