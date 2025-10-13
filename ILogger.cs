// Task 5: Interface with Default Implementation (C# 8+)
interface ILogger
{
    void Log(string message);

    // Default implementation (C# 8.0+)
    void LogWithTime(string message)
    {
        Console.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}");
    }
}

class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"LOG: {message}");
    }

    // Note: We don't need to implement LogWithTime because it has a default implementation
}