namespace Garage
{
    public interface IFuelable
    {
        double FuelCapacity { get; set; }
        void RefuelTank();


    }
}