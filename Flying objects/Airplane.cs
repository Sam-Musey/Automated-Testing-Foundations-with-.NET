using System;
namespace Flying_objects
{
    public class Airplane
    {
        public string airplaneName;
        public int[] airplanePosition = new int[3];

        public string AirplaneName { get; set; }
        public int[] AirplanePosition { get; set; }
         
        public Airplane(string airplaneName, int[] airplanePosition)
        {
            this.AirplaneName = airplaneName;
            this.AirplanePosition = airplanePosition;
        }

        // --- Implementing FlyTo method ---

        public int[] FlyTo(int[] newDestination)
        {
            int[] airplanePosition = newDestination;
            string airplanePositionString;
            airplanePositionString = airplanePosition[0].ToString() + ", " + airplanePosition[1].ToString() + ", " + airplanePosition[2].ToString();

            Console.WriteLine($"The airplane {this.AirplaneName} arrived to a new place with following coordinates - {airplanePositionString}.");
            //Console.WriteLine(airplanePosition);
            return airplanePosition;
        }

        // --- Implementing GetFlyTime method ---

        public double GetFlyTime(int[] newDestination)
        {
            // Converting array (where 3 coordinates are stored) to a string, so that we can print the position of an airplane and its destination
            string airplanePositionString;
            airplanePositionString = this.AirplanePosition[0].ToString() + ", " + this.AirplanePosition[1].ToString() + ", " + this.AirplanePosition[2].ToString();
            string newDestinationString;
            newDestinationString = newDestination[0].ToString() + ", " + newDestination[1].ToString() + ", " + newDestination[2].ToString();

            // Calculating the distance between a new destination and the current position of an airplane
            double distanceToNewDestination =
            (Math.Sqrt(
                (newDestination[0] - this.AirplanePosition[0]) * (newDestination[0] - this.AirplanePosition[0])
                +
                (newDestination[1] - this.AirplanePosition[1]) * (newDestination[1] - this.AirplanePosition[1])
                +
                (newDestination[2] - this.AirplanePosition[2]) * (newDestination[2] - this.AirplanePosition[2])
                ));

            distanceToNewDestination = Math.Round(distanceToNewDestination, 2);

            // Setting speed of an airplane as 200 km/h
            int airplaneSpeed = 200;

            // Calculating the acceleration of an airplane (using the formula "a = V / t")
            double airplaneAcceleration = 10 / (2.0 / 41);

            // Calculating flytime (in minutes) using formula "S = u*t + 0.5*a*t^2"
            // To calculate t (time) from this formula we have to solve quadratic equation "x = (-b +/- √(b^2 - 4ac)) / 2a"

            double flyTime = (-200 + Math.Sqrt(200*200 - 4 * 0.5 * airplaneAcceleration * (-distanceToNewDestination))) / 205;
            flyTime = Math.Round(flyTime*60, 2);

            // Outputting the information about speed and flytime
            Console.WriteLine($"The distance from the current position of the airplane {this.AirplaneName} (coordinates are {airplanePositionString}) to the new place with coordinates ({newDestinationString}) is {distanceToNewDestination} kms.\n" +
            $"It will take {this.AirplaneName} {flyTime} minutes to get to this place with the speed of {airplaneSpeed} km/h and acceleration {airplaneAcceleration} km/h^2.");

            return flyTime;
        }
    }
}

