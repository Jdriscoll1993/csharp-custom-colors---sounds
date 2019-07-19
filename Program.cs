using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Electric Powered Rides
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            // List of electric vehicles
            List<ElectricVehicle> electricVehicles = new List<ElectricVehicle>() { fx, modelS };
            electricVehicles.ForEach(ev => ev.ChargeBattery());


            // Gas Powered Rides
            //(fuelCap, gasLev)
            Cessna myCessna = new Cessna(120, 50);
            Ram myRam = new Ram(10, 3);

            Console.WriteLine($"The Ram is entering the fueling station with {myRam.gasLevel} gallons in the tank");
            Console.WriteLine($"The Cessna is entering the fueling station {myCessna.gasLevel} gallons in the tank");


            // List of gas vehicles
            List<GasVehicle> gasVehicles = new List<GasVehicle>() { myCessna, myRam };


            // Battery station instance
            BatteryStation batteryStation = new BatteryStation();


            // Gas station instance and pass the new instance capacity at the gas station
            GasStation gasStation = new GasStation(3);

            // refuel all gas vehicles as the gas station if there is room. Capacity is (3)--see line 37
            if (gasStation.Refuel(gasVehicles) != null)
            {
                Console.WriteLine("Lets Fuel Em Up!");
            }
            else
            {
                Console.WriteLine("Too many vehicles, get the hell out!");
            }




            Console.WriteLine($"The Ram is leaving the fueling station with {myRam.gasLevel} gallons in the tank. Ahhh, a full tank!");
            Console.WriteLine($"The Ram is leaving the fueling station with {myCessna.gasLevel} gallons in the tank. Ahhh, a full tank!");

            // Output
            // System.Console.WriteLine("-------------");
            // myRam.Drive();
            // myRam.Turn("left");
            // myRam.Stop();
            // System.Console.WriteLine("-------------");
            // myCessna.Drive();
            // myCessna.Turn("right");
            // myCessna.Stop();
            // System.Console.WriteLine("-------------");
            // fx.Drive();
            // fx.Turn("right");
            // fx.Stop();
            // System.Console.WriteLine("-------------");
            // modelS.Drive();
            // modelS.Turn("left");
            // modelS.Stop();
            // System.Console.WriteLine("-------------");
        }
    }
}


