using System;

using System;

public class Pulsante
{
    public event Action Premuto;
    public void SimulaClick()
    {
        Console.WriteLine($"Pulsante cliccato");
        Premuto?.Invoke();
        
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        // Uso del delegate
        Pulsante p = new Pulsante();
        p.Premuto += () => Console.WriteLine($"Evento ricevuto!");
        p.SimulaClick();
    }
}
