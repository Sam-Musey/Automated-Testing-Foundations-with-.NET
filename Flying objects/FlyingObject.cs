using System;
namespace Flying_objects
{
    public class FlyingObject
    {
        public Coordinates CurrentPosition;
        public Coordinates Destination;
        public Coordinates NewPosition;

        public CalculateDistanceMethod calculateDistance = new CalculateDistanceMethod();

        // Two implementations of CalculateDistance method from CalculateDistanceMethod class
        // This method overloading allows setting coordinates either through user interface (in console) or beforehand in program

        public void CalculateDistance()
        {
            calculateDistance.CalculateDistance(CurrentPosition, Destination);
        }

        public double CalculateDistance(int X, int Y, int Z)
        {
            Destination.X = X;
            Destination.Y = Y;
            Destination.Z = Z;
            calculateDistance.CalculateDistance(CurrentPosition, Destination, Destination.X, Destination.Y, Destination.Z);
            return CalculateDistanceMethod.distanceToNewDestination;
        }
    }
}

