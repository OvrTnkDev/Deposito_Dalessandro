using System;
public class Operazioni
{
    private static int Somma(int a, int b)
    {
        return a + b;
    }

    private static int Moltiplica(int a, int b)
    {
        return a * b;
    }

    public static void Risultato(int a, int b, char c)
    {
        if (c == '+')
        {
            Console.WriteLine($"Il risultato della Somma è {(Operazioni.Somma(a, b))}");
        }
        else if (c == '*')
        {
            Console.WriteLine($"Il risultato della Moltiplicazione è {(Operazioni.Moltiplica(a, b))}");
        }
        else
        {
            Console.WriteLine($"Hai inserito un operatore non valido!!");
        }
    }
}

public class Program
{
    public static void Main()
    {
        bool u = true;
        while (u)
        {
            Console.Write($"Dimmi il primo numero da sommare o moltiplicare: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write($"Dimmi il secondo numero da sommare o moltiplicare: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write($"Scegli l'operator (+ o *): ");
            char c = char.Parse(Console.ReadLine());

            Operazioni.Risultato(a, b, c);

            Console.WriteLine($"Clicca 0 per uscire oppure INVIO per continuare!");
            if (Console.ReadLine() == "0"){ u = false; Console.Clear(); }
        }
    }
}