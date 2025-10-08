using System;
using System.Collections.Generic;
using Utils;

class Program
{
    static void Main()
    {
        List<Soldato> s = new List<Soldato>();
        bool continua = true;

        while (continua)
        {
            Console.Clear();
            Console.WriteLine($"=== GESTIONE SOLDATI ===");
            Console.WriteLine("1. Aggiungi un nuovo Fante");
            Console.WriteLine("2. Aggiungi un nuovo Artigliere");
            Console.WriteLine("3. Visualizza tutti i soldati");
            Console.WriteLine("0. Esci");
            Console.Write("\nScelta: ");

            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    bool n = true;
                    while (n)
                    {
                        Console.Write($"Vuoi inserire un Fante? (S-N): ");
                        char u = char.Parse(Console.ReadLine().ToLower());
                        
                        if (u == 's')
                        {
                            Console.Write($"\nInserisci il nome del Fante: ");
                            string nomeFante = Console.ReadLine();

                            Console.Write($"\nInserisci il grado del Fante: ");
                            string gradoFante = Console.ReadLine();

                            Console.Write($"\nInserisci gli anni di servizio del Fante: ");
                            int anniSerFante = int.Parse(Console.ReadLine());

                            Console.Write($"\nInserisci l'arma del Fante: ");
                            string armaFante = Console.ReadLine();
                            //var f = new Fante(nomeFante, gradoFante, anniSerFante, armaFante);
                            s.Add(new Fante(nomeFante, gradoFante, anniSerFante, armaFante));
                            Console.WriteLine($"{s}");
                        }
                        else
                        {
                            n=false;
                        }
                    }
                    break;

                case "2":
                    n = true;
                    while (n)
                    {
                        Console.Write($"Vuoi inserire un Artigliere? (S-N): ");
                        char u = char.Parse(Console.ReadLine().ToLower());

                        if (u == 's')
                        {

                            Console.Write($"\nInserisci il nome del Artigliere: ");
                            string nomeArtigliere = Console.ReadLine();

                            Console.Write($"\nInserisci il grado del Artigliere: ");
                            string gradoArtigliere = Console.ReadLine();

                            Console.Write($"\nInserisci gli anni di servizio del Artigliere: ");
                            int anniSerArtigliere = int.Parse(Console.ReadLine());

                            Console.Write($"\nInserisci gli anni di servizio del Fante: ");
                            int calibroArtigliere = int.Parse(Console.ReadLine());

                            //var a = new Artigliere(nomeArtigliere, gradoArtigliere, anniSerArtigliere, calibroArtigliere);
                            s.Add(new Artigliere(nomeArtigliere, gradoArtigliere, anniSerArtigliere, calibroArtigliere));
                        }
                        else
                        {
                            n = false;
                        }
                    }
                    break;

                case "0":
                    continua = false;
                    Console.WriteLine("Arrivederci!");
                    break;

                default:
                    Console.WriteLine("Scelta non valida. Riprova.");
                    break;
            }

            Console.WriteLine("\nPremi un tasto per continuare...");
            Console.ReadKey();
        }
    }
}
