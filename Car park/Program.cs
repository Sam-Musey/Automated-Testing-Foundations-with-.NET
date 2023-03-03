using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using Car_park;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating two objects of passenger car type
            Passenger_car vwPolo = new Passenger_car(
                "Volkswagen Polo", 207.0, 1984, "L4", 892384797, 0012983, 7, "VW", "automatic", 666777, 4, 514 );
            Passenger_car jiguli = new Passenger_car(
                "Jiguli", 78, 1568, "L4", 892387834, 0012446, 4, "AvtoVAZ", "manual", 666789, 4, 400 );

            // Creating three objects of truck type
            Truck fordTruck = new Truck(
                "Ford F-150", 400, 4950, "V8", 454794857, 123724396, 10, "Ford", "automatic", 777888, 4, 970 );
            Truck toyotaTruck = new Truck(
                "Toyota Tacoma", 159, 2700, "L4", 454794859, 123724282, 6, "Toyota", "manual", 777111, 4, 700 );
            Truck gmcTruck = new Truck(
                "GMC Sierra 2500HD", 401, 6600, "V8", 454784859, 120124282, 6, "GMC", "automatic", 777221, 4, 1620 );

            // Creating two objects of bus type
            Bus volvoBus = new Bus(
                "Volvo 9700", 435, 13000, "D13", 882802304, 195376294, 12, "Volvo", "automatic", 888999, 8, 8000, 56 );
            Bus mercedesBus = new Bus(
                "Mercedes-Benz Citaro", 300, 7700, "L6", 882810304, 195946294, 4, "Mercedes-Benz", "automatic", 884599, 8, 5600, 28 );

            // Creating two objects of scooter type
            Scooter hondaScooter = new Scooter(
                "Honda Rukus", 4.4, 49, "single-cylinder four-stroke", 777234903, 1992887234, 2, "Honda", "automatic", 999000 );
            Scooter suzukiScooter = new Scooter(
                "Suzuki Access 125", 8.6, 124, "single-cylinder four-stroke", 736234903, 1003887234, 3, "Suzuki", "automatic", 996670 );

            // --- Task 1 ---
            // Creating ArrayLists of cars, trucks, buses and scooters
            // I decided to use multiple ArrayLists because our objects are of different types

            ArrayList pasCarList = new ArrayList();
            pasCarList.Add(vwPolo);
            pasCarList.Add(jiguli);

            ArrayList truckList = new ArrayList();
            truckList.Add(fordTruck);
            truckList.Add(toyotaTruck);
            truckList.Add(gmcTruck);

            ArrayList busList = new ArrayList();
            busList.Add(volvoBus);
            busList.Add(mercedesBus);

            ArrayList scooterList = new ArrayList();
            scooterList.Add(hondaScooter);
            scooterList.Add(suzukiScooter);

            // --- Final XML files will be stored here --->
            // ---> Car Park (Collection and XML task)/Car park/bin/Debug/net7.0/Folder with xml files/

            // --- Task 2.1 ---
            // All information about all vehicles an engine capacity of which is more than 1.5 liters

            XElement xml2_1 = new XElement("volumeMoreThan1500",
            from Passenger_car car in pasCarList
            where car.Volume > 1500
            select new XElement("passenger_cars_with_more_than_1-5_liters",
                    new XElement("car_model", car.PasCarModel),
                    new XElement("car_horsepower", car.Power),
                    new XElement("car_engine_volume", car.Volume),
                    new XElement("car_engine_type", car.Type),
                    new XElement("car_engine_serial_number", car.SerialNumber),
                    new XElement("car_wheels_number", car.WheelsNumber),
                    new XElement("car_chassis_number", car.Number),
                    new XElement("car_number_of_gears", car.NumberOfGears),
                    new XElement("car_manufacturer", car.Manufacturer),
                    new XElement("car_transmission_type", car.TransmissionType),
                    new XElement("car_transmission_serial_number", car.TransmissionSerialNumber)
                ),
            from Truck truck in truckList
            where truck.Volume > 1500
            select new XElement("trucks_with_more_than_1-5_liters",
                    new XElement("truck_model", truck.TruckModel),
                    new XElement("truck_horsepower", truck.Power),
                    new XElement("truck_engine_volume", truck.Volume),
                    new XElement("truck_engine_type", truck.Type),
                    new XElement("truck_engine_serial_number", truck.SerialNumber),
                    new XElement("truck_wheels_number", truck.WheelsNumber),
                    new XElement("truck_chassis_number", truck.Number),
                    new XElement("truck_number_of_gears", truck.NumberOfGears),
                    new XElement("truck_manufacturer", truck.Manufacturer),
                    new XElement("truck_transmission_type", truck.TransmissionType),
                    new XElement("truck_transmission_serial_number", truck.TransmissionSerialNumber)
                ),
            from Bus bus in busList
            where bus.Volume > 1500
            select new XElement("buses_with_more_than_1-5_liters",
                    new XElement("bus_model", bus.BusModel),
                    new XElement("bus_horsepower",bus.Power),
                    new XElement("bus_engine_volume", bus.Volume),
                    new XElement("bus_engine_type", bus.Type),
                    new XElement("bus_engine_serial_number", bus.SerialNumber),
                    new XElement("bus_wheels_number", bus.WheelsNumber),
                    new XElement("bus_chassis_number", bus.Number),
                    new XElement("bus_number_of_gears", bus.NumberOfGears),
                    new XElement("bus_manufacturer", bus.Manufacturer),
                    new XElement("bus_transmission_type", bus.TransmissionType),
                    new XElement("bus_transmission_serial_number", bus.TransmissionSerialNumber)
                ),
            from Scooter scooter in scooterList
            where scooter.Volume > 1500
            select new XElement("scooters_with_more_than_1-5_liters",
                    new XElement("scooter_model", scooter.ScooterModel),
                    new XElement("scooter_horsepower", scooter.Power),
                    new XElement("scooter_engine_volume", scooter.Volume),
                    new XElement("scooter_engine_type", scooter.Type),
                    new XElement("scooter_engine_serial_number", scooter.SerialNumber),
                    new XElement("scooter_wheels_number", scooter.WheelsNumber),
                    new XElement("scooter_chassis_number", scooter.Number),
                    new XElement("scooter_number_of_gears", scooter.NumberOfGears),
                    new XElement("scooter_manufacturer", scooter.Manufacturer),
                    new XElement("scooter_transmission_type", scooter.TransmissionType),
                    new XElement("scooter_transmission_serial_number", scooter.TransmissionSerialNumber)
                )
            );
            xml2_1.Save(@"/Users/msv/Projects/Car Park (Collection and XML task)/Car park/bin/Debug/net7.0/Folder with xml files/Task_2_1.xml");

            // --- Task 2.2 ---
            // Engine type, serial number and power rating for all buses and trucks;

            XElement xml2_2 = new XElement("engine_info_of_buses_and_trucks",
            from Bus bus in busList
            orderby bus.Power descending
            select new XElement("engine_info_of_buses",
                    new XElement("bus_model", bus.BusModel),
                    new XElement("bus_horsepower", bus.Volume),
                    new XElement("bus_engine_type", bus.Type),
                    new XElement("bus_engine_serial_number", bus.SerialNumber)
                ),
            from Truck truck in truckList
            orderby truck.Power descending
            select new XElement("engine_info_of_trucks",
                    new XElement("truck_model", truck.TruckModel),
                    new XElement("truck_horsepower", truck.Volume),
                    new XElement("truck_engine_type", truck.Type),
                    new XElement("truck_engine_serial_number", truck.SerialNumber)
                )
            );
            xml2_2.Save(@"/Users/msv/Projects/Car Park (Collection and XML task)/Car park/bin/Debug/net7.0/Folder with xml files/Task_2_2.xml");

            // --- Task 2.3 ---
            // All information about all vehicles, grouped by transmission type

            // For this task I implement LINQ query to make xml file with all info about all vehicles
            // After that I use this xml file to make another one with data grouped by transmission type

            XElement xml2_3 = new XElement("all_vehicles_by_transmission_type",
            from Passenger_car car in pasCarList
            select new XElement("model",car.PasCarModel,
                    new XElement("model", car.PasCarModel),
                    new XElement("horsepower", car.Power),
                    new XElement("engine_volume", car.Volume),
                    new XElement("engine_type", car.Type),
                    new XElement("engine_serial_number", car.SerialNumber),
                    new XElement("wheels_number", car.WheelsNumber),
                    new XElement("chassis_number", car.Number),
                    new XElement("number_of_gears", car.NumberOfGears),
                    new XElement("manufacturer", car.Manufacturer),
                    new XElement("transmission_type", car.TransmissionType),
                    new XElement("transmission_serial_number", car.TransmissionSerialNumber)
                ),
            from Truck truck in truckList
            select new XElement("model", truck.TruckModel,
                    new XElement("model", truck.TruckModel),
                    new XElement("horsepower", truck.Volume),
                    new XElement("engine_volume", truck.Volume),
                    new XElement("engine_type", truck.Type),
                    new XElement("engine_serial_number", truck.SerialNumber),
                    new XElement("wheels_number", truck.WheelsNumber),
                    new XElement("chassis_number", truck.Number),
                    new XElement("number_of_gears", truck.NumberOfGears),
                    new XElement("manufacturer", truck.Manufacturer),
                    new XElement("transmission_type", truck.TransmissionType),
                    new XElement("transmission_serial_number", truck.TransmissionSerialNumber)
                ),
            from Bus bus in busList
            select new XElement("model", bus.BusModel,
                    new XElement("model", bus.BusModel),
                    new XElement("horsepower", bus.Volume),
                    new XElement("engine_volume", bus.Volume),
                    new XElement("engine_type", bus.Type),
                    new XElement("engine_serial_number", bus.SerialNumber),
                    new XElement("wheels_number", bus.WheelsNumber),
                    new XElement("chassis_number", bus.Number),
                    new XElement("number_of_gears", bus.NumberOfGears),
                    new XElement("manufacturer", bus.Manufacturer),
                    new XElement("transmission_type", bus.TransmissionType),
                    new XElement("transmission_serial_number", bus.TransmissionSerialNumber)
                ),
            from Scooter scooter in scooterList
            select new XElement("model", scooter.ScooterModel,
                    new XElement("model", scooter.ScooterModel),
                    new XElement("horsepower", scooter.Volume),
                    new XElement("engine_volume", scooter.Volume),
                    new XElement("engine_type", scooter.Type),
                    new XElement("engine_serial_number", scooter.SerialNumber),
                    new XElement("wheels_number", scooter.WheelsNumber),
                    new XElement("chassis_number", scooter.Number),
                    new XElement("number_of_gears", scooter.NumberOfGears),
                    new XElement("manufacturer", scooter.Manufacturer),
                    new XElement("transmission_type", scooter.TransmissionType),
                    new XElement("transmission_serial_number", scooter.TransmissionSerialNumber)
                )
            ) ;
            xml2_3.Save(@"/Users/msv/Projects/Car Park (Collection and XML task)/Car park/bin/Debug/net7.0/Folder with xml files/Task_2_3_interm.xml");


            XElement xml3_2_final = XElement.Load(@"/Users/msv/Projects/Car Park (Collection and XML task)/Car park/bin/Debug/net7.0/Folder with xml files/Task_2_3_interm.xml");
            var groupByTransmission =
                new XElement("Root",
                    from data in xml3_2_final.Elements("model")
                    group data by (string)data.Element("transmission_type") into groupedData
                    select new XElement("Group",
                        new XAttribute("ID", groupedData.Key),
                        from g in groupedData
                        select new XElement("model",
                        g.Element("model"),
                        g.Element("transmission_type"),
                        g.Element("horsepower"),
                        g.Element("engine_volume"),
                        g.Element("engine_type"),
                        g.Element("engine_serial_number"),
                        g.Element("wheels_number"),
                        g.Element("chassis_number"),
                        g.Element("number_of_gears"),
                        g.Element("manufacturer"),
                        g.Element("transmission_serial_number")
                    ))
                );
            xml3_2_final.Save(@"/Users/msv/Projects/Car Park (Collection and XML task)/Car park/bin/Debug/net7.0/Folder with xml files/Task_2_3_final.xml");
            Console.WriteLine(groupByTransmission);

            Console.ReadKey();
        }
    }
}