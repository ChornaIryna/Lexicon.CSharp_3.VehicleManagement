namespace VehicleManagement.Core.Models;

public class ElectricScooter : Vehicle
{
    public int BatteryRange { get; set; }
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
        return $"Electric Scooter: {Brand} {Model}, Year: {Year}, Weight: {Weight}kg, Battery Range: {BatteryRange}km";
    }
}
