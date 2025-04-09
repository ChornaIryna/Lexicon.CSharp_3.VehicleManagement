using VehicleManagement.Core.Interfaces;

namespace VehicleManagement.Core.Models;

public class Car : Vehicle, ICleanable
{
    public int SeatingCapacity { get; set; }
    public Car(string brand, string model, int year, double weight, int seatingCapacity) 
        : base(brand, model, year, weight)
    {
        SeatingCapacity = seatingCapacity;
    }
    public override string StartEngine()
    {
        return "Car engine started. 🚗";
    }

    public override string Stats()
    {
        return $"Car: {Brand} {Model}, Year: {Year}, Weight: {Weight}kg, Seating Capacity: {SeatingCapacity}";
    }

    public string Clean()
    {
        return "Cleaning the car with a high-pressure washer.";
    }
}
