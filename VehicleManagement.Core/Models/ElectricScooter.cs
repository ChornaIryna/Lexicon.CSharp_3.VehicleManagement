namespace VehicleManagement.Core.Models;

public class ElectricScooter : Vehicle
{
    private int batteryRange;
    public int BatteryRange
    {
        get => batteryRange;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Battery range must be a positive value.");
            batteryRange = value;
        }
    }

    public ElectricScooter(string brand, string model, int year, double weight, int batteryRange)
        : base(brand, model, year, weight)
    {
        BatteryRange = batteryRange;
    }

    public override string StartEngine()
    {
        return "Electric scooter engine started. 🛴";
    }

    public override string Stats()
    {
        return $"Electric Scooter: {base.Stats()}, Battery Range: {BatteryRange}km";
    }
}
