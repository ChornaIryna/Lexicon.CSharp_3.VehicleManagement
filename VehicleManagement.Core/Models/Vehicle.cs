namespace VehicleManagement.Core.Models;

public abstract class Vehicle
{
    private string brand = string.Empty;
    private string model = string.Empty;
    private int year;
    private double weight;

    public string Brand { 
        get => brand;
        set 
        {
            if (value.Length < 2 || value.Length > 20)
            {
                throw new ArgumentException("Brand must be between 2 and 20 characters."); 
            }
            brand = value;
        }
    }

    public string Model
    {
        get => model;
        set
        {
            if (value.Length < 2 || value.Length > 20)
                throw new ArgumentException("Model must be between 2 and 20 characters.");
            model = value;
        }
    }

    public int Year
    {
        get => year;
        set
        {
            if (value < 1886 || value > DateTime.Now.Year)
                throw new ArgumentException("Year must be between 1886 and the current year.");
            year = value;
        }
    }

    public double Weight
    {
        get => weight;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Weight must be a positive value.");
            weight = value;
        }
    }

    public Vehicle(string brand, string model, int year, double weight)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Weight = weight;
    }

    public abstract string StartEngine();
    public abstract string Stats();
}
