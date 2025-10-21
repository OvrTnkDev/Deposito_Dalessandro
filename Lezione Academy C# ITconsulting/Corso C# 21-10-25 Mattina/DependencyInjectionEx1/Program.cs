using System;


public interface ILogger
{
    void Log(string message);
}

public class ConsoleLogger : ILogger
{
    public void Log(string message) => Console.WriteLine($"[LOG]: {message}");
}

public class Printer
{
    public ILogger? Logger { get; set; }

    public void Print(string m)
    {
        if (Logger == null)
        {
            Console.WriteLine($"{m}");
            return;
        }

        Logger.Log(m);
        Console.WriteLine($"print: {m}");
    }
}

public class Program
{
    public static void Main(string[] Args)
    {
        var print = new Printer();
        print.Print("Hello, World! senza logger");
        print.Logger = new ConsoleLogger();
        print.Print("Hello, World! con logger");
    }
}