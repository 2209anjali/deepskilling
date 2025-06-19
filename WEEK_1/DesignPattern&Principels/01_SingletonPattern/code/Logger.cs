// Logger.cs
using System;

public sealed class Logger : ILogger
{
    private static Logger _instance;
    private static readonly object _lock = new object();

    private Logger()
    {
        Console.WriteLine("Logger initialized.");
    }

    public static ILogger GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }
            }
        }
        return _instance;
    }

    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {DateTime.Now}: {message}");
    }
}