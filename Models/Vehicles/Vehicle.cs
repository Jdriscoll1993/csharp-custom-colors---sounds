using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        //this becomes overridden by each vehicle
        public virtual void Drive()
        {
            Console.WriteLine("Vroooom!");
        }

        //this becomes overridden by each vehicle
        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The vehicle starts to take a {direction} turn for the worst :(");
        }
        //this becomes overridden by each vehicle
        public virtual void Stop()
        {
            Console.WriteLine("The vehicle has come to a complete stop");
        }
    }
}