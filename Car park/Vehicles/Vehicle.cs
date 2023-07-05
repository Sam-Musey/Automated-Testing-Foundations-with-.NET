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
            get
            {
                if (Engine.Power > 0)
                    return Engine.Power;
                else
                    throw new Exception("The power of an engine can not be negative or equal to 0.");
            }

            set
            {
                if (Engine.Power > 0)
                    Engine.Power = value;
                else
                    throw new Exception("The power of an engine can not be negative or equal to 0.");
            }
        }

        public float EngineVolume
        {
            get
            {
                if (Engine.Volume > 0)
                    return Engine.Volume;
                else
                    throw new Exception("The volume of an engine can not be negative or equal to 0.");
            }

            set
            {
                if (Engine.Volume > 0)
                    Engine.Volume = value;
                else
                    throw new Exception("The volume of an engine can not be negative or equal to 0.");
            }
        }

        public string EngineType
        {
            get { return Engine.EngineType; }
            set { Engine.EngineType = value; }
        }

        public int EngineSerialNumber
        {
            get
            {
                if (Engine.EngineSerialNumber.ToString().Length == 9)
                    return Engine.EngineSerialNumber;
                else
                    throw new Exception("The serial number of an engine should be 9 digits long.");
            }

            set
            {
                if (Engine.EngineSerialNumber.ToString().Length == 9)
                    Engine.EngineSerialNumber = value;
                else
                    throw new Exception("The serial number of an engine should be 9 digits long.");
            }
        }

        // Properties of Chassis class

        public int WheelsNumber
        {
            get
            {
                if (Chassis.WheelsNumber > 0 && Chassis.WheelsNumber <= 12)
                    return Chassis.WheelsNumber;
                else
                    throw new Exception("A vehicle must have a wheel count greater than 0 and less than or equal to 12.");
            }

            set
            {
                if (Chassis.WheelsNumber >= 0 && Chassis.WheelsNumber <= 12)
                    Chassis.WheelsNumber = value;
                else
                    throw new Exception("A vehicle must have a wheel count greater than 0 and less than or equal to 12.");
            }
        }

        public int PermissibleLoad
        {
            get
            {
                if (Chassis.PermissibleLoad > 0)
                    return Chassis.PermissibleLoad;
                else
                    throw new Exception("Permissible load of a vehicle must be a possitive number.");
            }

            set
            {
                if (Chassis.PermissibleLoad > 0)
                    Chassis.PermissibleLoad = value;
                else
                    throw new Exception("Permissible load of a vehicle must be a possitive number.");
            }
        }

        public int ChassisNumber
        {
            get
            {
                if (Chassis.ChassisNumber.ToString().Length == 8)
                    return Chassis.ChassisNumber;
                else
                    throw new Exception("The serial number of a chassis should be 8 digits long.");
            }

            set
            {
                if (Chassis.ChassisNumber.ToString().Length == 8)
                    Chassis.ChassisNumber = value;
                else
                    throw new Exception("The serial number of an chassis should be 8 digits long.");
            }
        }

        // Properties of Transmission class

        public int NumberOfGears
        {
            get
            {
                if (Transmission.NumberOfGears > 0)
                    return Transmission.NumberOfGears;
                else
                    throw new Exception("Number of gears can not be negative.");
            }

            set
            {
                if (Transmission.NumberOfGears > 0)
                    Transmission.NumberOfGears = value;
                else
                    throw new Exception("Number of gears can not be negative.");
            }
        }

        public string Manufacturer
        {
            get
            {
                if (string.IsNullOrEmpty(Transmission.Manufacturer))
                    throw new Exception("The transmission manufacturer can not be empty");
                else
                    return Transmission.Manufacturer;
            }

            set
            {
                if (string.IsNullOrEmpty(Transmission.Manufacturer))
                    throw new Exception("The transmission manufacturer can not be empty");
                else
                    Transmission.Manufacturer = value;
            }
        }

        public string TransmissionType
        {
            get { return Transmission.TransmissionType; }
            set { Transmission.TransmissionType = value; }
        }

        public int TransmissionSerialNumber
        {
            get
            {
                if (Transmission.TransmissionSerialNumber.ToString().Length == 7)
                    return Transmission.TransmissionSerialNumber;
                else
                    throw new Exception("The serial number of a transmission should be 7 digits long.");
            }

            set
            {
                if (Transmission.TransmissionSerialNumber.ToString().Length == 7)
                    Transmission.TransmissionSerialNumber = value;
                else
                    throw new Exception("The serial number of a transmission should be 7 digits long.");
            }
        }
    }
}

