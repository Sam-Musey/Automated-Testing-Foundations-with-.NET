using System;
namespace CarPark
{
    public class Engine
    {
        public double Power { get; set; }
        public float Volume { get; set; }
        public string EngineType { get; set; }
        public int EngineSerialNumber { get; set; }

        public Engine(double power, float volume, string engineType, int engineSerialNumber)
        {
            this.Power = power;
            this.Volume = volume;
            this.EngineType = engineType;
            this.EngineSerialNumber = engineSerialNumber;
        }
    }
}

