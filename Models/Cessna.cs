using System;

namespace Garage
{
    public class Cessna : Vehicle, IFueable
    {  // Propellor light aircraft
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            Console.WriteLine("Gasin' muh Cessna");
        }
        public override void Drive()
        {
            Console.WriteLine("Zoooom in mah cessna!");
        }
    }
}