using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vroooom!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The vehicle starts to take a {direction} turn for the worst :(");
        }
        public virtual void Stop()
        {
            Console.WriteLine("The vehicle has come to a complete stop");
        }
    }
}