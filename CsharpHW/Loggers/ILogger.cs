using System;

public interface ILogger
{
    void Log(string message);

    void LogWithTime(string message)
    {
        Console.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}");
    }
}