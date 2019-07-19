using System;
using System.Collections.Generic;

namespace Garage
{
    public class Ram : GasVehicle
    {  // Gas powered truck
        public override void Drive()
        {
            System.Console.WriteLine("weeeee in my Ram truck!");
        }
        public override void Turn(string direction)
        {
            System.Console.WriteLine($"taking a {direction} turn in the Rambo");
        }


        // pass paramters of the constructor of derived class (Ram) to constructor of the base class (GasVehicle) with accessor Method(type param): base(param)
        public Ram(double fuelCap) : base(fuelCap)
        {

        }
        // accessor Method(type param1, type param2) : base(parm1, param2)
        public Ram(double fuelCap, double gasLev) : base(fuelCap, gasLev)
        {

        }

    }
}