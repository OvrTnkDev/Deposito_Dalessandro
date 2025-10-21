using System;

#region INTERFACCE
public interface INotifier
{
    void Notify(string message);
}
public interface ILogger
{
    void Log(string message);
}
#endregion

#region CLASSI
public class SmsNotifier : INotifier
{
    public void Notify(string message)
    {
        Console.WriteLine($"[Invio SMS]: {message}");
    }
}
public class Logger : ILogger
{
    public void Log(string message) => Console.WriteLine($"[LOG]: {message}");
}

public class AlertService
{
    private readonly ILogger _log;
    public AlertService(ILogger log) => _log = log;
    public void SendAlert(string user, INotifier notifier)
    {
        notifier.Notify($"Ciao {user}, hai una nuovo messaggio!");
        _log.Log($"{DateTime.Now}");
    }
}
#endregion

#region CLIENT
public class Program
{
    public static void Main(string[] args)
    {
        //Istanza concreta di SmsNotifier
        INotifier notifier = new SmsNotifier();
        
        ILogger logger = new Logger();

        var service = new AlertService(logger);
        service.SendAlert("Fabio", notifier);
    }
}
#endregion