using System;
namespace Flying_objects
{
    public class Bird : FlyingObject, IFlyable
    {
        private string birdName;
        private int birdSpeed;

        public Bird(string birdName, Coordinates CurrentPosition)
        {
            this.BirdName = birdName;
            this.CurrentPosition = CurrentPosition;

            // I moved BirdSpeed from the GetFlyTime method to the constructor of a Bird
            // Now birdspeed is set randomly (between 1 and 20) while creating an instance of a Bird class
            // and don't change every time the method is called

            Random rnd = new Random();
            this.BirdSpeed = rnd.Next(1, 21);
        }

        public string BirdName { get; set; }
        public int BirdSpeed { get; }

        // FlyTo method is interactive (user can input coordinates through the console)
        public Coordinates FlyTo(int X = 0, int Y = 0, int Z = 0)
        {
            Console.WriteLine($"At the moment the bird {this.BirdName} is at the location with following coordinates - {CurrentPosition.X}, {CurrentPosition.Y}, {CurrentPosition.Z}.");

            if (X == 0)
            {
                Console.WriteLine($"\nYou decided to make it fly to a new destination." +
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

            // Setting restriction on distance. Our bird wouldn't fly more than 50 km
            if (distance > 50)
            {
                Console.WriteLine($"The bird cannot fly thus far! It will get exhausted!\nIts maximum flying distance is 50 km. But you are trying to make it fly {distance} km away!\nSo, please, set a new destination.");
            }
            else
            {
                this.CurrentPosition.X = this.NewPosition.X;
                this.CurrentPosition.Y = this.NewPosition.Y;
                this.CurrentPosition.Z = this.NewPosition.Z;
                Console.WriteLine($"Great! The bird {this.BirdName} has just flown away to a new place with following coordinates - {CurrentPosition.X}, {CurrentPosition.Y}, {CurrentPosition.Z}.\n");
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

            if (distance > 50)
            {
                Console.WriteLine($"We remind you that maximum flying distance of a bird is 50 km." +
                    $"\nThe distance to the destination that you defined is {distance} km away!" +
                    $"\nSo, you will have to change the destination if you want to move the bird.\n");
            }
            else
            {
                // Calculating flytime in minutes
                double flyTime = distance / this.BirdSpeed * 60;
                flyTime = Math.Round(flyTime, 2);
                Console.WriteLine($"The distance from the current position of the bird {this.BirdName} (coordinates are {CurrentPosition.X}, {CurrentPosition.Y}, {CurrentPosition.Z}) to the new place with coordinates ({Destination.X}, {Destination.Y}, {Destination.Z}) is {distance} km." +
                    $"\nIt will take {this.BirdName} {flyTime} minutes to fly to this place with the speed of {this.BirdSpeed} km/h.\n");
            }
        }
    }
}

