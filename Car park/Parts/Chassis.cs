using System;
namespace Car_park
{
    public class Chassis
    {
        public int WheelsNumber { get; set; }
        public int PermissibleLoad { get; set; }
        public int ChassisNumber { get; set; }

        public Chassis(int wheelsNumber, int permissibleLoad, int chassisNumber)
        {
            this.WheelsNumber = wheelsNumber;
            this.PermissibleLoad = permissibleLoad;
            this.ChassisNumber = chassisNumber;
        }
    }
}

