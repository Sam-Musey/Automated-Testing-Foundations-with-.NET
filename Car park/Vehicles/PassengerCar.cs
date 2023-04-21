using System;
namespace Car_park
{
    public class PassengerCar : Vehicle
    {
        public PassengerCar(string modelName, Engine Engine, Chassis Chassis, Transmission Transmission)
        {
            this.ModelName = modelName;
            this.Engine = Engine;
            this.Chassis = Chassis;
            this.Transmission = Transmission;
        }

        public PassengerCar()
        {

        }

        public void Describe()
        {
            Console.WriteLine($"The model of this passenger car is {this.ModelName}. \nIts engine has {this.EnginePower} horsepowers and its volume is {this.EngineVolume} cm^3. \nAlso, the type of the engine is {this.EngineType} and its serial number is {this.EngineSerialNumber}.");
            Console.WriteLine($"The number of chassis of this car is {this.ChassisNumber}. \nThe car has {this.WheelsNumber} wheels and it can carry up to {this.PermissibleLoad} kgs.");
            Console.WriteLine($"The transmission of this car has {this.TransmissionSerialNumber} serial number and its manufacturer is {this.Manufacturer}. \nThe type of transmission is {this.TransmissionType} and it has {this.NumberOfGears} gears.");
        }
    }
}

