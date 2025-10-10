using System;
using System.Collections.Generic;
using Utils;

class Program
{
    static void Main()
    {
        // Lista polimorfica
        List<IPagamento> pagamento = new List<IPagamento>();
        bool continua = true;

        while (continua)
        {
            Console.Clear();
            Console.WriteLine("=== GESTIONE PAGAMENTO ===");
            Console.WriteLine("1. Paga con carta");
            Console.WriteLine("2. Paga in contanti");
            Console.WriteLine("3. Paga con PayPal");
            Console.WriteLine("0. Esci");
            Console.Write("\nScelta: ");

            string scelta = Console.ReadLine();

            switch (scelta)
            {
                // -----------------------------
                case "1":
                    Console.Write("Inserisci importo > 0: ");
                    decimal p = decimal.Parse(Console.ReadLine());
                    Console.Write("Inserisci il circuito (visa, mastercard): ");
                    string m = Console.ReadLine();
                    pagamento.Add(new PagamentoCarta(p, m));
                    
                    Esegui(pagamento[^1]);
                    break;

                case "2":
                    Console.Write("Inserisci importo > 0: ");
                    p = decimal.Parse(Console.ReadLine());
                    pagamento.Add(new PagamentoContanti(p));

                    Esegui(pagamento[^1]);
                    break;

                case "3":
                    Console.Write("Inserisci importo > 0: ");
                    p = decimal.Parse(Console.ReadLine());
                    pagamento.Add(new PagamentoPayPal(p));

                    Esegui(pagamento[^1]);
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
    public static void Esegui(IPagamento x)
    {
        x.EseguiPagamento();
        x.MostraMetodo();
    }
}
