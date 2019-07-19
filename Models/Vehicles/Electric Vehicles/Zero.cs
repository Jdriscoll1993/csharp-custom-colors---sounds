using System;

namespace Garage
{
    public class Zero : ElectricVehicle
    {  // Electric motorcycle

        public override void Drive()
        {
            System.Console.WriteLine($"Im driving {MainColor} so fast in my zoom zoom");
        }

        public override void Turn(string direction)
        {
            System.Console.WriteLine($"We're rolling deep with the cats and we are about to take a {direction} turn");
        }
    }
}