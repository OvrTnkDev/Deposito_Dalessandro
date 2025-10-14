using System;
using System.Collections.Generic;
using Utils;

class Program
{
    static void Main(string[] args)
    {
        bool check = true;
        bool c = true;
        string chiave, valore;

        var config1 = ConfigurazioneSistema.Instance;
        var config2 = ConfigurazioneSistema.Instance;
        while (c)
        {
            Console.WriteLine("0 - Esci");
            Console.WriteLine("1 - Modulo A");
            Console.WriteLine("2 - Modulo B");
            int scelta = int.Parse(Console.ReadLine() ?? "0");

            switch (scelta)
            {
                case 0:
                    c = false;
                    Console.WriteLine($"Stai per uscire...");
                    break;

                case 1:
                    do
                    {
                        Console.WriteLine("Modulo A - Imposta configurazione");
                        Console.Write("Chiave: ");
                        chiave = Console.ReadLine();
                        Console.Write("Valore: ");
                        valore = Console.ReadLine();

                        config1.Imposta(chiave, valore);
                        Console.WriteLine($"Configurazione impostata da Modulo A -> {chiave} = {valore}");

                        Console.WriteLine("Vuoi leggere un valore? (s/n)");
                        if (Console.ReadLine()?.ToLower() == "s")
                        {
                            Console.Write("Chiave da leggere: ");
                            chiave = Console.ReadLine();
                            var val = config1.Leggi(chiave);
                            Console.WriteLine(val != null ? $"Valore letto: {val}" : "Chiave non trovata");
                        }

                        Console.WriteLine("1 per uscire, altro per continuare");
                        check = Console.ReadLine() != "1";
                    } while (check);

                    break;

                case 2:
                    do
                    {
                        Console.WriteLine("Modulo B - Imposta configurazione");
                        Console.Write("Chiave: ");
                        chiave = Console.ReadLine();
                        Console.Write("Valore: ");
                        valore = Console.ReadLine();

                        config2.Imposta(chiave, valore);
                        Console.WriteLine($"Configurazione impostata da Modulo B -> {chiave} = {valore}");

                        Console.WriteLine("Vuoi leggere un valore? (s/n)");
                        if (Console.ReadLine()?.ToLower() == "s")
                        {
                            Console.Write("Chiave da leggere: ");
                            chiave = Console.ReadLine();
                            var val = config2.Leggi(chiave);
                            Console.WriteLine(val != null ? $"Valore letto: {val}" : "Chiave non trovata");
                        }

                        Console.WriteLine("1 per uscire, altro per continuare");
                        check = Console.ReadLine() != "1";
                    } while (check);

                    break;

                default:
                    Console.WriteLine("Scelta errata");
                    break;
            }

            // Stampa finale e verifica che sia la stessa istanza
            Console.WriteLine("\n--- CONFIGURAZIONI ATTUALI ---");
            config1.StampaTutte();

            Console.WriteLine($"\nHashCode Modulo A: {config1.GetHashCode()} || HashCode Modulo B: {config2.GetHashCode()}");
            Console.WriteLine(config1 == config2
                ? "Entrambi i moduli condividono la stessa istanza (Singleton funzionante)."
                : "Le istanze sono diverse (Singleton NON funzionante).");
        }
    }
}
