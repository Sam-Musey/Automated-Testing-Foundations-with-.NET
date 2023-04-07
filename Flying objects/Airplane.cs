using System;
namespace Flying_objects
{
    public class Airplane : FlyingObject, IFlyable
    {
        private int airplaneSpeed = 200;
        private string airplaneName;

        public Airplane(string airplaneName, Coordinates CurrentPosition)
        {
            this.AirplaneName = airplaneName;
            this.CurrentPosition = CurrentPosition;
        }

        public int AirplaneSpeed
        {
            get { return airplaneSpeed; }
        }
        public string AirplaneName { get; set; }

        // FlyTo method is interactive (user can input coordinates through the console)
        public Coordinates FlyTo(int X = 0, int Y = 0, int Z = 0)
        {
            Console.WriteLine($"At the moment the airplane {this.AirplaneName} is at the location with following coordinates - {CurrentPosition.X}, {CurrentPosition.Y}, {CurrentPosition.Z}.");
            if (X == 0)
            {
                Console.WriteLine("\nYou decided to make it fly to a new destination." +
                    "\nPlease enter three coordinates of the desired location." +
                    "\n-> The X coordinate will be: ");
                X = int.Parse(Console.ReadLine());
                this.NewPosition.X = X;
            }
            else this.NewPosition.X = X;

            if (Y == 0)
            {
                Console.WriteLine("-> The Y coodinate will be: ");
                Y = int.Parse(Console.ReadLine());
                this.NewPosition.Y = Y;
            }
            else this.NewPosition.Y = Y;

            if (Z == 0)
            {
                Console.WriteLine("-> The Z coordinate will be: ");
                Z = int.Parse(Console.ReadLine());
                this.NewPosition.Z = Z;
            }
            else this.NewPosition.Z = Z;

            double distance = CalculateDistance(NewPosition.X, NewPosition.Y, NewPosition.Z);

            if (distance > 6000)
            {
                Console.WriteLine($"The maximum range of an airplane is 6000 km. " +
                    $"\nThe distance to the destination that you defined is {distance} km away!" +
                    $"\nSo, please, set a new destination.");
            }
            else
            {
                this.CurrentPosition.X = this.NewPosition.X;
                this.CurrentPosition.Y = this.NewPosition.Y;
                this.CurrentPosition.Z = this.NewPosition.Z;
                Console.WriteLine($"Great! The airplane {this.AirplaneName} has just arrived to a new place with following coordinates - {CurrentPosition.X}, {CurrentPosition.Y}, {CurrentPosition.Z}.\n");
            }
            return CurrentPosition;
        }

        // GetFlyTime is not interactive
        public void GetFlyTime(int X, int Y, int Z)
        {
            this.NewPosition.X = X;
            this.NewPosition.Y = Y;
            this.NewPosition.Z = Z;

            double distance = CalculateDistance(NewPosition.X, NewPosition.Y, NewPosition.Z);

            if (distance > 6000)
            {
                Console.WriteLine($"We remind you that maximum range of an airplane is 6000 km." +
                    $"\nThe distance to the destination that you defined is {distance} km away!" +
                    $"\nSo, you will have to change the destination if you want to move the airplane.\n");
            }
            else
            {
                // Calculating the acceleration of an airplane (using the formula "a = V / t")
                double airplaneAcceleration = 10 / (2.0 / 41);

                // Calculating flytime (in minutes) using formula "S = u*t + 0.5*a*t^2"
                // To calculate t (time) from this formula we have to solve quadratic equation "x = (-b +/- √(b^2 - 4ac)) / 2a"

                double flyTime = (-200 + Math.Sqrt(200 * 200 - 4 * 0.5 * airplaneAcceleration * (-distance))) / 205;
                flyTime = Math.Round(flyTime * 60, 2);

                Console.WriteLine($"The distance from the current position of the airplane {this.AirplaneName} (coordinates are {CurrentPosition.X}, {CurrentPosition.Y}, {CurrentPosition.Z}) to the new place with coordinates ({Destination.X}, {Destination.Y}, {Destination.Z}) is {distance} km.\n" +
                    $"It will take {this.AirplaneName} {flyTime} minutes to get to this place with the speed of {this.AirplaneSpeed} km/h and acceleration {airplaneAcceleration} km/h^2.\n");
            }
        }
    }
}

