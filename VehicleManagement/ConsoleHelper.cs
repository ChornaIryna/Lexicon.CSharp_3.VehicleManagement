namespace VehicleManagement; 

internal static class ConsoleHelper
{
    public static string GetStringInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine() ?? string.Empty;
    }

    public static int GetIntInput(string prompt)
    {
        Console.Write(prompt);
        int.TryParse(Console.ReadLine(), out int result);
        return result;
    }

    public static double GetDoubleInput(string prompt)
    {
        Console.Write(prompt);
        double.TryParse(Console.ReadLine(), out double result);
        return result;
    }

    public static void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
    
    public static void HandleException(Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Error: {ex.Message}");
        Console.ResetColor();
    }
}
