using System;
using System.Text;

namespace Flying_objects
{
    public class Drone : FlyingObject, IFlyable
    {
        private int droneSpeed = 35;
        private string droneName;

        public Drone(string droneName, Coordinates CurrentPosition)
        {
            this.DroneName = droneName;
            this.CurrentPosition = CurrentPosition;
        }

        public int DroneSpeed
        {
            get { return droneSpeed; }
        }
        public string DroneName { get; set; }

        // FlyTo method is interactive (user can input coordinates through the console)
        public Coordinates FlyTo(int X = 0, int Y = 0, int Z = 0)
        {
            Console.WriteLine($"At the moment the drone {this.DroneName} is at the location with following coordinates - {CurrentPosition.X}, {CurrentPosition.Y}, {CurrentPosition.Z}.");

            if (X == 0)
            {
                Console.WriteLine($"You decided to make it fly to a new destination." +
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

            if (distance > 100)
            {
                Console.WriteLine($"The drone cannot fly thus far! It will run out of battery!\nIts maximum flying distance is 100 km. But you are trying to make it fly {distance} km away!\nSo, please, set a new destination.");
            }

            else
            {
                this.CurrentPosition.X = this.NewPosition.X;
                this.CurrentPosition.Y = this.NewPosition.Y;
                this.CurrentPosition.Z = this.NewPosition.Z;
                Console.WriteLine($"Great! The drone {this.DroneName} has just been moved to a new place with following coordinates - {CurrentPosition.X}, {CurrentPosition.Y}, {CurrentPosition.Z}.\n");
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

            if (distance > 100)
            {
                Console.WriteLine($"We remind you that maximum flying distance of a drone is 100 km." +
                    $"\nThe distance to the destination that you defined is {distance} km away!" +
                    $"\nSo, you will have to change the destination if you want to move the drone.\n");
            }
            else
            {
                // Calculating flytime in minutes
                double flyTime = distance / droneSpeed * 60;
                flyTime = Math.Round(flyTime, 2);

                // Drone hovers in the air every 10 minutes of flight for 1 minute. So we should compensate this factor
                // My logic for compensation is following
                // A drone flies for 10 mins and then stops and hovers for 1 min
                // So for every 10 mins we have to add 1 min. But if flytime is divisible by 10, we do not have to add another 1 min
                // E.g. flytime is 60 mins.
                // In this example we should compensate only 5 mins because a drone will hover only 5 times, it doesn't have to hover for the 6th time.
                // But if flytime is 61 mins, a drone will hovers 6 times, so we should add 6 more minutes to flytime.

                int compensatingTime;
                if (flyTime % 10 == 0)
                {
                    compensatingTime = (int)(flyTime / 10 - 1);
                }
                else
                {
                    compensatingTime = (int)(flyTime / 10);
                }

                flyTime += compensatingTime;
                flyTime = Math.Round(flyTime, 2);

                Console.WriteLine($"The distance from the current position of the drone {this.DroneName} (coordinates are {CurrentPosition.X}, {CurrentPosition.Y}, {CurrentPosition.Z}) to the new place with coordinates ({Destination.X}, {Destination.Y}, {Destination.Z}) is {distance} km.\n" +
                    $"It will take {this.DroneName} {flyTime} minutes to fly to this place with the speed of {this.DroneSpeed} km/h.\n");
            }
        }
    }
}

