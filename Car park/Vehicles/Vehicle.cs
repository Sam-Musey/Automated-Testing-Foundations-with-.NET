using System;
using CarPark;

namespace CarPark
{
    public class Vehicle
    {
        private protected Engine Engine;
        private protected Chassis Chassis;
        private protected Transmission Transmission;

        public string ModelName { get; set; }

        // Properties of Engine class

        public double EnginePower
        {
            get { return Engine.Power; }
            set { Engine.Power = value; }
        }

        public float EngineVolume
        {
            get { return Engine.Volume; }
            set { Engine.Volume = value; }
        }

        public string EngineType
        {
            get { return Engine.EngineType; }
            set { Engine.EngineType = value; }
        }

        public int EngineSerialNumber
        {
            get { return Engine.EngineSerialNumber; }
            set { Engine.EngineSerialNumber = value; }
        }

        // Properties of Chassis class

        public int WheelsNumber
        {
            get { return Chassis.WheelsNumber; }
            set { Chassis.WheelsNumber = value; }
        }

        public int PermissibleLoad
        {
            get { return Chassis.PermissibleLoad; }
            set { Chassis.PermissibleLoad = value; }
        }

        public int ChassisNumber
        {
            get { return Chassis.ChassisNumber; }
            set { Chassis.ChassisNumber = value; }
        }

        // Properties of Transmission class

        public int NumberOfGears
        {
            get { return Transmission.NumberOfGears; }
            set { Transmission.NumberOfGears = value; }
        }

        public string Manufacturer
        {
            get { return Transmission.Manufacturer; }
            set { Transmission.Manufacturer = value; }
        }

        public string TransmissionType
        {
            get { return Transmission.TransmissionType; }
            set { Transmission.TransmissionType = value; }
        }

        public int TransmissionSerialNumber
        {
            get { return Transmission.TransmissionSerialNumber; }
            set { Transmission.TransmissionSerialNumber = value; }
        }
    }
}

