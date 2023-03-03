using System;
namespace Flying_objects
{
	public class Bird
    {
        public string birdName;
        public int[] birdPosition = new int[3];

		public string BirdName { get; set; }
        public int[] BirdPosition { get; set; }

        public Bird(string birdName, int[] birdPosition)
		{
			this.BirdName = birdName;
			this.BirdPosition = birdPosition;
		}

		// --- Implementing FlyTo method ---

		public int[] FlyTo(int[] newDestination)
		{
			int[] birdPosition = newDestination;
            string birdPositionString;
            birdPositionString = birdPosition[0].ToString() + ", " + birdPosition[1].ToString() + ", " + birdPosition[2].ToString();

            Console.WriteLine($"The bird {this.BirdName} flew away to a new place with following coordinates - {birdPositionString}.");
			return birdPosition;
        }

        // --- Implementing GetFlyTime method ---

        public double GetFlyTime(int[] newDestination)
        {
            // Setting randomly the speed of a bird (between 1 and 20)
            Random rnd = new Random();
            int birdSpeed = rnd.Next(1, 21);

            // Converting array (where 3 coordinates are stored) to a string, so that we can print the position of a bird and a destination
            string birdPositionString;
            birdPositionString = this.BirdPosition[0].ToString() + ", " + this.BirdPosition[1].ToString() + ", " + this.BirdPosition[2].ToString();
            string newDestinationString;
            newDestinationString = newDestination[0].ToString() + ", " + newDestination[1].ToString() + ", " + newDestination[2].ToString();

            // Calculating the distance between a new destination and the current position of a bird
            double distanceToNewDestination =
            (Math.Sqrt(
                (newDestination[0] - this.BirdPosition[0]) * (newDestination[0] - this.BirdPosition[0])
                +
                (newDestination[1] - this.BirdPosition[1]) * (newDestination[1] - this.BirdPosition[1])
                +
                (newDestination[2] - this.BirdPosition[2]) * (newDestination[2] - this.BirdPosition[2])
                ));

            distanceToNewDestination = Math.Round(distanceToNewDestination, 2);

            // Setting restriction on distance. Our bird wouldn't fly more than 50 km
            if  (distanceToNewDestination > 50)
            {
                Console.WriteLine($"The bird cannot fly thus far! It will get exhausted!\nIts maximum flying distance is 50 km. But you are trying to make it fly {distanceToNewDestination} km away!\nSo, please, set new destination.");
                return distanceToNewDestination;
                //throw new ArgumentOutOfRangeException(nameof(distanceToNewDestination), "The bird cannot fly thus far! It will get exhausted! Its maximum flying distance is 50 km.");
            }

            // Calculating flytime in minutes
            double flyTime = distanceToNewDestination / birdSpeed * 60;
            flyTime = Math.Round(flyTime, 2);

            // Outputting the information about speed and flytime
            Console.WriteLine($"The distance from the current position of the bird {this.BirdName} (coordinates are {birdPositionString}) to the new place with coordinates ({newDestinationString}) is {distanceToNewDestination} kms.\n" +
            $"It will take {this.BirdName} {flyTime} minutes to fly to this place with the speed of {birdSpeed} km/h.");

            return flyTime;
        }



    }
}

