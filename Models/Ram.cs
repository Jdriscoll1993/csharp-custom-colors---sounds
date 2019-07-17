using System;

namespace Garage
{
    public class Ram : Vehicle, IFueable
    {  // Gas powered truck
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            Console.WriteLine("Gasin' up my Ram");
        }
        public override void Drive()
        {
            System.Console.WriteLine("weeeee in my Ram truck!");
        }
    }
}