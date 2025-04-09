namespace VehicleManagement.Core.Models;

public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }
    public Motorcycle(string brand, string model, int year, double weight, bool hasSidecar)
        : base(brand, model, year, weight)
    {
        HasSidecar = hasSidecar;
    }

    public override string StartEngine()
    {
        return "Motorcycle engine started.🏍️";
    }

    public override string Stats()
    {
        return $"Motorcycle: {Brand} {Model}, Year: {Year}, Weight: {Weight}kg, {(HasSidecar ? "With sidecar" : "Without sidecar")} ";
    }
}
