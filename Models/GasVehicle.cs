namespace Garage
{
    public class GasVehicle : Vehicle, IFuelable
    {
        public double FuelCapacity { get; set; }
        public double gasLevel = 0;

        public void RefuelTank()
        {
            gasLevel = FuelCapacity;
        }

        public GasVehicle(double fuelCap)
        {
            FuelCapacity = fuelCap;
        }

        public GasVehicle(double fuelCap, double gasLev)
        {
            FuelCapacity = fuelCap;
            gasLevel = gasLev;
        }
    }
}