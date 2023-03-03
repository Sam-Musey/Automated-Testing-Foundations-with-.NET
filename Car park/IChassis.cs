using System;
namespace Car_park
{
    public interface IChassis
    {
        public int WheelsNumber { get; set; }
        public int PermissibleLoad { get; set; }
        public int Number { get; set; }

    }
}

