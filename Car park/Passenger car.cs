using System;
namespace Car_park
{
    public class Passenger_car : IEngine, IChassis, ITransmission
	{
        //Implementation of IEngine interface
        public string pasCarModel;
        public double power;
        public float volume;
        public string type;
        public int serialNumber;

        public string PasCarModel { get; set; }     
        public double Power { get; set; }
        public float Volume { get; set; }
        public string Type { get; set; }
        public int SerialNumber { get; set; }

        //Implementation of IChassis interface
        public int wheelsNumber;
        public int permissibleLoad;
        public int number;

        public int WheelsNumber { get; set; }
        public int PermissibleLoad { get; set; }
        public int Number { get; set; }

        //Implementation of ITransmission interface
        public int numberOfGears;
        public string manufacturer;
        public string transmissionType;
        public int transmissionSerialNumber;

        public int NumberOfGears { get; set; }
        public string Manufacturer { get; set; }
        public string TransmissionType { get; set; }
        public int TransmissionSerialNumber { get; set; }

        //The constructor of a car
        public Passenger_car(
            string pasCarModel, double power, float volume, string type, int serialNumber,
            int number, int numberOfGears, string manufacturer, string transmissionType, int transmissionSerialNumber, int wheelsNumber = 4, int permissibleLoad = 600
            )
		{
            this.PasCarModel = pasCarModel;
            this.Power = power;
            this.Volume = volume;
            this.Type = type;
            this.SerialNumber = serialNumber;
            this.WheelsNumber = wheelsNumber;
            this.PermissibleLoad = permissibleLoad;
            this.Number = number;
            this.NumberOfGears = numberOfGears;
            this.Manufacturer = manufacturer;
            this.TransmissionType = transmissionType;
            this.TransmissionSerialNumber = transmissionSerialNumber;
        }

        //The method of description of the passenger car
        public void Describe()
        {
            Console.WriteLine($"The model of this passenger car is {this.PasCarModel}. \nIts engine has {this.Power} horsepowers and its volume is {this.Volume} cm^3. \nAlso, the type of the engine is {this.Type} and its serial number is {this.SerialNumber}.");
            Console.WriteLine($"The number of chassis of this car is {this.Number}. \nThe car has {this.WheelsNumber} wheels and it can carry up to {this.PermissibleLoad} kgs.");
            Console.WriteLine($"The transmission of this car has {this.TransmissionSerialNumber} serial number and its manufacturer is {this.Manufacturer}. \nThe type of transmission is {this.TransmissionType} and it has {this.NumberOfGears} gears.");
        }
	}
}

