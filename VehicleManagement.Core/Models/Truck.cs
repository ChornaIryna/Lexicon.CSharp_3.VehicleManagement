using VehicleManagement.Core.Interfaces;

namespace VehicleManagement.Core.Models;

public class Truck : Vehicle, ICleanable
{
    public double CargoCapacity { get; set; }
    public Truck(string brand, string model, int year, double weight, double cargoCapacity) 
        : base(brand, model, year, weight)
    {
        CargoCapacity = cargoCapacity;
    }
    public override string StartEngine()
    {
        return "Truck engine started. 🚚";
    }
    public override string Stats()
    {
        return $"Truck: {Brand} {Model}, Year: {Year}, Weight: {Weight}kg, Cargo Capacity: {CargoCapacity}kg";
    }
    public string Clean()
    {
        return "Use Truck Washing Service.";
    }
}
