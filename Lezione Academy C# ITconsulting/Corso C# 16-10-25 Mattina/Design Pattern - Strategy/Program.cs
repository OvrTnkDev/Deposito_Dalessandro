using System;
using System.Collections.Generic;

#region INTERFACCIA STRATEGY
// 1. Strategy: definisce l'interfaccia comune per tutti gli algoritmi
public interface IStrategiaOperazione
{
    // Ad esempio, elaborare una lista di numeri in modi diversi
    double Calcola(double a, double b);
}
#endregion

#region CLASSI CONCRETE STRATEGY
// 2. ConcreteStrategyAdd: implementa la somma
public class SommaStrategia : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        return a + b;
    }
}


// 3. ConcreteStrategySubtract: implementa la sottrazione
public class SottrazioneStrategia : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        return a - b;
    }
}

// 4. ConcreteStrategyMultiply: implementa la moltiplicazione
public class MoltiplicazioneStrategia : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        return a * b;
    }
}

public class DivisioneStrategia : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        return a / b;
    }
}
#endregion

#region CONTEXT
// 5. Context: utilizza una strategia per eseguire l'operazione
public class Calcolatrice
{
    // Riferimento alla strategia corrente
    private IStrategiaOperazione _strategia;

    // Permette di cambiare strategia a runtime
    public void SetStrategy(IStrategiaOperazione strategia)
    {
        _strategia = strategia;
    }

    // Esegue l'algoritmo tramite la strategia corrente
    public void ExecuteStrategy(double a, double b)
    {
        if (_strategia == null)
        {
            Console.WriteLine("Nessuna strategia impostata.");
            return;
        }
        double result = _strategia.Calcola(a, b);
        Console.WriteLine($"Risultato dell'operazione: {result}");
    }
}
#endregion

#region CLIENT
// 6. Client: configura il contesto e usa diverse strategie
class Program
{
    static void Main(string[] Args)
    {
        bool continua = true;
        var calcolatrice = new Calcolatrice();
        while (continua)
        {
            Menu(calcolatrice);
            Console.WriteLine("Vuoi effettuare un'altra operazione? (s/n)");
            string risposta = Console.ReadLine().ToLower();
            if (risposta != "s")
            {
                Console.WriteLine($"Arrivederci!");
                continua = false;
            }
        }
    }
    #endregion

#region MENU
    static void Menu(Calcolatrice calcolatrice)
    {
        Console.WriteLine($"-- Calcolatrice strategica --");
        Console.WriteLine($"-----------------------------");
        Console.WriteLine($"1. Somma");
        Console.WriteLine($"2. Sottrazione");
        Console.WriteLine($"3. Moltiplicazione");
        Console.WriteLine($"4. Divisione");
        Console.WriteLine($"5. Esempio con tutte le operazioni - Testing");
        Console.WriteLine($"0. Esci");
        Console.WriteLine($"-----------------------------");

        int scelta = int.Parse(Console.ReadLine());

        switch (scelta)
        {
            case 1:
                calcolatrice.SetStrategy(new SommaStrategia());
                Console.WriteLine($"Inserisci due numeri da sommare:");
                double sommaA = double.Parse(Console.ReadLine());
                double sommaB = double.Parse(Console.ReadLine());
                calcolatrice.ExecuteStrategy(sommaA, sommaB);
                break;
            case 2:
                calcolatrice.SetStrategy(new SottrazioneStrategia());
                Console.WriteLine($"Inserisci due numeri da sottrarre:");
                double sottrazioneA = double.Parse(Console.ReadLine());
                double sottrazioneB = double.Parse(Console.ReadLine());
                calcolatrice.ExecuteStrategy(sottrazioneA, sottrazioneB);
                break;
            case 3:
                calcolatrice.SetStrategy(new MoltiplicazioneStrategia());
                Console.WriteLine($"Inserisci due numeri da moltiplicare:");
                double moltiplicazioneA = double.Parse(Console.ReadLine());
                double moltiplicazioneB = double.Parse(Console.ReadLine());
                calcolatrice.ExecuteStrategy(moltiplicazioneA, moltiplicazioneB);
                break;
            case 4:
                calcolatrice.SetStrategy(new DivisioneStrategia());
                Console.WriteLine($"Inserisci due numeri da dividere:");
                double divisioneA = double.Parse(Console.ReadLine());
                double divisioneB = double.Parse(Console.ReadLine());
                calcolatrice.ExecuteStrategy(divisioneA, divisioneB);
                break;
            case 5:
                // Usa la strategia di somma
                calcolatrice.SetStrategy(new SommaStrategia());
                Console.Write("Somma: ");
                calcolatrice.ExecuteStrategy(10, 5);

                // Cambia strategia in sottrazione
                calcolatrice.SetStrategy(new SottrazioneStrategia());
                Console.Write("Sottrazione: ");
                calcolatrice.ExecuteStrategy(10, 5);

                // Cambi strategia in moltiplicazione
                calcolatrice.SetStrategy(new MoltiplicazioneStrategia());
                Console.Write("Moltiplicazione: ");
                calcolatrice.ExecuteStrategy(10, 5);

                // Cambi strategia in divisione
                calcolatrice.SetStrategy(new DivisioneStrategia());
                Console.Write("Divisione: ");
                calcolatrice.ExecuteStrategy(10, 5);
                break;
            case 0:
                return;
            default:
                Console.WriteLine("Scelta non valida.");
                return;
        }
    }
}
#endregion