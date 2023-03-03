using System;
using System.Collections;
using Car_park;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // For this task I created three Interfaces: IEngine, IChassis, ITransmission
            // Then I created 4 classes that implements those three interfaces
            // After that I created several instances of those classes

            // --- Creating two objects of passenger car and printing their description ---

            Passenger_car vwPolo = new Passenger_car(
                "Volkswagen Polo", 207.0, 1984, "L4", 892384797, 0012983, 7, "VW", "automatic", 666777, 4, 514 );
            Console.WriteLine(" --- Here are two passenger cars and their description: ---\n");
            vwPolo.Describe();

            Passenger_car jiguli = new Passenger_car(
                "Jiguli", 78, 1568, "L4", 892387834, 0012446, 4, "AvtoVAZ", "manual", 666789, 4, 400 );
            Console.WriteLine("\n");
            jiguli.Describe();


            // --- Creating three objects of truck and printing their description ---

            Truck fordTruck = new Truck(
                "Ford F-150", 400, 4950, "V8", 454794857, 123724396, 10, "Ford", "automatic", 777888, 4, 970 );
            Console.WriteLine("\n");
            Console.WriteLine(" --- Here are three trucks and their description: ---\n");
            fordTruck.Describe();

            Truck toyotaTruck = new Truck(
                "Toyota Tacoma", 159, 2700, "L4", 454794859, 123724282, 6, "Toyota", "manual", 777111, 4, 700 );
            Console.WriteLine("\n");
            toyotaTruck.Describe();

            Truck gmcTruck = new Truck(
                "GMC Sierra 2500HD", 401, 6600, "V8", 454784859, 120124282, 6, "GMC", "automatic", 777221, 4, 1620 );
            Console.WriteLine("\n");
            gmcTruck.Describe();


            // --- Creating two objects of bus and printing their description ---

            Bus volvoBus = new Bus(
                "Volvo 9700", 435, 13000, "D13", 882802304, 195376294, 12, "Volvo", "automatic", 888999, 8, 8000, 56 );
            Console.WriteLine("\n");
            Console.WriteLine(" --- Here are two buses and their description: ---\n");
            volvoBus.Describe();

            Bus mercedesBus = new Bus(
                "Mercedes-Benz Citaro", 300, 7700, "L6", 882810304, 195946294, 4, "Mercedes-Benz", "automatic", 884599, 8, 5600, 28 );
            Console.WriteLine("\n");
            mercedesBus.Describe();

            // --- Creating an object of scotter and printing its description ---

            Scooter hondaScooter = new Scooter(
                "Honda Rukus", 4.4, 49, "single-cylinder four-stroke", 777234903, 1992887234, 2, "Honda", "automatic", 999000 );
            Console.WriteLine("\n");
            Console.WriteLine(" --- Here is a scooter and its description: ---\n");
            hondaScooter.Describe();

            Console.ReadKey();   
        }
    }
}