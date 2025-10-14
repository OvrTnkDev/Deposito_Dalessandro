
using Utils;
using System;
class Program
{
    static void Main(string [] args)
    {
        Console.WriteLine("Quale forma vuoi creare? (cirle/square)");
        string v = Console.ReadLine();

        IShape shape = ShapeCreator.CreateShape(v);

        if (v != null)
        {
            shape.Draw();
            Console.WriteLine($"Tipo: {shape.GetType()}");
        }
        else
        {
            Console.WriteLine("Errore: tipo di shape non riconosciuto!");
        }

        Console.WriteLine("\nFine programma. Premi un tasto per uscire.");
        Console.ReadKey();
    }
}