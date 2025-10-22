using System;
using System.Collections;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

#region INTERFACCE
public interface ILogger
{
    void Log();
}
public interface INotifier : ILogger
{
    void Notify(string message);
}
#endregion

#region ENUM
public enum TipoNotifica
{
    Sms,
    Email,
    Push
}
#endregion

#region CLASSI CONCRETE INOTIFIER E ILOGGER
public class SmsNotifier : INotifier
{
    public void Notify(string message) => Console.WriteLine($"[Invio SMS]: {message}");
    public void Log() => Console.WriteLine($"[LOG SMS]: {DateTime.Now}");
}

public class EmailNotifier : INotifier
{
    public void Notify(string message) => Console.WriteLine($"[Invio E-MAIL]: {message}");
    public void Log() => Console.WriteLine($"[LOG E-MAIL]: {DateTime.Now}");
}
public class PushNotifier : INotifier
{
    public void Notify(string message) => Console.WriteLine($"[Invio PUSH]: {message}");
    public void Log() => Console.WriteLine($"[LOG PUSH]: {DateTime.Now}");
}
#endregion

#region FACTORY METHOD
public static class NotifierFactory
{
    public static INotifier CreaNotifica(TipoNotifica tipo)
    {
        return tipo switch
        {
            TipoNotifica.Sms => new SmsNotifier(),
            TipoNotifica.Email => new EmailNotifier(),
            TipoNotifica.Push => new PushNotifier(),
            _ => throw new ArgumentException("Tipo di notifica non riconosciuto.")
        };
    }
}
#endregion

#region CLIENT
class Program
{
    static void Main()
    {
        do
        {
            Console.WriteLine($"--- Gestore notifiche ---");
            Console.WriteLine($"1. SMS");
            Console.WriteLine($"2. E-MAIL");
            Console.WriteLine($"3. PUSH");
            Console.WriteLine($"0. ESCI");
            Console.Write($"SCELTA: ");

            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 0:
                    return;

                case 1:
                    var smsNotify = NotifierFactory.CreaNotifica(TipoNotifica.Sms);
                    Console.WriteLine($"Hai scelto: {smsNotify.ToString()}");
                    smsNotify.Notify($"Benvenuto Fabio, il sistema è attivo!");
                    smsNotify.Log();
                    Console.ReadKey();
                    break;

                case 2:
                    var emailNotify = NotifierFactory.CreaNotifica(TipoNotifica.Email);
                    Console.WriteLine($"Hai scelto: {emailNotify.ToString()}");
                    emailNotify.Notify($"Benvenuto Fabio, il sistema è attivo!");
                    emailNotify.Log();
                    Console.ReadKey();
                    break;

                case 3:
                    var pushlNotify = NotifierFactory.CreaNotifica(TipoNotifica.Push);
                    Console.WriteLine($"Hai scelto: {pushlNotify.ToString()}");
                    pushlNotify.Notify($"Benvenuto Fabio, il sistema è attivo!");
                    pushlNotify.Log();
                    Console.ReadKey();
                    break;

                default:
                    throw new ArgumentException("Scelta errata!");
            }
        } while (true);
    }
}
#endregion