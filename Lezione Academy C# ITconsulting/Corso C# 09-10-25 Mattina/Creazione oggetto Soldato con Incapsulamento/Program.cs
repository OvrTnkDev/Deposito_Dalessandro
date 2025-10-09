using System;
using System.Collections.Generic;
using Utils;

class Program
{
    static void Main()
    {
        // Lista polimorfica: contiene Operatore, OperatoreSicurezza, ecc.
        List<Operatore> operatori = new List<Operatore>();
        bool continua = true;

        while (continua)
        {
            Console.Clear();
            Console.WriteLine("=== GESTIONE OPERATORI ===");
            Console.WriteLine("1. Aggiungi un nuovo Operatore Generico");
            Console.WriteLine("2. Aggiungi un nuovo Operatore Emergenza");
            Console.WriteLine("3. Aggiungi un nuovo Operatore Sicurezza");
            Console.WriteLine("4. Aggiungi un nuovo Operatore Logistica");
            Console.WriteLine("5. Esegui compito su tutti (polimorfismo)");
            Console.WriteLine("0. Esci");
            Console.Write("\nScelta: ");

            string scelta = Console.ReadLine();

            switch (scelta)
            {
                // -----------------------------
                case "1":
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Turno: ");
                    string turno = Console.ReadLine();

                    operatori.Add(new Operatore(nome, turno));
                    break;

                // -----------------------------
                case "2":
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Turno: ");
                    turno = Console.ReadLine();
                    Console.Write("Livello urgenza (0-5): ");
                    int livello = int.Parse(Console.ReadLine());

                    operatori.Add(new OperatoreEmergenza(nome, turno, livello));
                    break;

                // -----------------------------
                case "3":
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Turno: ");
                    turno = Console.ReadLine();
                    Console.Write("Area sorvegliata: ");
                    string area = Console.ReadLine();

                    operatori.Add(new OperatoreSicurezza(nome, turno, area));
                    break;

                // -----------------------------
                case "4":
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Turno: ");
                    turno = Console.ReadLine();
                    Console.Write("Numero consegne: ");
                    int consegne = int.Parse(Console.ReadLine());

                    operatori.Add(new OperatoreLogistica(nome, turno, consegne));
                    break;

                // -----------------------------
                case "5":
                    Console.WriteLine("\n=== ESECUZIONE POLIMORFICA ===");

                    // Ciclo base: passo ogni oggetto a una funzione polimorfica
                    for (int i = 0; i < operatori.Count; i++)
                    {
                        Console.WriteLine($"\nOperatore #{i + 1}: {operatori[i].Nome} ({operatori[i].Turno})");
                        Esegui(operatori[i]); // <-- chiamata polimorfica
                        Console.WriteLine("------------------------------");
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
    public static void Esegui(Operatore x)
    {
        x.EseguiCompito();
    }
}
