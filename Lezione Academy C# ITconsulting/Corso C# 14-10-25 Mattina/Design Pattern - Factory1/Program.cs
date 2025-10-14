
using Utils;
using System;
class Program
{
    static void Main(string [] args)
    {
        Console.WriteLine("Quale veicolo vuoi creare? (auto/moto/camion)");
        string v = Console.ReadLine();

        IVeicolo veicolo = VeicoloFactory.CreaVeicolo(v);

        if (v != null)
        {
            veicolo.Avvia();
            veicolo.MostraTipo();
        }
        else
        {
            Console.WriteLine("Errore: tipo di veicolo non riconosciuto!");
        }

        Console.WriteLine("\nFine programma. Premi un tasto per uscire.");
        Console.ReadKey();
    }
}