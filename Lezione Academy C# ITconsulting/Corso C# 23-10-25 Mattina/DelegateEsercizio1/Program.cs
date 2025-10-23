using System;

using System;
using System.Runtime.InteropServices;

public class Program
{
    // Dichiarazione delegate
    Action<string> saluta = nome => Console.WriteLine($"Benvemuto {nome}");
    
    delegate int Operazione(int a, int b);

    // Metodo compatibile
    static int Somma(int a, int b)
    {
        return a + b;
    }
    static int Moltiplica(int a, int b)
    {
        return a * b;
    }
    
    // Metodo Main
    public static void Main(string[] args)
    {
        // Uso del delegate
        Operazione a = Somma;
        Operazione b = Moltiplica;
        Console.WriteLine($"Somma: {a(120, 300)}");
        Console.WriteLine($"Moltiplica: {b(10, 300)}");
    }
}
