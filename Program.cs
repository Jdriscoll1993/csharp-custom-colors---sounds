using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            /*
                This can only hold individual motorcycles. You can't
                add the Tesla to this list. It's a different type.
                This is invalid code. The `modelS` is not of type Zero.
            */
            List<IChargeable> electricVehicles = new List<IChargeable>() { fx, modelS };

            electricVehicles.ForEach(ev => ev.ChargeBattery());

            Cessna myCessna = new Cessna();
            Ram myRam = new Ram();

            List<IFueable> gasVehicles = new List<IFueable>()
            {myCessna, myRam};

            gasVehicles.ForEach(gv => gv.RefuelTank());
            System.Console.WriteLine("-------------");
            myRam.Drive();
            myRam.Turn("left");
            myRam.Stop();
            System.Console.WriteLine("-------------");
            myCessna.Drive();
            myCessna.Turn("right");
            myCessna.Stop();
            System.Console.WriteLine("-------------");
            fx.Drive();
            fx.Turn("right");
            fx.Stop();
            System.Console.WriteLine("-------------");
            modelS.Drive();
            modelS.Turn("left");
            modelS.Stop();
            System.Console.WriteLine("-------------");
        }
    }
}


