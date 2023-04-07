using System;
using Flying_objects;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an three objects of our classes (Airplane, Bird, Drone)

            Airplane airplane1 = new Airplane("Airbus 666", new Coordinates(10, 12, 13));
            Bird bird1 = new Bird("Owl", new Coordinates(3, 9, 11));
            Drone drone1 = new Drone("DJI Mini 3 Pro", new Coordinates(22, 33, 44));

            // Testing FlyTo and GetFlyTime methods

            airplane1.FlyTo(55, 54, 96);
            airplane1.GetFlyTime(3000, 70, 80);

            bird1.FlyTo(23, 24, 25);
            bird1.GetFlyTime(34, 45, 56);

            drone1.FlyTo(40, 55, 77);
            drone1.GetFlyTime(75, 45, 15);

            // Please, test FlyTo method with your own parameters through console

            airplane1.FlyTo();
            //bird1.FlyTo();
            //drone1.FlyTo();

            Console.ReadKey();
        }
    }
}



