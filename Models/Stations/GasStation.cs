using System.Collections.Generic;

namespace Garage
{
    public class GasStation : IStation<GasVehicle>
    {
        public int Capacity { get; set; }
        public List<GasVehicle> Refuel(List<GasVehicle> GasVehciles)
        {


            if (GasVehciles.Count <= Capacity)
            {
                System.Console.WriteLine("Hey, guy. Gas fuel for the takin' pal.");

                GasVehciles.ForEach(gv =>
                {
                    gv.RefuelTank();
                });

                return GasVehciles;
            }
            else
            {

                return null;

            }


        }

        void IStation<GasVehicle>.Refuel(List<GasVehicle> vehicles)
        {
        }

        public GasStation(int capacity)
        {
            Capacity = capacity;
        }
    }
}