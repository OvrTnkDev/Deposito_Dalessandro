//namespace Methods.DayOne
namespace Methods

{
    public static class DayOne
    {
        static bool u = true;
        public static void Somma()
        {
            while (u)
            {
                // Somma Ex.1
                Console.WriteLine("\nInserisci il primo numero: ");
                if (!int.TryParse(Console.ReadLine(), out int v1))
                {
                    Console.WriteLine($"\nNon hai inserito un numero, riprova!");
                    return;
                }
                Console.WriteLine("\nInserisci il secondo numero: ");
                if (!int.TryParse(Console.ReadLine(), out int v2))
                {
                    Console.WriteLine($"\nNon hai inserito un numero, riprova!");
                    return;
                }

                Console.WriteLine($"\nLa somma tra {v1} e {v2} è {v1 + v2}");
                Console.WriteLine($"\n0 per uscire!");
                if (Console.ReadLine() == "0") { u = false; }
            }
        }

        public static void PrezzoSconto()
        {
            while (u)
            {
                // Prezzo sconto Ex.2
                Console.WriteLine($"\nindicami un prezzo da scontare: ");
                if (!double.TryParse(Console.ReadLine(), out double p))
                {
                    Console.WriteLine($"\nNon hai inserito un numero, riprova!");
                    continue;
                }

                Console.WriteLine($"\nindicami lo sconto da applicare: ");
                if (!int.TryParse(Console.ReadLine(), out int s))
                {
                    Console.WriteLine($"\nNon hai inserito un numero, riprova!");
                    continue;
                }

                Console.WriteLine($"\nIl prezzo originale era {p}");
                Console.WriteLine($"\nEd ora con uno sconto del {s}% è {p - (p * s / 100)}");
                Console.WriteLine($"\n0 per uscire!");
                if (Console.ReadLine() == "0") { u = false; }
            }
        }

        public static void NumeroPositivo()
        {
            while (u)
            {
                // Controllo numero positivo Ex.3
                Console.WriteLine($"indicami un numero per vedere se è positivo o meno: ");
                if (!float.TryParse(Console.ReadLine(), out float n))
                {
                    Console.WriteLine($"\nNon hai inserito un numero, riprova!");
                    continue;
                }

                bool verify = n > 0;

                if (n > 0)
                {
                    Console.WriteLine($"\nIl numero è positivo? {verify}");
                }
                else
                {
                    Console.WriteLine($"\nIl numero è positivo? {verify}");
                }
                Console.WriteLine($"\n0 per uscire!");
                if (Console.ReadLine() == "0") { u = false; }
            }
        }

        public static void EtaAltezza()
        {
            while (u)
            {
                // età e altezza Ex.5
                Console.WriteLine($"\nindicami la tua età: ");
                if (!int.TryParse(Console.ReadLine(), out int e))
                {
                    Console.WriteLine($"\nNon hai inserito un numero, riprova!");
                    return;
                }

                Console.WriteLine($"\nindicami la tua altezza in metri: ");
                if (!float.TryParse(Console.ReadLine(), out float a))
                {
                    Console.WriteLine($"\nNon hai inserito un numero, riprova!");
                    continue;
                }

                Console.WriteLine($"\nLa somma tra {e} e {a} è {Convert.ToInt32(e + a)}");
                Console.WriteLine($"\n0 per uscire!");
                if (Console.ReadLine() == "0") { u = false; }
            }
        }

        public static void MaggioreEta()
        {
            while (u)
            {
                // Esercizio 1: Comparazione per la maggiore età
                const int AGE_M = 18;
                Console.Write("\nIndicami la tua età e ti dirò se sei Maggiorenne: ");
                if (!int.TryParse(Console.ReadLine(), out int a))
                {
                    Console.WriteLine($"Non hai inserito un numero, riprova!");
                    continue;
                }

                //Uso operatore Ternario e lo incapsulo in una variabile
                string m = (a >= AGE_M) ? "Sei maggiorenne" : "Sei minorenne";
                Console.WriteLine(m);
                Console.WriteLine($"\n0 per uscire!");
                if (Console.ReadLine() == "0") { u = false; }
            }
        }

