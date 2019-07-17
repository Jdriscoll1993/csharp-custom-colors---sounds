namespace Garage
{
    public interface IChargeable
    {
        double BatteryKWh { get; set; }
        string MainColor { get; set; }
        string MaximumOccupancy { get; set; }

        void ChargeBattery();
    }
}