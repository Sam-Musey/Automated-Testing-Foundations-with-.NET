using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using System.Xml.Serialization;
using Car_park;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating two objects of passenger car type
            PassengerCar vwPolo = new PassengerCar(
                "Volkswagen Polo", new Engine(207, 1984, "L4", 892384797), new Chassis(4, 514, 666777), new Transmission(7, "VW", "automatic", 0012983));

            PassengerCar jiguli = new PassengerCar(
                "Jiguli", new Engine(78, 1568, "L4", 892387834), new Chassis(4, 400, 0012446), new Transmission(4, "AvtoVAZ", "manual", 666789));

            // Creating three objects of truck type
            Truck fordTruck = new Truck(
                "Ford F-150", new Engine(400, 4950, "V8", 454794857), new Chassis(4, 970, 123724396), new Transmission(10, "Ford", "automatic", 777888));

            Truck toyotaTruck = new Truck(
                "Toyota Tacoma", new Engine(159, 2700, "L4", 454794859), new Chassis(4, 700, 123724282), new Transmission(6, "Toyota", "manual", 777111));

            Truck gmcTruck = new Truck(
                "GMC Sierra 2500HD", new Engine(401, 6600, "V8", 454784859), new Chassis(4, 1620, 120124282), new Transmission(6, "GMC", "automatic", 777221));

            // Creating two objects of bus type
            Bus volvoBus = new Bus(
                "Volvo 9700", new Engine(435, 13000, "D13", 882802304), new Chassis(8, 8000, 195376294), new Transmission(12, "Volvo", "automatic", 888999), 56);

            Bus mercedesBus = new Bus(
                "Mercedes-Benz Citaro", new Engine(300, 7700, "L6", 882810304), new Chassis(8, 5600, 195946294), new Transmission(4, "Mercedes-Benz", "automatic", 884599), 28);

            // Creating two objects of scooter type
            Scooter hondaScooter = new Scooter(
                "Honda Rukus", new Engine(4.4, 49, "single-cylinder four-stroke", 777234903), new Chassis(2, 0, 1992887234), new Transmission(2, "Honda", "automatic", 999000));
            Scooter suzukiScooter = new Scooter(
                "Suzuki Access 125", new Engine(8.6, 124, "single-cylinder four-stroke", 736234903), new Chassis(2, 0, 1003887234), new Transmission(3, "Suzuki", "automatic", 996670));

            // --- Task 1 ---
            // Creating a single list of objects of cars, trucks, buses and scooters

            List<Vehicle> allVehicles = new List<Vehicle>();
            allVehicles.Add(vwPolo);
            allVehicles.Add(jiguli);
            allVehicles.Add(fordTruck);
            allVehicles.Add(toyotaTruck);
            allVehicles.Add(gmcTruck);
            allVehicles.Add(volvoBus);
            allVehicles.Add(mercedesBus);
            allVehicles.Add(hondaScooter);
            allVehicles.Add(suzukiScooter);

            // ---Final XML files will be stored in "\Folder_with_xml_files\"

            // ---Task 2.1-- -
            // All information about all vehicles an engine capacity of which is more than 1.5 liters

            XElement xml2_1 = new XElement("Vehicles_with_engine_volume_with_more_than_1500",
            allVehicles
                .Where(vehicle => vehicle.EngineVolume > 1500)
                .Select(vehicle => new XElement("the_vehicle",
                    new XElement("model", vehicle.ModelName),
                    new XElement("horsepower", vehicle.EnginePower),
                    new XElement("engine_volume", vehicle.EngineVolume),
                    new XElement("engine_type", vehicle.EngineType),
                    new XElement("engine_serial_number", vehicle.EngineSerialNumber),
                    new XElement("wheels_number", vehicle.WheelsNumber),
                    new XElement("chassis_number", vehicle.ChassisNumber),
                    new XElement("number_of_gears", vehicle.NumberOfGears),
                    new XElement("manufacturer", vehicle.Manufacturer),
                    new XElement("transmission_type", vehicle.TransmissionType),
                    new XElement("transmission_serial_number", vehicle.TransmissionSerialNumber))));
            xml2_1.Save(@"Folder_with_xml_files/Task_2_1.xml");

            // This task I also implemented as a method in a WriteToXmlVehicles class
            // Using this method I can change the engine volume
            // The results of this method are stored in "Folder_with_xml_files/Task_2_1_method_implementation_by_XSerialization.xml

            WriteToXmlVehicles.WriteToXmlVehiclesWithEngineVolumeMoreThan2(allVehicles, 3000);


            // --- Task 2.2 ---
            // Engine type, serial number and power rating for all buses and trucks

            List<Vehicle> busAndTrucksList = new List<Vehicle>();
            busAndTrucksList.Add(fordTruck);
            busAndTrucksList.Add(toyotaTruck);
            busAndTrucksList.Add(gmcTruck);
            busAndTrucksList.Add(volvoBus);
            busAndTrucksList.Add(mercedesBus);

            XElement xml2_2 = new XElement("engine_info_of_buses_and_trucks",
            busAndTrucksList
                .OrderByDescending(vehicle => vehicle.EnginePower)
                .Select(vehicle => new XElement("the_vehicle",
                    new XElement("model", vehicle.ModelName),
                    new XElement("horsepower", vehicle.EnginePower),
                    new XElement("engine_type", vehicle.EngineType),
                    new XElement("engine_serial_number", vehicle.EngineSerialNumber))));
            xml2_2.Save(@"Folder_with_xml_files/Task_2_2.xml");

            // --- Task 2.3 ---
            // All information about all vehicles, grouped by transmission type

            XElement xml2_3 = new XElement("vehicles_by_transmission_type",
            allVehicles
                .GroupBy(vehicle => vehicle.TransmissionType)
                .OrderByDescending(group => group.Key)
                .Select(group => new XElement("group_by_transmission_type",
                    new XAttribute("transmission_type_ID", group.Key),
                        group.OrderBy(vehicle => vehicle.ModelName)
                        .Select(vehicle =>
                            new XElement("model", vehicle.ModelName,
                            new XElement("horsepower", vehicle.EnginePower),
                            new XElement("engine_volume", vehicle.EngineVolume),
                            new XElement("engine_type", vehicle.EngineType),
                            new XElement("engine_serial_number", vehicle.EngineSerialNumber),
                            new XElement("wheels_number", vehicle.WheelsNumber),
                            new XElement("chassis_number", vehicle.ChassisNumber),
                            new XElement("number_of_gears", vehicle.NumberOfGears),
                            new XElement("manufacturer", vehicle.Manufacturer),
                            new XElement("transmission_type", vehicle.TransmissionType),
                            new XElement("transmission_serial_number", vehicle.TransmissionSerialNumber))))));
            xml2_3.Save(@"Folder_with_xml_files/Task_2_3_final.xml");

            // Just some practice to XSerialize one of the instances of a Bus class
            FileStream stream = new FileStream(@"Folder_with_xml_files/serialization_of_bus.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(Bus));
            serializer.Serialize(stream, volvoBus);

            Console.ReadKey();
        }
    }
}