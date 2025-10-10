using System;
using System.Collections.Generic;

namespace AutoOOP
{
    class Program
    {
        // Classe base: incapsulamento + ereditarietà
        class Auto
        {
            // Incapsulamento: proprietà private con accesso pubblico controllato
            private string marca;
            private string modello;

            public string Marca
            {
                get { return marca; }
                set { marca = value; }
            }

            public string Modello
            {
                get { return modello; }
                set { modello = value; }
            }

            // Metodo virtuale: polimorfismo
            public virtual void SuonaClacson()
            {
                Console.WriteLine("Clacson generico!");
            }

            public override string ToString()
            {
                return $"Auto: {Marca} {Modello}";
            }
        }

        // Classe derivata: ereditarietà + polimorfismo override
        class AutoSportiva : Auto
        {
            public override void SuonaClacson()
            {
                Console.WriteLine("Beep Beep sportivo!");
            }
        }

        static void Main(string[] args)
        {
            List<Auto> garage = new List<Auto>();

            while (true)
            {
                Console.WriteLine("\n--- Menu Auto ---");
                Console.WriteLine("1. Inserisci nuova auto");
                Console.WriteLine("2. Mostra tutte le auto");
                Console.WriteLine("3. Suona clacson di tutte le auto");
                Console.WriteLine("4. Chiudi");
                Console.Write("Scelta: ");
                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        Console.Write("Marca: ");
                        string marca = Console.ReadLine();
                        Console.Write("Modello: ");
                        string modello = Console.ReadLine();

                        Console.Write("Tipo (1=Normale, 2=Sportiva): ");
                        string tipo = Console.ReadLine();

                        Auto auto;
                        if (tipo == "2")
                            auto = new AutoSportiva();
                        else
                            auto = new Auto();

                        auto.Marca = marca;
                        auto.Modello = modello;

                        garage.Add(auto);
                        Console.WriteLine("Auto aggiunta!");
                        break;

                    case "2":
                        Console.WriteLine("\nGarage:");
                        foreach (var a in garage)
                        {
                            Console.WriteLine(a); // Polimorfismo ToString()
                        }
                        break;

                    case "3":
                        Console.WriteLine("\nSuonano i clacson:");
                        foreach (var a in garage)
                        {
                            a.SuonaClacson(); // Polimorfismo runtime
                        }
                        break;

                    case "4":
                        return;

                    default:
                        Console.WriteLine("Scelta non valida!");
                        break;
                }
            }
        }
    }
}
