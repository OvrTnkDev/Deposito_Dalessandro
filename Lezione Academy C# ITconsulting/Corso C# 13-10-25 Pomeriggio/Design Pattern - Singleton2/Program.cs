using System;
using System.Collections.Generic;
using Utils;

class Program
{
    static void Main(string[] args)
    {
        string messaggio;
        bool check = true;
        List<string> logMessages = new List<string>();
        var logger1 = Logger.Instance;
        var logger2 = Logger.Instance;
        List<string> canileMessage = new List<string>();
        var canile1 = Canile.Instance;
        var canile2 = Canile.Instance;

        Console.WriteLine($"0- Esci");
        Console.WriteLine($"1- Logger");
        Console.WriteLine($"2- Canile");
        int scelta = int.Parse(Console.ReadLine());

        switch (scelta)
        {
            case 0:
                break;
            case 1:
                do
                {
                    Console.WriteLine("Applicazione avviata - Logger 1");
                    messaggio = Console.ReadLine();
                    logMessages.Add(logger1.Log(messaggio));

                    Console.WriteLine("Applicazione avviata - Logger 2");
                    messaggio = Console.ReadLine();
                    logMessages.Add(logger2.Log(messaggio));

                    Console.WriteLine("1 per uscire, altro per continuare");
                    if (Console.ReadLine() == "1")
                        check = false;
                    else { check = true; }

                } while (check);
                
                Console.WriteLine("\n--- Log generati ---");
                foreach (var msg in logMessages)
                {
                    Console.WriteLine(msg);
                }
                break;

            case 2:
                do
                {
                    Console.WriteLine("Applicazione avviata - Canile 1");
                    messaggio = Console.ReadLine();
                    canileMessage.Add(canile1.Log(messaggio));

                    Console.WriteLine("Applicazione avviata - Canile 2");
                    messaggio = Console.ReadLine();
                    canileMessage.Add(canile2.Log(messaggio));

                    Console.WriteLine("1 per uscire, altro per continuare");
                    if (Console.ReadLine() == "1")
                        check = false;
                    else{ check = true; }

                } while (check);

                Console.WriteLine("\n--- Log generati ---");
                foreach (var msg in canileMessage)
                {
                    Console.WriteLine(msg);
                }
                break;

            default:
            Console.WriteLine($"Scelta errata");
                break;
        }
    }
}
