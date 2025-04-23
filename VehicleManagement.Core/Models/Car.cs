using VehicleManagement.Core.Interfaces;

namespace VehicleManagement.Core.Models;

public class Car : Vehicle, ICleanable
{
    private int seatingCapacity;

    public int SeatingCapacity
    {
        get => seatingCapacity;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Seating capacity must be a positive value.");
            seatingCapacity = value;
        }
    }

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
        return $"Car: {base.Stats()}, Seating Capacity: {SeatingCapacity}";
    }

    public string Clean()
    {
        return "Cleaning the car with a high-pressure washer.";
    }
}
