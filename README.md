# Vehicle Management System (Encapsulation, Inheritance & Polymorphism in C#)

This project implements a **Vehicle Management System** in C# to demonstrate the principles of **Encapsulation**, **Inheritance**, and **Polymorphism**. The solution is structured to meet the requirements of the assignment and is divided into four key parts.

---

## Assignment Description

### Part 1: Encapsulation
1. **Vehicle Class**:
   - Create a class `Vehicle` with the following private fields: `brand`, `model`, `year`, `weight`. 
    - Add public **properties** with validation:
     - `Brand` and `Model` must be between 2 and 20 characters.
     - `Year` must be between 1886 (the invention of the car) and the current year.
     - `Weight` must be a positive value.
   - Throw `ArgumentException` with appropriate error messages if validation fails.

2. **VehicleHandler Class**:
   - Create a class `VehicleHandler` with methods to:
     - Create a new vehicle.
     - Update the weight of an existing vehicle.
     - List all vehicles.

3. **Exception Handling**:
   - Use `try-catch` blocks in `Program.cs` to handle exceptions.

---

### Part 2: Polymorphism
1. **SystemError Class**:
   - Create an abstract class `SystemError` with an abstract method `ErrorMessage()`.

2. **Subclasses**:
   - `EngineFailureError`: Returns ex.:"Engine failure detected. Check engine status!"
   - `BrakeFailureError`: Returns ex.:"Brake failure detected. The vehicle is unsafe to drive!"
   - `TransmissionError`: Returns ex.:"Transmission failure detected. Repair required!"

3. **Error Handling**:
   - Add all error objects to a list and display their error messages using a `foreach` loop.

---

### Part 3: Inheritance
1. **Vehicle Class**:
   - Create an abstract class `Vehicle` with the methods `StartEngine()` and `Stats()`.

2. **Subclasses**:
   - `Car`: Includes the property ex.:`SeatingCapacity`.
   - `Truck`: Includes the property ex.:`CargoCapacity`.
   - `Motorcycle`: Includes the property ex.:`HasSidecar`.
   - `ElectricScooter`: Includes the property ex.:`BatteryRange`.

3. **StartEngine Method**:
   - Each vehicle type implements its own version of `StartEngine()`.

---

### Part 4: Advanced Polymorphism
1. **List of Vehicles**:
   - Create a list of type `List<Vehicle>` and populate it with different vehicle types.

2. **Iterate Through the List**:
   - For each vehicle in the list:
     - Call `Stats()` to display vehicle information.
     - Call `StartEngine()` to start the vehicle.

3. **ICleanable Interface**:
   - Create an interface `ICleanable` with the method `Clean()`.
   - Implement `ICleanable` in `Car` and `Truck`.

4. **Check and Call Clean**:
   - In the loop, check if a vehicle implements `ICleanable` and call the `Clean()` method.

---

## Solution Description

### Key Features
1. **Encapsulation**:
   - The `Vehicle` class uses private fields with public properties for validation.
   - The `VehicleHandler` class manages vehicle creation, updates, and listing.

2. **Polymorphism**:
   - The `SystemError` class and its subclasses demonstrate polymorphism through the `ErrorMessage()` method.
   - The `Vehicle` class and its subclasses override `StartEngine()` and `Stats()`.

3. **Inheritance**:
   - The `Vehicle` class serves as the base class for `Car`, `Truck`, `Motorcycle`, and `ElectricScooter`.

4. **Interface Usage**:
   - The `ICleanable` interface is implemented by `Car` and `Truck`, showcasing a "can-do" relationship.

5. **Predefined Data**:
   - A predefined list of vehicles is available for testing and demonstration.

---

## Solution Structure

### Project Structure
The solution is divided into three projects for better separation of concerns:

1. **VehicleManagement.Core**:
   - Contains core abstractions and models.
   - Includes:
     - `Vehicle` (abstract class) and its subclasses (`Car`, `Truck`, `Motorcycle`, `ElectricScooter`).
     - `SystemError` (abstract class) and its subclasses (`EngineFailureError`, `BrakeFailureError`, `TransmissionError`).
     - `ICleanable` (interface).
     - `VehicleType` (enum).

2. **VehicleManagement.Handlers**:
   - Contains the `VehicleHandler` class, which manages vehicle operations such as creation, updates, and listing.

3. **VehicleManagement**:
   - The Console application that handles user interaction.
   - Includes:
     - `UserInterface` class for menu handling and user input.
     - `ConsoleHelper` for input/output utilities.

---

### Example Data
The following vehicles are used as test data:
- `Car`: Brand: "Toyota", Model: "Corolla", Year: 2020, Weight: 1300, SeatingCapacity: 5
- `Truck`: Brand: "Ford", Model: "F-150", Year: 2019, Weight: 2500, CargoCapacity: 1000
- `Motorcycle`: Brand: "Harley-Davidson", Model: "Street 750", Year: 2021, Weight: 220, HasSidecar: false
- `ElectricScooter`: Brand: "Xiaomi", Model: "M365", Year: 2022, Weight: 12, BatteryRange: 30

### 
**Answers to Questions:** The answers to the questions are included as comments in the `Program.cs`.    

