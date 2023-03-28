using System;
using System.Collections;
using CarPark;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Base class is Vehicle
            // PassengerCar, Truck, Bus and Scooter - derived classes
            // These derived classes include Engine, Chassis and Transmission classes as parameters in constructors

            // --- Creating two objects of passenger car and printing their description ---

            PassengerCar vwPolo = new PassengerCar(
                "Volkswagen Polo", new Engine(207, 1984, "L4", 892384797), new Chassis(4, 514, 666777), new Transmission(7, "VW", "automatic", 0012983));
            Console.WriteLine(" --- Here are two passenger cars and their description: ---\n");
            vwPolo.Describe();

            PassengerCar jiguli = new PassengerCar(
                "Jiguli", new Engine(78, 1568, "L4", 892387834), new Chassis(4, 400, 0012446), new Transmission(4, "AvtoVAZ", "manual", 666789));
            Console.WriteLine("\n");
            jiguli.Describe();


            // --- Creating three objects of truck and printing their description ---

            Truck fordTruck = new Truck(
                "Ford F-150", new Engine(400, 4950, "V8", 454794857), new Chassis(4, 970, 123724396), new Transmission(10, "Ford", "automatic", 777888));
            Console.WriteLine("\n");
            Console.WriteLine(" --- Here are three trucks and their description: ---\n");
            fordTruck.Describe();

            Truck toyotaTruck = new Truck(
                "Toyota Tacoma", new Engine(159, 2700, "L4", 454794859), new Chassis(4, 700, 123724282), new Transmission(6, "Toyota", "manual", 777111));
            Console.WriteLine("\n");
            toyotaTruck.Describe();

            Truck gmcTruck = new Truck(
                "GMC Sierra 2500HD", new Engine(401, 6600, "V8", 454784859), new Chassis(4, 1620, 120124282), new Transmission(6, "GMC", "automatic", 777221));
            Console.WriteLine("\n");
            gmcTruck.Describe();


            // --- Creating two objects of bus and printing their description ---

            Bus volvoBus = new Bus(
                "Volvo 9700", new Engine(435, 13000, "D13", 882802304), new Chassis(8, 8000, 195376294), new Transmission(12, "Volvo", "automatic", 888999), 56);
            Console.WriteLine("\n");
            Console.WriteLine(" --- Here are two buses and their description: ---\n");
            volvoBus.Describe();

            Bus mercedesBus = new Bus(
                "Mercedes-Benz Citaro", new Engine(300, 7700, "L6", 882810304), new Chassis(8, 5600, 195946294), new Transmission(4, "Mercedes-Benz", "automatic", 884599), 28);
            Console.WriteLine("\n");
            mercedesBus.Describe();

            // --- Creating an object of scotter and printing its description ---

            Scooter hondaScooter = new Scooter(
                "Honda Rukus", new Engine(4.4, 49, "single-cylinder four-stroke", 777234903), new Chassis(2, 0, 1992887234), new Transmission(2, "Honda", "automatic", 999000));
            Console.WriteLine("\n");
            Console.WriteLine(" --- Here is a scooter and its description: ---\n");
            hondaScooter.Describe();

            Console.ReadKey();   
        }
    }
}