using System;
using System.Collections.Generic;
using Utils;

class Program
{
    static void Main()
    {
        string targa = "";
        List<Veicolo> v = new List<Veicolo>();

        bool continua = true;

        while (continua)
        {
            Console.Clear();
            Console.WriteLine($"=== GESTIONE VEICOLI ===");
            Console.WriteLine("1. Ripara Veicolo");
            Console.WriteLine("2. Visualizza i veicoli");
            Console.WriteLine("0. Esci");
            Console.Write("\nScelta: ");

            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "0":
                    continua = false;
                    break;
                case "1":
                    bool n = true;
                    while (n)
                    {
                        Console.Write($"Vuoi inserire un Veicolo? (S-N): ");
                        char u = char.Parse(Console.ReadLine().ToLower());

                        if (u == 's')
                        {
                            Console.WriteLine($"=== SCEGLI TIPO VEICOLO ===");
                            Console.WriteLine("1. Auto");
                            Console.WriteLine("2. Moto");
                            Console.WriteLine("3. Camion");
                            Console.WriteLine("0. Esci");

                            Console.Write("\nScelta: ");
                            int s = int.Parse(Console.ReadLine());

                            switch (s)
                            {
                                case 0:
                                    Console.WriteLine($"Hai scelto di uscire");
                                    n = false;
                                    break;
                                case 1:
                                    Console.Write($"\nInserisci la Targa dell'Auto: ");
                                    targa = Console.ReadLine();
                                    v.Add(new Auto(targa));
                                    break;

                                case 2:
                                    Console.Write($"\nInserisci la Targa della Moto: ");
                                    targa = Console.ReadLine();
                                    v.Add(new Moto(targa));
                                    break;

                                case 3:
                                    Console.Write($"\nInserisci la Targa del Camion: ");
                                    targa = Console.ReadLine();
                                    v.Add(new Camion(targa));
                                    break;

                                default:
                                    Console.WriteLine("Scelta non valida. Riprova.");
                                    break;
                            }
                        } else{ n = false; }
                    }
                    break;

                    case "2":
                            foreach (var b in v)
                            {
                                if (b is Auto a) { Console.WriteLine($"[AUTO] {a.Ripara()}"); }
                                else if (b is Moto m){Console.WriteLine($"[MOTO] {m.Ripara()}");}
                                else if (b is Camion c){Console.WriteLine($"[CAMION] {c.Ripara()}");}
                                else {Console.WriteLine($"[VEICOLO] {b.Ripara()}");}
                            }
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
