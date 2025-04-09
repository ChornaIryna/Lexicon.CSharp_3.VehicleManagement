namespace VehicleManagement.Core.Errors;

public class BrakeFailureError : SystemError
{
    public override string ErrorMessage()
    {
        return "Brake failure detected. The vehicle is unsafe to drive!";
    }
}
