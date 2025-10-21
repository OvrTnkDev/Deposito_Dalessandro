using System;

#region INTERFACCE
public interface IExportFormatter
{
    void formattazione(string message);
}
public interface ILogger
{
    void Log(string message);
}
#endregion

#region CLASSI
public class DataJson : IExportFormatter
{
    public void formattazione(string message)
    {
        message = "JSON";
        Console.WriteLine($"[FORMATO]: {message}");
    }
}

public class DataXml : IExportFormatter
{
    public void formattazione(string message)
    {
        message = "XML";
        Console.WriteLine($"[FORMATO]: {message}");
    }
}
public class Data
{
    private IExportFormatter _export;
    public void SetStrategy(IExportFormatter export)
    {
        _export = export;
    }
    public void ExecuteStrategy(string message)
    {
        if (_export != null)
        {
            _export.formattazione(message);
            return;
        }
        Console.WriteLine($"Formattazione inesistente!");
        
    }
}
public class Logger : ILogger
{
    public void Log(string message) => Console.WriteLine($"[DOWNLOAD]: {message}");
}

public class DataExport
{
    private readonly ILogger _log;
    private IExportFormatter _export;
    public DataExport(ILogger log) => _log = log;
    public void SendExport(IExportFormatter export)
    {
        _export = export;
        _export.formattazione($" ,in fase di esportazione!");
        _log.Log($"{DateTime.Now}");
    }
}
#endregion

#region CLIENT
public class Program
{
    public static void Main(string[] args)
    {

    }
}
#endregion