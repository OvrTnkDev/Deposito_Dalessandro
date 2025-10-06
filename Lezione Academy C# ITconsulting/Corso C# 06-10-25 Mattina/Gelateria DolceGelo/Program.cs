using System;
using Utils;
using Utils.Utility;

namespace Main
{
    static class Program
    {
        public static void Main(string[] args)
        {
            bool exit = true;
            
            while (exit)
            {
            Console.WriteLine($"\n1. Entra in Gelateria\n" +
                              $"0. Esci dalla Gelateria\n");
                              
            Console.Write($"Scelta: ");
            

                if (!int.TryParse(Console.ReadLine(), out int o))
                {
                    Console.WriteLine($"Inserisci una scelta valida, che sia un numero!");
                    continue;
                }
                else
                {
                    switch (o)
                    {
                        case 1:
                            Utility.GustiDisponibili();
                            break;

                        case 0:
                            exit = false;
                            Console.WriteLine($"Hai scelto di uscire!!");
                            break;

                        default:
                            Console.WriteLine($"La scelta inserita non esiste!");

                            break;

                    }
                }
            }
        }
    }
}
