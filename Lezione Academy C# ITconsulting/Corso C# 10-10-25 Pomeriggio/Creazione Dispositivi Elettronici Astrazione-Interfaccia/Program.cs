using System;
using System.Collections.Generic;
using Utils;

class Program
{
    static void Main()
    {
        // Lista polimorfica: contiene Operatore, OperatoreSicurezza, ecc.
        List<DispositivoElettronico> dispositivi = new List<DispositivoElettronico>();
        bool continua = true;

        while (continua)
        {
            Console.Clear();
            Console.WriteLine("=== GESTIONE DISPOSITIVI ===");
            Console.WriteLine("1. Aggiungi un nuovo Computer");
            Console.WriteLine("2. Aggiungi una nuova Stampante");
            Console.WriteLine("3. Mostra Computer");
            Console.WriteLine("4. Mostra Stampanti");
            Console.WriteLine("0. Esci");
            Console.Write("\nScelta: ");

            string scelta = Console.ReadLine();

            switch (scelta)
            {
                // -----------------------------
                case "1":
                    Console.Write("Modello: ");
                    string modello = Console.ReadLine();
                    dispositivi.Add(new Computer(modello));
                    break;

                case "2":
                    Console.Write("Modello: ");
                    modello = Console.ReadLine();
                    dispositivi.Add(new Stampante(modello));
                    break;

                case "3":
                    Console.WriteLine("\n=== COMPUTER ===");
                    foreach (var d in dispositivi)
                    {
                        if (d is Computer)
                            Esegui(d);
                    }
                    break;

                case "4":
                    Console.WriteLine("\n=== STAMPANTI ===");
                    foreach (var d in dispositivi)
                    {
                        if (d is Stampante)
                            Esegui(d);
                    }
                    break;


                // -----------------------------
                case "0":
                    continua = false;
                    Console.WriteLine("Arrivederci!");
                    break;

                // -----------------------------
                default:
                    Console.WriteLine("Scelta non valida. Riprova.");
                    break;
            }

            Console.WriteLine("\nPremi un tasto per continuare...");
            Console.ReadKey();
        }
    }

    // Metodo polimorfico: accetta la classe base
    //  e chiama dinamicamente il metodo override corretto.
    public static void Esegui(DispositivoElettronico x)
    {
        x.Avvia();
        x.Spegni();
    }
}
