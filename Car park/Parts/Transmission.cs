using System;
namespace CarPark
{
    public class Transmission
    {
        public int NumberOfGears { get; set; }
        public string Manufacturer { get; set; }
        public string TransmissionType { get; set; }
        public int TransmissionSerialNumber { get; set; }

        public Transmission(int numberOfGears, string manufacturer, string transmissionType, int transmissionSerialNumber)
        {
            this.NumberOfGears = numberOfGears;
            this.Manufacturer = manufacturer;
            this.TransmissionType = transmissionType;
            this.TransmissionSerialNumber = transmissionSerialNumber;
        }
    }
}

