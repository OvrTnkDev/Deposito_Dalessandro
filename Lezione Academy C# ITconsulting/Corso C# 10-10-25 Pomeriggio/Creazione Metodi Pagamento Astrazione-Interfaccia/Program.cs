using System;
using System.Collections.Generic;
using Utils;

class Program
{
    static void Main()
    {
        // Lista polimorfica
        List<IPagamento> dispositivi = new List<IPagamento>();
        bool continua = true;

        while (continua)
        {
            Console.Clear();
            Console.WriteLine("=== GESTIONE PAGAMENTO ===");
            Console.WriteLine("1. Paga con carta");
            Console.WriteLine("2. Paga in contanti");
            Console.WriteLine("2. Paga con PayPal");
            Console.WriteLine("3. Mostra Computer");
            Console.WriteLine("4. Mostra Stampanti");
            Console.WriteLine("0. Esci");
            Console.Write("\nScelta: ");

            string scelta = Console.ReadLine();

            switch (scelta)
            {
                // -----------------------------
                case "1":
                    Console.Write("Esegui pagamento: ");
                    decimal p = decimal.Parse(Console.ReadLine());
                    dispositivi.Add(new Computer(modello));
                    break;

                case "2":
                    Console.Write("Esegui pagamento: ");
                    p = decimal.Parse(Console.ReadLine());
                    dispositivi.Add(new Stampante(modello));
                    break;

                case "3":
                    Console.Write("Esegui pagamento: ");
                    p = decimal.Parse(Console.ReadLine());

                //     foreach (var d in dispositivi)
                //     {
                //         if (d is Computer)
                //             Esegui(d);
                //     }
                //     break;

                // case "4":
                //     Console.WriteLine("\n=== STAMPANTI ===");
                //     foreach (var d in dispositivi)
                //     {
                //         if (d is Stampante)
                //             Esegui(d);
                //     }
                //     break;


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
