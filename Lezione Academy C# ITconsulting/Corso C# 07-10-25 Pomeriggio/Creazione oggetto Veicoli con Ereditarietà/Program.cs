using Utils;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        bool check = true;
        var corsoM = new List<Utils.CorsoMusica>();
        var corsoP = new List<Utils.CorsoPittura>();
        var corsoD = new List<Utils.CorsoDanza>();
        List<string> studenti = new List<string>();

        while (check)
        {
            Console.Clear();
            Console.WriteLine("Benvenuto nella scelta dei corsi!\n");
            Console.WriteLine("MENU PRINCIPALE");
            Console.WriteLine("1. Aggiungi un corso di Musica");
            Console.WriteLine("2. Aggiungi un corso di Pittura");
            Console.WriteLine("3. Aggiungi un corso di Danza");
            Console.WriteLine("4. Aggiungi studente a un corso");
            Console.WriteLine("5. Visualizza tutti i corsi");
            Console.WriteLine("6. Cerca corsi per nome docente");
            Console.WriteLine("7. Esegui metodo speciale di un corso");
            Console.WriteLine("0. Esci\n");

            Console.Write("Scelta: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    check = false;
                    Console.WriteLine("Arrivederci!");
                    break;

                case "1":
                    bool check1 = true;
                    bool check2 = true;

                    while (check1)
                    {
                        Console.Write("Inserisci 0 per uscire altrimenti 1: ");
                        char contr = char.Parse(Console.ReadLine());

                        if (contr == '0')
                        {
                            Console.WriteLine($"Stai per uscire.");
                            check1 = false;
                        }
                        else
                        {
                            Console.Write("\nInserisci il nome del Corso di Musica: ");
                            string nomeCorso = Console.ReadLine();

                            Console.Write("Inserisci la durata Ore: ");
                            int durata = int.Parse(Console.ReadLine());

                            Console.Write("\nInserisci il nome del Docente: ");
                            string docente = Console.ReadLine();

                            Console.Write("\nInserisci lo strumento: ");
                            string strumento = Console.ReadLine();

                            while (check2)
                            {
                                Console.Write("Inserisci lo studente (inserisci 0 per uscire): ");
                                string studente = Console.ReadLine();

                                if (studente != "0") { studenti.Add(studente); }
                                else { Console.WriteLine($"Stai per uscire!"); check2 = false; }
                            }
                            var corso = new CorsoMusica(nomeCorso, durata, docente, studenti, strumento);
                            corsoM.Add(corso);
                            corsoM.ForEach(c => Console.WriteLine(c));
                        }
                    }

                    Console.WriteLine("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;

                case "2":
                    check1 = true;
                    check2 = true;

                    while (check1)
                    {
                        Console.Write("Inserisci 0 per uscire altrimenti 1: ");
                        char contr = char.Parse(Console.ReadLine());

                        if (contr == '0')
                        {
                            Console.WriteLine($"Stai per uscire.");
                            check1 = false;
                        }
                        else
                        {
                            Console.Write("\nInserisci il nome del Corso di Pittura: ");
                            string nomeCorso = Console.ReadLine();

                            Console.Write("Inserisci la durata Ore: ");
                            int durata = int.Parse(Console.ReadLine());

                            Console.Write("\nInserisci il nome del Docente: ");
                            string docente = Console.ReadLine();

                            Console.Write("\nInserisci la Tecnica: ");
                            string tecnica = Console.ReadLine();

                            while (check2)
                            {
                                Console.Write("Inserisci lo studente (inserisci 0 per uscire): ");
                                string studente = Console.ReadLine();

                                if (studente != "0") { studenti.Add(studente); }
                                else { Console.WriteLine($"Stai per uscire!"); check2 = false; }
                            }
                            var corso = new CorsoPittura(nomeCorso, durata, docente, studenti, tecnica);
                            corsoP.Add(corso);
                            corsoP.ForEach(c => Console.WriteLine(c));
                        }
                    }

                    Console.WriteLine("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;

                case "3":
                    check1 = true;
                    check2 = true;

                    while (check1)
                    {
                        Console.Write("Inserisci 0 per uscire altrimenti 1: ");
                        char contr = char.Parse(Console.ReadLine());

                        if (contr == '0')
                        {
                            Console.WriteLine($"Stai per uscire.");
                            check1 = false;
                        }
                        else
                        {
                            Console.Write("\nInserisci il nome del Corso di Danza: ");
                            string nomeCorso = Console.ReadLine();

                            Console.Write("Inserisci la durata Ore: ");
                            int durata = int.Parse(Console.ReadLine());

                            Console.Write("\nInserisci il nome del Docente: ");
                            string docente = Console.ReadLine();

                            Console.Write("\nInserisci lo Stile: ");
                            string stile = Console.ReadLine();

                            while (check2)
                            {
                                Console.Write("Inserisci lo studente (inserisci 0 per uscire): ");
                                string studente = Console.ReadLine();

                                if (studente != "0") { studenti.Add(studente); }
                                else { Console.WriteLine($"Stai per uscire!"); check2 = false; }
                            }
                            var corso = new CorsoDanza(nomeCorso, durata, docente, studenti, stile);
                            corsoD.Add(corso);
                            corsoD.ForEach(c => Console.WriteLine(c));
                        }
                    }

                    Console.WriteLine("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Scelta non valida. Riprova.");
                    break;
            }
        }
    }
}