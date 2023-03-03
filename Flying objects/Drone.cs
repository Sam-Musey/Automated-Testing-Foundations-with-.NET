using System;
using System.Text;

namespace Flying_objects
{
	public class Drone
    {
        public string droneModel;
        public int[] dronePosition = new int[3];

        public string DroneModel { get; set; }
        public int[] DronePosition { get; set; }

        public Drone(string droneModel, int[] dronePosition)
        {
            this.DroneModel = droneModel;
            this.DronePosition = dronePosition;
        }

        // --- Implementing FlyTo method ---

        public int[] FlyTo(int[] newDestination)
        {
            int[] dronePosition = newDestination;
            string dronePositionString;
            dronePositionString = dronePosition[0].ToString() + ", " + dronePosition[1].ToString() + ", " + dronePosition[2].ToString();

            Console.WriteLine($"The drone {this.DroneModel} flew away to a new place with following coordinates - {dronePositionString}.");
            return dronePosition;
        }

        // --- Implementing GetFlyTime method ---

        public double GetFlyTime(int[] newDestination)
        {
            // Setting the speed of a drone at 35 km/h
            int droneSpeed = 35;

            // Converting array (where 3 coordinates are stored) to a string, so that we can print the position of a drone and a destination
            string dronePositionString;
            dronePositionString = this.DronePosition[0].ToString() + ", " + this.DronePosition[1].ToString() + ", " + this.DronePosition[2].ToString();
            string newDestinationString;
            newDestinationString = newDestination[0].ToString() + ", " + newDestination[1].ToString() + ", " + newDestination[2].ToString();

            // Calculating the distance between a new destination and the current position of a drone
            double distanceToNewDestination =
            (Math.Sqrt(
                (newDestination[0] - this.DronePosition[0]) * (newDestination[0] - this.DronePosition[0])
                +
                (newDestination[1] - this.DronePosition[1]) * (newDestination[1] - this.DronePosition[1])
                +
                (newDestination[2] - this.DronePosition[2]) * (newDestination[2] - this.DronePosition[2])
                ));

            distanceToNewDestination = Math.Round(distanceToNewDestination, 2);

            // Setting restriction on distance. The drone can not fly more than 100 km without recharging
            if (distanceToNewDestination > 100)
            {
                Console.WriteLine($"The drone cannot fly thus far! It will run out of battery!\nIts maximum flying distance is 100 km. But you are trying to make it fly {distanceToNewDestination} km away!\nSo, please, set a new destination.");
                return distanceToNewDestination;
            }

            // Calculating flytime in minutes
            double flyTime = distanceToNewDestination / droneSpeed * 60;
            flyTime = Math.Round(flyTime, 2);

            // Drone hovers in the air every 10 minutes of flight for 1 minute. So we should compensate this factor
            int compensatingTime;
            if (flyTime%10 == 0)
            {
                compensatingTime = (int)(flyTime / 10 - 1);
            }
            else
            {
                compensatingTime = (int)(flyTime / 10);
            }

            flyTime = flyTime + compensatingTime;

            // Outputting the information about speed and flytime
            Console.WriteLine($"The distance from the current position of the drone " +
                $"{this.DroneModel} (coordinates are {dronePositionString}) to the new place with coordinates ({newDestinationString}) is {distanceToNewDestination} kms.\n" +
            $"It will take {this.DroneModel} {flyTime} minutes to fly to this place with the speed of {droneSpeed} km/h.");

            return flyTime;
        }
    }
}

