using System;
using SubMain.SubMainOne;
using Methods;

namespace main
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(
                "\nCiao Benvenuto nell'Academy C# Offerta gentilmente da ItConsulting!\n" +
                "Preparati a gustarti un pò di codice pulito.\n\n" +
                "Adesso ti mostrerò un menù principale dal quale potrai scegliere un\n" +
                "sotto-menù per ogni funzione creata.\nBuona programmazione!!\n\n"
            );

            bool c = true;
            while (c)
            {
                Console.Clear(); // Pulisce la console all’inizio del menu

                Console.WriteLine(
                    "\n1. Giorno 1\n" +
                    "2. Giorno 2\n" +
                    "3. Giorno 3\n" +
                    "0. Esci\n"
                );
                Console.Write("Scelta: ");

                if (!int.TryParse(Console.ReadLine(), out int s))
                {
                    Console.WriteLine("Non hai inserito un numero, riprova!");
                    Console.WriteLine("Premi INVIO per tornare al menu principale...");
                    Console.ReadLine();
                    continue;
                }

                switch (s)
                {
                    case 0:
                        Console.WriteLine("\nHai scelto 0. Esci\n\nBye.\n");
                        c = false;
                        break;

                    case 1:
                        Console.WriteLine($"\nHai scelto Giorno {s}\n");
                        SubMainOne.DayOne1();
                        Console.WriteLine("\nPremi INVIO per tornare al menu principale...");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine($"\nHai scelto Giorno {s}\n");
                        SubMainOne.DayTwo2();
                        Console.WriteLine("\nPremi INVIO per tornare al menu principale...");
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine($"\nHai scelto Giorno {s}\n");
                        SubMainOne.DayThree3();
                        Console.WriteLine("\nPremi INVIO per tornare al menu principale...");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("\nLa scelta immessa non esiste!!\n");
                        Console.WriteLine("Premi INVIO per tornare al menu principale...");
                        Console.ReadLine();
                        break;
                }
            }

            // Messaggio finale all’uscita
            Console.WriteLine("Stai per uscire dal programma!\nClicca un tasto qualsiasi.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}