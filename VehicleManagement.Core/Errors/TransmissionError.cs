namespace VehicleManagement.Core.Errors;

public class TransmissionError : SystemError
{
    public override string ErrorMessage()
    {
        return "Transmission failure detected. Repair required!";
    }
}
