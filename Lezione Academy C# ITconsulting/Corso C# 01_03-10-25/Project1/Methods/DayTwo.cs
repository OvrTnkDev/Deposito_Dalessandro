namespace Methods
{
    public static class DayTwo
    {
        static bool running = true;
        static Random r = new Random();

        // ===============================
        //  EX 1 – Somma di numeri positivi
        // ===============================
        public static void SommaPositivi()
        {
            float sum = 0;
            while (true)
            {
                Console.Write("Inserisci un numero (negativo per uscire): ");
                if (!float.TryParse(Console.ReadLine(), out float input))
                {
                    Console.WriteLine("Input non valido, riprova.");
                    continue;
                }
                if (input < 0) break;
                sum += input;
            }
            Console.WriteLine($"Somma finale: {sum}");
        }

        // ===============================
        //  EX 2 – Indovina il numero random
        // ===============================
        public static void IndovinaNumero()
        {
            int numeroSegreto = r.Next(1, 101);
            while (true)
            {
                Console.Write("Prova ad indovinare il numero: ");
                if (!int.TryParse(Console.ReadLine(), out int input))
                {
                    Console.WriteLine("Input non valido, riprova.");
                    continue;
                }

                if (input < numeroSegreto)
                    Console.WriteLine("Il numero è più alto!");
                else if (input > numeroSegreto)
                    Console.WriteLine("Il numero è più basso!");
                else
                {
                    Console.WriteLine($"🎯 Hai indovinato! Il numero era {numeroSegreto}");
                    break;
                }
            }
        }

        // ===============================
        //  EX 3 – Simulatore BancoMat
        // ===============================
        public static void BancoMat()
        {
            float saldo = 0;
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- MENU BANCOMAT ---");
                Console.WriteLine("1. Visualizza saldo\n2. Deposita\n3. Preleva\n4. Esci");
                if (!int.TryParse(Console.ReadLine(), out int scelta))
                {
                    Console.WriteLine("Scelta non valida.");
                    continue;
                }

                switch (scelta)
                {
                    case 1:
                        Console.WriteLine($"Saldo attuale: {saldo:0.00}");
                        break;
                    case 2:
                        Console.Write("Quanto vuoi depositare? ");
                        if (float.TryParse(Console.ReadLine(), out float dep) && dep > 0)
                        {
                            saldo += dep;
                            Console.WriteLine($"Deposito di {dep:0.00} effettuato. Nuovo saldo: {saldo:0.00}");
                        }
                        else
                            Console.WriteLine("Importo non valido.");
                        break;
                    case 3:
                        Console.Write("Quanto vuoi prelevare? ");
                        if (float.TryParse(Console.ReadLine(), out float prel) && prel > 0)
                        {
                            if (saldo >= prel)
                            {
                                saldo -= prel;
                                Console.WriteLine($"Hai prelevato {prel:0.00}. Saldo residuo: {saldo:0.00}");
                            }
                            else
                                Console.WriteLine("Saldo insufficiente!");
                        }
                        else
                            Console.WriteLine("Importo non valido.");
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Scelta non valida.");
                        break;
                }
            }
        }

        // ===============================
        //  EX 4 – Indovina password (3 tentativi)
        // ===============================
        public static void IndovinaPassword()
        {
            const int PASSWORD = 1234;
            int tentativi = 3;

            while (tentativi > 0)
            {
                Console.Write("Inserisci la password: ");
                if (!int.TryParse(Console.ReadLine(), out int input))
                {
                    Console.WriteLine("Input non valido.");
                    continue;
                }

                if (input == PASSWORD)
                {
                    Console.WriteLine("Accesso consentito!");
                    return;
                }

                tentativi--;
                Console.WriteLine(tentativi > 0
                    ? $"Password errata. Tentativi rimasti: {tentativi}"
                    : "Hai esaurito i tentativi!");
            }
        }

        // ===============================
        //  EX 5 – Somma multipla (0 per uscire)
        // ===============================
        public static void SommaMultipla()
        {
            int somma = 0;
            while (true)
            {
                Console.Write("Inserisci un numero > 0 (0 per uscire): ");
                if (!int.TryParse(Console.ReadLine(), out int input))
                {
                    Console.WriteLine("Input non valido.");
                    continue;
                }

                if (input == 0)
                {
                    Console.WriteLine($"Somma finale: {somma}");
                    break;
                }
                else if (input > 0)
                {
                    somma += input;
                    Console.WriteLine($"Totale aggiornato: {somma}");
                }
                else
                    Console.WriteLine("Inserisci solo numeri positivi.");
            }
        }

        // ===============================
        //  EX 6 – Calcolatrice base
        // ===============================
        public static void Calcolatrice()
        {
            while (true)
            {
                Console.Write("Operatore (+, -, *, /) o ? per uscire: ");
                if (!char.TryParse(Console.ReadLine(), out char op))
                {
                    Console.WriteLine("Input non valido.");
                    continue;
                }

                if (op == '?')
                {
                    Console.WriteLine("Uscita dalla calcolatrice.");
                    break;
                }

                Console.Write("Inserisci il primo numero: ");
                if (!float.TryParse(Console.ReadLine(), out float n1)) { Console.WriteLine("Errore input."); continue; }

                Console.Write("Inserisci il secondo numero: ");
                if (!float.TryParse(Console.ReadLine(), out float n2)) { Console.WriteLine("Errore input."); continue; }

                switch (op)
                {
                    case '+': Console.WriteLine($"Risultato: {n1 + n2}"); break;
                    case '-': Console.WriteLine($"Risultato: {n1 - n2}"); break;
                    case '*': Console.WriteLine($"Risultato: {n1 * n2}"); break;
                    case '/': Console.WriteLine(n2 == 0 ? "Errore: divisione per zero!" : $"Risultato: {n1 / n2}"); break;
                    default: Console.WriteLine("Operatore non valido."); break;
                }
            }
        }

        // ===============================
        //  EX 7 – Tabellina di moltiplicazione (for)
        // ===============================
        public static void Tabellina()
        {
            Console.Write("Inserisci un numero: ");
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Input non valido.");
                return;
            }

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }

        // ===============================
        //  EX 8 – Media numeri interi (for)
        // ===============================
        public static void MediaNumeri()
        {
            Console.Write("Quanti numeri vuoi inserire? ");
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Input non valido.");
                return;
            }

            float somma = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Inserisci numero {i}: ");
                if (!float.TryParse(Console.ReadLine(), out float val))
                {
                    Console.WriteLine("Input non valido, salto numero.");
                    continue;
                }
                somma += val;
            }

            Console.WriteLine($"Media dei numeri inseriti: {somma / n}");
        }

        // ===============================
        //  EX 9 – Fattoriale
        // ===============================
        public static void Fattoriale()
        {
            Console.Write("Inserisci un numero intero >= 0: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
            {
                Console.WriteLine("Numero non valido.");
                return;
            }

            long f = 1;
            for (int i = 1; i <= n; i++) f *= i;
            Console.WriteLine($"{n}! = {f}");
        }

        // ===============================
        //  EX 10 – Conta lettere e altri caratteri
        // ===============================
        public static void ContaLettere()
        {
            Console.Write("Inserisci una stringa: ");
            string input = Console.ReadLine();

            int lettere = 0, altri = 0;
            foreach (char c in input)
            {
                if (char.IsLetter(c)) lettere++;
                else altri++;
            }
            Console.WriteLine($"Lettere: {lettere} | Altri caratteri: {altri}");
        }

        // ===============================
        //  EX 11 – Rimuovi spazi da stringa
        // ===============================
        public static void RimuoviSpazi()
        {
            Console.Write("Inserisci una stringa: ");
            string s = Console.ReadLine();
            string nuova = "";

            foreach (char c in s)
                if (!char.IsWhiteSpace(c))
                    nuova += c;

            Console.WriteLine($"Senza spazi: {nuova}");
        }

        // ===============================
        //  EX 12 – Conta vocali
        // ===============================
        public static void ContaVocali()
        {
            Console.Write("Inserisci una frase: ");
            string frase = Console.ReadLine().ToLower();
            char[] vocali = { 'a', 'e', 'i', 'o', 'u' };
            int cnt = 0;

            foreach (char c in frase)
                if (Array.Exists(vocali, v => v == c)) cnt++;

            Console.WriteLine($"Numero di vocali: {cnt}");
        }

        // ===============================
        //  EX 13 – Controllo Password complessa
        // ===============================
        public static void CheckPassword()
        {
            Console.Write("Inserisci una password: ");
            string pass = Console.ReadLine().Trim();

            int maiusc = 0, numeri = 0, spazi = 0;

            foreach (char c in pass)
            {
                if (char.IsUpper(c)) maiusc++;
                else if (char.IsDigit(c)) numeri++;
                else if (char.IsWhiteSpace(c)) spazi++;
            }

            Console.WriteLine(maiusc > 0 ? "Contiene maiuscole" : "Nessuna maiuscola");
            Console.WriteLine(numeri > 0 ? "Contiene numeri" : "Nessun numero");
            Console.WriteLine(spazi == 0 ? "Nessuno spazio" : "Contiene spazi");
            Console.WriteLine(pass.Length >= 8 ? "Lunghezza OK" : "Troppo corta");
        }

        // ===============================
        //  EX 14 – Esercizi Utils
        // ===============================
        public static void TestUtils()
        {
            Console.Write("Inserisci il tuo nome: ");
            string name = Console.ReadLine();
            Utils.Hello(name);

            Console.Write("Inserisci un numero per verificare se è pari: ");
            int n = int.Parse(Console.ReadLine());
            Utils.PariDispari(n);

            Console.Write("Inserisci base: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Inserisci esponente: ");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine($"Risultato potenza: {Utils.CalcoloPotenza(b, e)}");

            Console.Write("Inserisci un numero da raddoppiare: ");
            int radd = int.Parse(Console.ReadLine());
            Utils.Raddoppia(ref radd);
            Console.WriteLine($"Risultato raddoppio: {radd}");

            Console.Write("Inserisci giorno: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Inserisci mese: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Inserisci anno: ");
            int y = int.Parse(Console.ReadLine());
            Utils.AggiustaData(ref d, ref m, ref y);
            Console.WriteLine($"Data modificata: {d}-{m}-{y}");

            Console.Write("Inserisci dividendo: ");
            int dividendo = int.Parse(Console.ReadLine());
            Console.Write("Inserisci divisore: ");
            int divisore = int.Parse(Console.ReadLine());
            Utils.Dividi(dividendo, divisore, out float risultato, out float resto);
            Console.WriteLine($"Risultato: {risultato}, Resto: {resto}");
        }
    }
}
