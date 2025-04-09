using System.Reflection.Metadata.Ecma335;

namespace VehicleManagement.Core.Errors;

public abstract class SystemError
{
    public abstract string ErrorMessage();
}
