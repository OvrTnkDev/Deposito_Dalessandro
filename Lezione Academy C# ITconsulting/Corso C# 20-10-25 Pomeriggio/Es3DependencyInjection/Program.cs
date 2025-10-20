using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

#region INTERFACES
// FASE 1 : INTERFACCIA
public interface ILogger
{
    void Log(string message);
}
#endregion

#region CLASSES + SINGLETON
public class AppConfig
{
    public string NomeApp = "Gestione ordini";
    public string Valuta { get; set; } = "EUR";
    public double Iva { get; set; } = 0.22;
}

public sealed class ConfigManager : AppConfig
{
    private static ConfigManager _instance { get; set; }
    private ConfigManager() { }
    public static ConfigManager GetInstace()
    {
        if (_instance == null)
        {
            _instance = new ConfigManager();
        }
        return _instance;
    }
}

public class LoggerService
{
    // DIPENDENCY INJECTION TRAMITE COSTRUTTORE
    private readonly ConfigManager _configManager;
    // INIETTORE L'OGGETTO
    public LoggerService(ConfigManager configManager)
    {
        _configManager = configManager;
    }
    // METODO CHE UTILIZZA L'OGGETTO INIETTATO
    public void ShowConfig()
    {
        Console.WriteLine($"Nome App: {_configManager.NomeApp}");
        Console.WriteLine($"Valuta: {_configManager.Valuta}");
        Console.WriteLine($"IVA: {_configManager.Iva}");
    }
}
    // Implementazione concreta di ILogger che scrive su console
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

public class OrderService
{
    public OrderService(ILogger logger, string message) => logger.Log($"{DateTime.Now}: {message}");
}

#endregion

#region CLIENT
// FASE 4 : CLIENT CHE ISTANZIA GLI OGGETTI E LI COLLEGA

public class Program
{
    public static void Main(string[] Args)
    {
        // OTTENGO L'ISTANZA UNICA DELLA CONFIGURAZIONE
        ConfigManager config = ConfigManager.GetInstace();
        // PASSO L'OGGETTO AL SERVIZIO LOGGER
        LoggerService loggerS = new LoggerService(config);
        // ESEGUO IL METODO LOGGER INJECTION
        loggerS.ShowConfig();
        // ISTANZIO IL SERVIZIO ORDINI
        ILogger consoleLogger = new ConsoleLogger();
        // Il costruttore di OrderService esegue subito il log
        OrderService orderService = new OrderService(consoleLogger, "Ordine #3322 creato");
        
    }
}
    #endregion