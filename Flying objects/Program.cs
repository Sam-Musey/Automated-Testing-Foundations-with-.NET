using System;
using Flying_objects;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here is a little note about what I didn't accomplish in this task
            // I created an interface IFlyable, but somehow when I try make my classes inherit this interface it goes wrong (squiggly red line)

            // Second issue is as follows
            // When I apply FlyTo method to an object, it changes its current position
            // But outside this fuction its current position changes back to its original value
            // Unfortunately I didn't come up with a solution

            // -----------------------------------------------------//
            // Creating an object of a bird and testing its functions

            Console.WriteLine(" --- Testing functions of a bird ---\n");

            Bird birdChayka = new Bird("Chayka", new int[] { 5, 10, 9 });

            birdChayka.FlyTo(new int[] {6, 7, 8});
            birdChayka.GetFlyTime(new int[] { 5, 60, 9 });
            birdChayka.GetFlyTime(new int[] { 6, 61, 8 });
            Console.WriteLine("\n");

            // Creating an object of an airplane and testing its functions

            Console.WriteLine(" --- Testing functions of an airplane ---\n");

            Airplane airplane1 = new Airplane("Airbus 666", new int[] { 10, 10, 10 });
            airplane1.FlyTo(new int[] { 30, 30, 30 });
            airplane1.GetFlyTime(new int[] { 10, 3572, 10 });

            Console.WriteLine("\n");

            // Creating an object of a drone and testing its functions

            Console.WriteLine(" --- Testing functions of a drone ---\n");

            Drone drone1 = new Drone("DJI Mini 3 Pro", new int[] { 10, 10, 10 });

            drone1.FlyTo(new int[] { 10, 65, 10 });
            drone1.GetFlyTime(new int[] { 10, 80, 10 });
            drone1.GetFlyTime(new int[] { 10, 111, 10 });

            Console.ReadKey();
        }
    }
}



