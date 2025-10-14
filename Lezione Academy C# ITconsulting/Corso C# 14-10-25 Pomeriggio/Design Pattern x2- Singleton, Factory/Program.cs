
using Utils;
using System;
class Program
{
    static void Main(string [] args)
    {
        Console.WriteLine("Quale veicolo vuoi creare? (auto/moto/camion)");
        string v = Console.ReadLine();

        IVeicolo veicolo = VeicoloFactory.OttieniIstanza(v);

        if (v != null)
        {
            veicolo.Avvia();
            Console.WriteLine($"Tipo: {veicolo.GetType()}");
        }
        else
        {
            Console.WriteLine("Errore: tipo di veicolo non riconosciuto!");
        }

        Console.WriteLine("\nFine programma. Premi un tasto per uscire.");
        Console.ReadKey();
    }
}