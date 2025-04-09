namespace VehicleManagement;

internal static class ExceptionHelper
{
    public static void HandleException(Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
        // Optionally log the exception to a file or monitoring system
    }

    public static void ThrowIfNull<T>(T? obj, string paramName) where T : class
    {
        if (obj == null)
        {
            throw new ArgumentNullException(paramName);
        }
    }
    public static void ThrowIfNullOrEmpty(string? str, string paramName)
    {
        if (string.IsNullOrEmpty(str))
        {
            throw new ArgumentException($"Argument '{paramName}' cannot be null or empty.", paramName);
        }
    }
}
