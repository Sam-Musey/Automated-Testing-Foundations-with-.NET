using System;
namespace Flying_objects
{
    public interface IFlyable
    {
        Coordinates FlyTo(int X, int Y, int Z);
        void GetFlyTime(int X, int Y, int Z);
    }
}

