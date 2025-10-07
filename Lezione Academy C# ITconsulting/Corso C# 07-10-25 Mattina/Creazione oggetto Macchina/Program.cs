using System;
using Utils.Macchina;

public class Program
{
    public static void Main()
    {
        bool check = true;

        while (check)
        {
            Console.WriteLine("Benvenuto nel tuo Garage!\n");
            Console.WriteLine("MENU");
            Console.WriteLine("1. Entra nel Garage");
            Console.WriteLine("0. Esci\n");

            Console.Write("Scelta: ");
            if (!int.TryParse(Console.ReadLine(), out int scelta))
            {
                Console.WriteLine("Input non valido, riprova.\n");
                continue;
            }

            switch (scelta)
            {
                case 0:
                    check = false;
                    Console.WriteLine("Arrivederci!");
                    break;

                case 1:
                    EntraNelGarage();
                    break;

                default:
                    Console.WriteLine("Scelta non valida.\n");
                    break;
            }
        }
    }

    static void EntraNelGarage()
    {
        Console.Write("\nInserisci il tuo nome: ");
        string nome = Console.ReadLine();

        Console.Write("Inserisci il tuo credito iniziale: ");
        if (!int.TryParse(Console.ReadLine(), out int credito))
        {
            Console.WriteLine("Credito non valido, ritorno al menu principale.\n");
            return;
        }

        Macchina m = new Macchina("3.0 Benzina V6", 4, 260, 0);
        bool check1 = true;

        while (check1)
        {
            if (credito <= 0)
            {
                Console.WriteLine("Hai terminato il credito!");
                break;
            }

            Console.WriteLine($"\nCosa vuoi fare, {nome}? (Credito residuo: {credito})");
            Console.WriteLine("1. Aumenta velocità di 10");
            Console.WriteLine("2. Cambia tipo di motore");
            Console.WriteLine("3. Aumenta sospensioni");
            Console.WriteLine("0. Esci\n");

            Console.Write("Scelta: ");
            if (!int.TryParse(Console.ReadLine(), out int scelta1))
            {
                Console.WriteLine("Input non valido.\n");
                continue;
            }

            switch (scelta1)
            {
                case 0:
                    Console.WriteLine("Ritorno al menu principale!\n");
                    check1 = false;
                    break;

                case 1:
                    m.ModificheVelocita();
                    Console.WriteLine(m.ToString());
                    credito--;
                    break;

                case 2:
                    Console.Write("Inserisci il nuovo motore: ");
                    string motore = Console.ReadLine();
                    m.ModificheMotore(motore);
                    Console.WriteLine(m.ToString());
                    credito--;
                    break;

                case 3:
                    Console.Write("Aumenta le sospensioni di: ");
                    if (int.TryParse(Console.ReadLine(), out int sospensione))
                    {
                        m.ModificheSospensione(sospensione);
                        Console.WriteLine(m.ToString());
                        credito--;
                    }
                    else
                    {
                        Console.WriteLine("Valore non valido.\n");
                    }
                    break;

                default:
                    Console.WriteLine("Scelta errata!\n");
                    break;
            }
        }
    }
}