using System;
namespace CarPark
{
    public class Scooter : Vehicle
    {
        public Scooter(string modelName, Engine Engine, Chassis Chassis, Transmission Transmission)
        {
            this.ModelName = modelName;
            this.Engine = Engine;
            this.Chassis = Chassis;
            this.Transmission = Transmission;
        }

        public void Describe()
        {
            Console.WriteLine($"The model of this scooter is {this.ModelName}. \nIts engine has {this.EnginePower} horsepowers and its volume is {this.EngineVolume} cm^3. \nAlso, the type of the engine is {this.EngineType} and its serial number is {this.EngineSerialNumber}.");
            Console.WriteLine($"The number of chassis of this scooter is {this.ChassisNumber}.");
            Console.WriteLine($"The transmission of this scooter has {this.TransmissionSerialNumber} serial number and its manufacturer is {this.Manufacturer}. \nThe type of transmission is {this.TransmissionType} and it has {this.NumberOfGears} gears.");
        }
    }
}

