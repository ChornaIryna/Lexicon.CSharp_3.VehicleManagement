using VehicleManagement.Core.Models;

namespace VehicleManagement.Core.Data;

public static class PredefinedVehicleData
{
    public static List<Vehicle> GetVehicles()
    {
        return new List<Vehicle>
        {
            new Car("Toyota", "Camry", 2022, 1500, 5),
            new Truck("Ford", "F-150", 2021, 2500, 2500),
            new Motorcycle("Honda", "CBR500R", 2023, 200, false),
            new ElectricScooter("Xiaomi", "Mi Pro", 2024, 15, 45)
        };
    }
}
