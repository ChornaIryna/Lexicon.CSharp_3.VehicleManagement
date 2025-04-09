using VehicleManagement.Core.Enums;
using VehicleManagement.Core.Errors;
using VehicleManagement.Core.Models;
using VehicleManagement.Handlers;

namespace VehicleManagement;

internal class UserInterface
{
    private bool _isApplicationRunning = true;
    private readonly VehicleHandler _vehicleHandler = new();

    internal void Run()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Ensure UTF-8 encoding for special characters
        while (_isApplicationRunning)
        {
            ShowMenu();
            string? choice = Console.ReadLine();
            HandleUserChoice(choice);
        }
    }

    private void HandleUserChoice(string? choice)
    {
        if (choice == "0")
        {
            _isApplicationRunning = false;
            return;
        }

        var menuActions = new Dictionary<string, Action>
        {
            { "1", CreateAndListVehicles },
            { "2", UpdateVehicleWeight },
            { "3", ShowErrors },
            { "4", ListVehicles }
        };

        if (menuActions.TryGetValue(choice ?? string.Empty, out var action))
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
            }
        }
        else
        {
            ConsoleHelper.PrintMessage("Invalid choice. Please try again.");
        }
    }

    private void CreateAndListVehicles()
    {
        var vehicle = PromptVehicleDetails();
        _vehicleHandler.CreateVehicle(vehicle);
        ListVehicles();
    }

    private void UpdateVehicleWeight()
    {
        int index = ConsoleHelper.GetIntInput("Enter vehicle index to update weight: ");
        double weight = ConsoleHelper.GetDoubleInput("Enter new weight: ");
        _vehicleHandler.UpdateVehicleWeight(index, weight);
        ListVehicles();
    }

    private void ListVehicles()
    {
        ConsoleHelper.PrintMessage(_vehicleHandler.ListVehicles());
    }

    private Vehicle PromptVehicleDetails()
    {
        string brand = ConsoleHelper.GetStringInput("Enter vehicle brand: ");
        string model = ConsoleHelper.GetStringInput("Enter vehicle model: ");
        int year = ConsoleHelper.GetIntInput("Enter vehicle year: ");
        double weight = ConsoleHelper.GetDoubleInput("Enter vehicle weight: ");
        VehicleType vehicleType = (VehicleType)ConsoleHelper.GetIntInput("Enter vehicle type (1: Car, 2: Truck, 3: Motorcycle, 4: ElectricScooter): ");

        object additionalInfo = vehicleType switch
        {
            VehicleType.Car => ConsoleHelper.GetIntInput("Enter seating capacity: "),
            VehicleType.Truck => ConsoleHelper.GetDoubleInput("Enter cargo capacity: "),
            VehicleType.Motorcycle => ConsoleHelper.GetStringInput("Has sidecar? (Y/N): ").ToLower() == "y",
            VehicleType.ElectricScooter => ConsoleHelper.GetIntInput("Enter battery range: "),
            _ => throw new ArgumentException("Invalid vehicle type.")
        };

        return _vehicleHandler.CreateVehicle(brand, model, year, weight, vehicleType, additionalInfo);
    }

    private static void ShowErrors()
    {
        var errors = new List<SystemError>
        {
            new EngineFailureError(),
            new BrakeFailureError(),
            new TransmissionError()
        };

        ConsoleHelper.PrintMessage("\nError Messages:");
        foreach (var error in errors)
        {
            ConsoleHelper.PrintMessage(error.ErrorMessage());
        }
    }

    private void ShowMenu()
    {
        ConsoleHelper.PrintMessage("Welcome to the Vehicle Management System!");
        ConsoleHelper.PrintMessage("1. Create Vehicle");
        ConsoleHelper.PrintMessage("2. Update Vehicle Weight");
        ConsoleHelper.PrintMessage("3. Show Error Messages");
        ConsoleHelper.PrintMessage("4. List Vehicles");
        ConsoleHelper.PrintMessage("0. Exit");
    }
}