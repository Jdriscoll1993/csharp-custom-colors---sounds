using System.Collections.Generic;

namespace Garage
{
    public class BatteryStation : IStation<ElectricVehicle>
    {
        public int Capacity { get; set; }
        public void Refuel(List<ElectricVehicle> electricVehicles)
        {
            System.Console.WriteLine("Hey, partner. You're fueling your electric vehicle");
        }


    }
}