        public static void Sconto100()
        {
            while (u)
            {
                // Esercizio 2: Sconto oltre i 100 euro
                Console.Write("Indicami il prezzo del prodotto: ");
                if (!double.TryParse(Console.ReadLine(), out double p))
                {
                    Console.WriteLine($"Non hai inserito un numero, riprova!");
                    continue;
                }
                else
                {
                    Console.WriteLine($"Il prezzo iniziale è {p:0.00}");
                    if (p > 100)
                    {
                        double discountedPrice = p * 0.9; // 10% di sconto
                        Console.WriteLine($"È stato applicato uno sconto del 10%, prezzo finale: {discountedPrice:0.00}");
                    }
                    else
                    {
                        Console.WriteLine("Non è stato applicato nessuno sconto poiché l'acquisto non supera i 100$");
                    }
                    Console.WriteLine($"\n0 per uscire!");
                    if (Console.ReadLine() == "0") { u = false; }
                }
            }
        }

        public static void TentaLaMedia()
        {
            while (u)
            {
                // Esercizio 3: Supera la media
                Console.Write("Indicami il primo numero: ");
                if (!double.TryParse(Console.ReadLine(), out double n1))
                {
                    Console.WriteLine($"Non hai inserito un numero, riprova!");
                    continue;
                }
                else
                {
                    Console.Write("Indicami il secondo numero: ");
                    if (!double.TryParse(Console.ReadLine(), out double n2))
                    {
                        Console.WriteLine($"Non hai inserito un numero, riprova!");
                        continue;
                    }
                    else
                    {
                        Console.Write("Indicami il terzo numero: ");
                        if (!double.TryParse(Console.ReadLine(), out double n3))
                        {
                            Console.WriteLine($"Non hai inserito un numero, riprova!");
                            continue;
                        }
                        else
                        {
                            var average = (n1 + n2 + n3) / 3;

                            if (average > 60)
                            {
                                Console.WriteLine($"Hai superato la Prova! {(average)}");
                            }
                            else
                            {
                                Console.WriteLine($"Non hai superato la Prova! Ritenta!! {average}");
                            }
                        }
                    }
                    Console.WriteLine($"\n0 per uscire!");
                    if (Console.ReadLine() == "0") { u = false; }
                }
            }
        }

        public static void PariDispari()
        {
            while (u)
            {
                // Esercizio 4: Pari dispari
                Console.Write("Indicami il un numero: ");
                if (!int.TryParse(Console.ReadLine(), out int m))
                {
                    Console.WriteLine($"Non hai inserito un numero, riprova!");
                    continue;
                }
                else
                {
                    if ((m % 2) == 0)
                    {
                        Console.WriteLine($"{m} è pari");
                    }
                    else
                    {
                        Console.WriteLine($"{m} è dispari");
                    }
                    Console.WriteLine($"\n0 per uscire!");
                    if (Console.ReadLine() == "0") { u = false; }
                }
            }
        }

        public static void IndovinaLaPasword()
        {
            const int PSWD_INIT = 7865;
            while (u)
            {
                // Esercizio 4: Indovina la password
                Console.Write("Indicami la password numerica: ");
                if (!int.TryParse(Console.ReadLine(), out int p))
                {
                    Console.WriteLine($"Non hai inserito un numero, riprova!");
                    continue;
                }
                else
                {
                    if (p == PSWD_INIT)
                    {
                        Console.WriteLine($"Accesso consentito!!");
                    }
                    else
                    {
                        Console.WriteLine($"Accesso negato!!");
                    }
                    Console.WriteLine($"\n0 per uscire!");
                    if (Console.ReadLine() == "0") { u = false; }
                }
            }
        }
        
        public static void Calcolatrice()
        {
            while (u)
            {
                // Esercizio 5: Calcolatrice + -
                Console.Write("Indicami il primo numero: ");
                if (!double.TryParse(Console.ReadLine(), out double p))
                {
                    Console.WriteLine($"Non hai inserito un numero, riprova!");
                    continue;
                }
                else
                {
                    Console.Write("Indicami il secondo numero: ");
                    if (!double.TryParse(Console.ReadLine(), out double s))
                    {
                        Console.WriteLine($"Non hai inserito un numero, riprova!");
                        continue;
                    }

                    Console.Write("Indicami se vuoi addizionare o sottrarre con il segno aritmetico: ");
                    char sign = char.Parse(Console.ReadLine());

                    if (sign == '+')
                    {
                        Console.WriteLine($"Hai scelto l'addizione, il risultato è: {p + s}");
                    }
                    else if (sign == '-')
                    {
                        Console.WriteLine($"Hai scelto la sottrazione, il risultato è: {p - s}");
                    }
                    else
                    {
                        Console.WriteLine($"Operatore non valido!");
                        continue;
                    }

                    Console.WriteLine($"\n0 per uscire!");
                    if (Console.ReadLine() == "0") { u = false; }
                }
            }
        }
    }
}