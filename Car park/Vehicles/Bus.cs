using System;
namespace CarPark
{
    public class Bus : Vehicle
    {
        public Bus(string modelName, Engine Engine, Chassis Chassis, Transmission Transmission, int passengerCapacity)
        {
            this.ModelName = modelName;
            this.Engine = Engine;
            this.Chassis = Chassis;
            this.Transmission = Transmission;
            this.PassengerCapacity = passengerCapacity;
        }

        // One additional property that a Vehicle class lacks (unique for a Bus class)
        public int PassengerCapacity { get; set; }

        public void Describe()
        {
            Console.WriteLine($"The model of this bus is {this.ModelName}. \nIts engine has {this.EnginePower} horsepowers and its volume is {this.EngineVolume} cm^3. \nAlso, the type of the engine is {this.EngineType} and its serial number is {this.EngineSerialNumber}.");
            Console.WriteLine($"The number of chassis of this bus is {this.ChassisNumber}. \nThe bus has {this.WheelsNumber} wheels, its maximum payload is {this.PermissibleLoad} kgs and it can transport up to {this.PassengerCapacity} people (number of passenger seats).");
            Console.WriteLine($"The transmission of this bus has {this.TransmissionSerialNumber} serial number and its manufacturer is {this.Manufacturer}. \nThe type of transmission is {this.TransmissionType} and it has {this.NumberOfGears} gears.");
        }
    }
}

