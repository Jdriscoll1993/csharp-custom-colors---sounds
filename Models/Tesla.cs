using System;

namespace Garage
{
    public class Tesla : Vehicle, IChargeable
    {  // Electric car
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("Charging my tesla");
        }
        public override void Drive()
        {
            Console.WriteLine("My tesla make no sound!...but we drivin'");
        }
    }
}