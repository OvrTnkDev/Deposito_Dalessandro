using System;
public interface INotifier
{
void Notify(string message);
}

public class SmsNotifier : INotifier
{
public void Notify(string message)
{
Console.WriteLine($"[Invio SMS]: {message}");
}
}

public class AlertService
{
    public void SendAlert(string user, INotifier notifier)
    {
        notifier.Notify($"Ciao {user}, hai una nuovo messaggio!");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        INotifier notifier = new SmsNotifier();
        var service = new AlertService();
        service.SendAlert("Fabio", notifier);
    }
}