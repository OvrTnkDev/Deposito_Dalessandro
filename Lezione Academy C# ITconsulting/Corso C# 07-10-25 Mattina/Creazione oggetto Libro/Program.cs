using System;
using Utils.Libro;

public class Program
{
    public static void Main()
    {
        bool check = true;

        while (check)
        {
            Console.WriteLine("Benvenuto nella mia Biblioteca!\n");
            Console.WriteLine("MENU");
            Console.WriteLine("1. Entra nella biblioteca");
            Console.WriteLine("0. Esci\n");

            Console.Write("Scelta: ");
            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 0:
                    check = false;
                    Console.WriteLine("Arrivederci!");
                    break;

                case 1:
                    Libro a = new Libro("Lo straniero", "Albert Camus", 1942);
                    Libro b = new Libro("Lo straniero", "Albert Camus", 1942);
                    Console.WriteLine("\n-- Catalogo --");
                    Console.WriteLine($"Libro A: {a}");
                    Console.WriteLine($"Libro B: {b}");
                    Console.WriteLine($"Uguali? {a.Equals(b)}");
                    Console.WriteLine($"Hash A: {a.GetHashCode()} | Hash B: {b.GetHashCode()}\n");
                    break;

                default:
                    Console.WriteLine("Scelta errata!\n");
                    break;
            }
        }
    }
}
