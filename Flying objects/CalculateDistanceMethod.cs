using System;
namespace Flying_objects
{
    public class CalculateDistanceMethod
    {
        public static double distanceToNewDestination;

        public double CalculateDistance(Coordinates CurrentPosition, Coordinates Destination)
        {
            Destination.X = int.Parse(Console.ReadLine());
            Destination.Y = int.Parse(Console.ReadLine());
            Destination.Z = int.Parse(Console.ReadLine());

            // Calculating the distance between a new destination and the current position
            // The formula is: √((x2 - x1)^2 + (y2 - y1)^2 + (z2 - z1)^2)
            distanceToNewDestination =
                (Math.Sqrt(
                (Destination.X - CurrentPosition.X) * (Destination.X - CurrentPosition.X)
                +
                (Destination.Y - CurrentPosition.Y) * (Destination.Y - CurrentPosition.Y)
                +
                (Destination.Z - CurrentPosition.Z) * (Destination.Z - CurrentPosition.Z)
                ));

            distanceToNewDestination = Math.Round(distanceToNewDestination, 2);
            return distanceToNewDestination;
        }

        public double CalculateDistance(Coordinates CurrentPosition, Coordinates Destination, int X, int Y, int Z)
        {
            Destination.X = X;
            Destination.Y = Y;
            Destination.Z = Z;

            distanceToNewDestination =
                (Math.Sqrt(
                (Destination.X - CurrentPosition.X) * (Destination.X - CurrentPosition.X)
                +
                (Destination.Y - CurrentPosition.Y) * (Destination.Y - CurrentPosition.Y)
                +
                (Destination.Z - CurrentPosition.Z) * (Destination.Z - CurrentPosition.Z)
                ));

            distanceToNewDestination = Math.Round(distanceToNewDestination, 2);
            return distanceToNewDestination;
        }
    }
}

