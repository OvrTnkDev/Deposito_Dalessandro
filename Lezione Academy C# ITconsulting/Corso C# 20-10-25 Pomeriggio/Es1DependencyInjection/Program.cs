using System;
using System.Collections.Generic;

#region INTERFACES
// FASE 1 : INTERFACCIA GREETER
public interface IGreeter
{
    void Greeter(string message);
}
#endregion

#region CLASSES
// FASE 2 : CLASSE CONSOLEGREETING CHE IMPLEMENTA L'INTERFACCIA GREETER
public class consoleGreeting : IGreeter
{
    public void Greeter(string message)
    {
        Console.WriteLine($"{message}");
    }
}
// FASE 3 : CLASSE GREETINGSERVICE RICEVE TRAMITE COSTRUTTORE UN OGGETTO DI TIPO IGREETER
public class GreetingService
{
    // DIPENDENCY INJECTION TRAMITE COSTRUTTORE
    private readonly IGreeter _greeter;
    // INIETTORE L'OGGETTO DI TIPO IGREETER
    public GreetingService(IGreeter greeter)
    {
        _greeter = greeter;
    }
    // METODO CHE UTILIZZA L'OGGETTO INIETTATO
    public void SendGreeting(string message) => _greeter.Greeter(message);
}
#endregion

#region CLIENT
// FASE 4 : CLIENT CHE ISTANZIA GLI OGGETTI E LI COLLEGA

public class Program
{
    public static void Main (string[] Args)
    {
        // ISTANZIO L'OGGETTO DI TIPO CONSOLEGREETING
        IGreeter greeter = new consoleGreeting();
        // PASSO L'OGGETTO INIETTATO AL COSTRUTTORE DI GREETINGSERVICE
        GreetingService greetingService = new GreetingService(greeter);
        // UTILIZZO IL METODO DI GREETINGSERVICE CHE A SUA VOLTA UTILIZZA L'OGGETTO INIETTATO
        greetingService.SendGreeting("Hello, Dependency Injection!");
    }
}
    #endregion