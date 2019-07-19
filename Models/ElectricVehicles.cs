namespace Garage
{
    public class ElectricVehicle : Vehicle, IChargeable
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {

        }
    }
}