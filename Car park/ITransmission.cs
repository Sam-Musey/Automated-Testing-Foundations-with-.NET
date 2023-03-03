using System;
namespace Car_park
{
    public interface ITransmission
    {
        public int NumberOfGears { get; set; }
        public string Manufacturer { get; set; }
        public string Type { get; set; }
        public int SerialNumber { get; set; }

    }
}

