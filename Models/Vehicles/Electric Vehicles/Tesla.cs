using System;

namespace Garage
{
    public class Tesla : ElectricVehicle
    {  // Electric car
        public override void Drive()
        {
            Console.WriteLine("My tesla make no sound!...but we drivin'");
        }
    }
}