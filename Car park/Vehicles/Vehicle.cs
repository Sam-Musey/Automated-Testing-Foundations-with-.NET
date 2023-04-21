using System;
using System.Xml.Serialization;

namespace Car_park
{
    [XmlInclude(typeof(PassengerCar))]
    [XmlInclude(typeof(Truck))]
    [XmlInclude(typeof(Bus))]
    [XmlInclude(typeof(Scooter))]

    public class Vehicle
    {
        private protected Engine Engine;
        private protected Chassis Chassis;
        private protected Transmission Transmission;

        public string ModelName { get; set; }

        // Properties of Engine class

        [XmlElement("engine_power")]
        public double EnginePower
        {
            get { return Engine.Power; }
            set { Engine.Power = value; }
        }

        [XmlElement("engine_volume")]
        public float EngineVolume
        {
            get { return Engine.Volume; }
            set { Engine.Volume = value; }
        }

        [XmlElement("engine_type")]
        public string EngineType
        {
            get { return Engine.EngineType; }
            set { Engine.EngineType = value; }
        }

        [XmlElement("engine_serial_number")]
        public int EngineSerialNumber
        {
            get { return Engine.EngineSerialNumber; }
            set { Engine.EngineSerialNumber = value; }
        }

        // Properties of Chassis class

        [XmlElement("wheels_number")]
        public int WheelsNumber
        {
            get { return Chassis.WheelsNumber; }
            set { Chassis.WheelsNumber = value; }
        }

        [XmlElement("permissible_load")]
        public int PermissibleLoad
        {
            get { return Chassis.PermissibleLoad; }
            set { Chassis.PermissibleLoad = value; }
        }

        [XmlElement("chassis_number")]
        public int ChassisNumber
        {
            get { return Chassis.ChassisNumber; }
            set { Chassis.ChassisNumber = value; }
        }

        // Properties of Transmission class

        [XmlElement("number_of_gears")]
        public int NumberOfGears
        {
            get { return Transmission.NumberOfGears; }
            set { Transmission.NumberOfGears = value; }
        }

        [XmlElement("manufacturer")]
        public string Manufacturer
        {
            get { return Transmission.Manufacturer; }
            set { Transmission.Manufacturer = value; }
        }

        [XmlElement("transmission_type")]
        public string TransmissionType
        {
            get { return Transmission.TransmissionType; }
            set { Transmission.TransmissionType = value; }
        }

        [XmlElement("transmission_serial_number")]
        public int TransmissionSerialNumber
        {
            get { return Transmission.TransmissionSerialNumber; }
            set { Transmission.TransmissionSerialNumber = value; }
        }
    }
}

