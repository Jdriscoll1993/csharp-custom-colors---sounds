using System;

namespace Garage
{
    public class Cessna : GasVehicle
    {  // Propellor light aircraft
        public override void Drive()
        {
            Console.WriteLine("Zoooom in mah cessna!");
        }

        public override void Turn(string direction)
        {
            System.Console.WriteLine("this we want this");
        }

        // pass paramters of the constructor of derived class (Cessna) to constructor of the base class (GasVehicle) with accessor Method(type param): base(param)
        public Cessna(double fuelCap) : base(fuelCap) { }
        // accessor Method(type param1, type param2) : base(parm1, param2)
        public Cessna(double fuelCap, double gasLev) : base(fuelCap, gasLev) { }
    }
}