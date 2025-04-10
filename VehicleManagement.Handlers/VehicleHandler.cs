using System.Text;
using VehicleManagement.Core.Enums;
using VehicleManagement.Core.Interfaces;
using VehicleManagement.Core.Models;

namespace VehicleManagement.Handlers;
public class VehicleHandler
{
    private readonly List<Vehicle> vehicles = new();

    public void CreateVehicle( Vehicle vehicle)
    {
        if (vehicle is null)
        {
            throw new ArgumentException("Vehicle cannot be null.");
        }
        vehicles.Add(vehicle);

    }
    public Vehicle CreateVehicle(string brand, string model, int year, double weight, VehicleType vehicleType, object additionalInfo)
    {
        return vehicleType switch
        {
            VehicleType.Car => new Car(brand, model, year, weight, (int)additionalInfo),
            VehicleType.Truck => new Truck(brand, model, year, weight, (double)additionalInfo),
            VehicleType.Motorcycle => new Motorcycle(brand, model, year, weight, (bool)additionalInfo),
            VehicleType.ElectricScooter => new ElectricScooter(brand, model, year, weight, (int)additionalInfo),
            _ => throw new ArgumentException("Invalid vehicle type.")
        };
    }

    public void UpdateVehicleWeight(int index, double newWeight)
    {
        try
        {
            vehicles[index].Weight = newWeight;
        }
        catch (ArgumentOutOfRangeException ex)
        {
            throw new ArgumentException($"Invalid vehicle index. {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            throw new ArgumentException($"Error updating weight: {ex.Message}");
        }
    }

    public string ListVehicles()
    {
        if (vehicles.Count == 0)
        {
            return "No vehicles to list.";
        }

        StringBuilder vehicleList = new StringBuilder();

        foreach (var vehicle in vehicles)
        {
            vehicleList.AppendLine();
            vehicleList.AppendLine($"{vehicle.Stats()}");
            vehicleList.AppendLine($"Start Engine: {vehicle.StartEngine()}");
            if (vehicle is ICleanable cleanableVehicle)
            {
                vehicleList.AppendLine($"Cleaning: {cleanableVehicle.Clean()}");
            }
        }
        return vehicleList.ToString();
    }

    public bool IsVehicleListEmpty()
    {
        return vehicles.Count == 0;
    }
}
