namespace VehicleManagement.Core.Errors;

public class EngineFailureError : SystemError
{
    public override string ErrorMessage()
    {
        return "Engine failure detected. Check engine status!";
    }
}
