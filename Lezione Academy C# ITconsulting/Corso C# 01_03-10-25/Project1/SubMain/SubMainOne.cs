using System.Security.Cryptography.X509Certificates;
using Methods;

namespace SubMain.SubMainOne
{
    public class SubMainOne
    {
        public static void DayOne1()
        {
            bool c = true;
            while (c)
            {
                Console.WriteLine("---- MENU DAY ONE ----\n" +
                                    $"1. Somma\n" +
                                  $"2. Prezzo scontato\n" +
                                  $"3. Controllo numero positivo\n" +
                                  $"4. Somma età e altezza\n" +
                                  $"5. Sconto 10% oltre i 100$\n" +
                                  $"6. Tenta la media\n" +
                                  $"7. Pari o Dispari?\n" +
                                  $"8. Indovina la Password!\n" +
                                  $"9. Calcolatrice + e -\n" +
                                  $"0. Esci\n");
                Console.Write("Scelta: ");

                if (!int.TryParse(Console.ReadLine(), out int s))
                {
                    Console.WriteLine($"\nNon hai inserito un numero, riprova!\n");
                    continue;
                }
                else
                {
                    switch (s)
                    {
                        case 0:
                            Console.WriteLine($"\nHai scelto {s}. Esci\n\nBye.\n");
                            c = false;
                            break;

                        case 1:
                            Console.WriteLine($"\nHai scelto {s}. Somma\n");
                            DayOne.Somma();
                            break;

                        case 2:
                            Console.WriteLine($"\nHai scelto {s}. Prezzo scontato\n");
                            DayOne.PrezzoSconto();
                            break;

                        case 3:
                            Console.WriteLine($"\nHai scelto {s}. Controllo numero positivo\n");
                            DayOne.NumeroPositivo();
                            break;

                        case 4:
                            Console.WriteLine($"\nHai scelto {s}. Somma età e altezza\n");
                            DayOne.EtaAltezza();
                            break;

                        case 5:
                            Console.WriteLine($"\nHai scelto {s}. Sconto 10% oltre i 100$\n");
                            DayOne.Sconto100();
                            break;

                        case 6:
                            Console.WriteLine($"\nHai scelto {s}. Tenta la media\n");
                            DayOne.TentaLaMedia();
                            break;

                        case 7:
                            Console.WriteLine($"\nHai scelto {s}. Pari o Dispari?\n");
                            DayOne.PariDispari();
                            break;

                        case 8:
                            Console.WriteLine($"\nHai scelto {s}. Indovina la password!\n");
                            DayOne.IndovinaLaPasword();
                            break;

                        case 9:
                            Console.WriteLine($"\nHai scelto {s}. Calcolatrice + e -\n");
                            DayOne.Calcolatrice();
                            break;

                        default:
                            Console.WriteLine($"\nLa scelta immessa non esiste!!\n");
                            break;
                    }
                }
                Console.WriteLine("\nPremi INVIO per tornare al menu...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static void DayTwo2()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine(
                    "---- MENU DAY TWO ----\n" +
                    "1. Somma numeri positivi\n" +
                    "2. Indovina il numero random\n" +
                    "3. BancoMat (saldo, deposito, prelievo)\n" +
                    "4. Indovina la password (3 tentativi)\n" +
                    "5. Somma multipla (0 per uscire)\n" +
                    "6. Calcolatrice (+, -, *, /)\n" +
                    "7. Tabellina di moltiplicazione\n" +
                    "8. Media numeri interi\n" +
                    "9. Fattoriale\n" +
                    "10. Conta lettere e altri caratteri\n" +
                    "11. Rimuovi spazi da stringa\n" +
                    "12. Conta vocali\n" +
                    "13. Controllo password complessa\n" +
                    "14. Esercizi Utils\n" +
                    "0. Esci"
                );

                Console.Write("\nScelta: ");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("\nInput non valido! Riprova.\n");
                    continue;
                }

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("\nHai scelto 0. Esci.\nBye.\n");
                        running = false;
                        break;

                    case 1:
                        Console.WriteLine("\nHai scelto 1. Somma numeri positivi\n");
                        DayTwo.SommaPositivi();
                        break;

                    case 2:
                        Console.WriteLine("\nHai scelto 2. Indovina il numero random\n");
                        DayTwo.IndovinaNumero();
                        break;

                    case 3:
                        Console.WriteLine("\nHai scelto 3. BancoMat (saldo, deposito, prelievo)\n");
                        DayTwo.BancoMat();
                        break;

                    case 4:
                        Console.WriteLine("\nHai scelto 4. Indovina la password (3 tentativi)\n");
                        DayTwo.IndovinaPassword();
                        break;

                    case 5:
                        Console.WriteLine("\nHai scelto 5. Somma multipla (0 per uscire)\n");
                        DayTwo.SommaMultipla();
                        break;

                    case 6:
                        Console.WriteLine("\nHai scelto 6. Calcolatrice (+, -, *, /)\n");
                        DayTwo.Calcolatrice();
                        break;

                    case 7:
                        Console.WriteLine("\nHai scelto 7. Tabellina di moltiplicazione\n");
                        DayTwo.Tabellina();
                        break;

                    case 8:
                        Console.WriteLine("\nHai scelto 8. Media numeri interi\n");
                        DayTwo.MediaNumeri();
                        break;

                    case 9:
                        Console.WriteLine("\nHai scelto 9. Fattoriale\n");
                        DayTwo.Fattoriale();
                        break;

                    case 10:
                        Console.WriteLine("\nHai scelto 10. Conta lettere e altri caratteri\n");
                        DayTwo.ContaLettere();
                        break;

                    case 11:
                        Console.WriteLine("\nHai scelto 11. Rimuovi spazi da stringa\n");
                        DayTwo.RimuoviSpazi();
                        break;

                    case 12:
                        Console.WriteLine("\nHai scelto 12. Conta vocali\n");
                        DayTwo.ContaVocali();
                        break;

                    case 13:
                        Console.WriteLine("\nHai scelto 13. Controllo password complessa\n");
                        DayTwo.CheckPassword();
                        break;

                    case 14:
                        Console.WriteLine("\nHai scelto 14. Esercizi Utils\n");
                        DayTwo.TestUtils();
                        break;

                    default:
                        Console.WriteLine("\nScelta inesistente! Riprova.\n");
                        break;
                }

                Console.WriteLine("\nPremi INVIO per tornare al menu...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static void DayThree3()
        {
                        bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("---- MENU DAY THREE ----\n" +
                                  "1. Somma tra numeri (int, float, double)\n" +
                                  "2. Analizza testo (caratteri senza spazi)\n" +
                                  "3. Analizza testo per lettera specifica\n" +
                                  "4. Analizza vocali/consonanti (bool)\n" +
                                  "5. Matrici (dimensioni personalizzate)\n" +
                                  "6. Array casuale\n" +
                                  "7. Array riordinato\n" +
                                  "8. Matrici 4x4 e 5x5\n" +
                                  "9. Creazione e gestione Liste\n" +
                                  "0. Esci\n");

                Console.Write("Scelta: ");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("\nInput non valido! Riprova.");
                    Console.WriteLine("Premi INVIO per tornare al menu principale...");
                    Console.ReadLine();
                    continue;
                }

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("\nHai scelto 0. Esci.\nBye.\n");
                        running = false;
                        break;

                    case 1:
                        Console.WriteLine("\nHai scelto 1. Somma tra numeri\n");
                        DayThree.SommaGiorno3();
                        break;

                    case 2:
                        Console.WriteLine("\nHai scelto 2. Analizza testo (caratteri senza spazi)\n");
                        DayThree.AnalizzaTesto();
                        break;

                    case 3:
                        Console.WriteLine("\nHai scelto 3. Analizza testo per lettera specifica\n");
                        DayThree.AnalizzaLettera();
                        break;

                    case 4:
                        Console.WriteLine("\nHai scelto 4. Analizza vocali/consonanti (bool)\n");
                        DayThree.AnalizzaVocaliConsonanti();
                        break;

                    case 5:
                        Console.WriteLine("\nHai scelto 5. Matrici (dimensioni personalizzate)\n");
                        DayThree.MatriciPersonalizzate();
                        break;

                    case 6:
                        Console.WriteLine("\nHai scelto 6. Array casuale\n");
                        DayThree.ArrayCasuale();
                        break;

                    case 7:
                        Console.WriteLine("\nHai scelto 7. Array riordinato\n");
                        DayThree.ArrayRiordinato();
                        break;

                    case 8:
                        Console.WriteLine("\nHai scelto 8. Matrici 4x4 e 5x5\n");
                        DayThree.MatriciPredefinite();
                        break;

                    case 9:
                        Console.WriteLine("\nHai scelto 9. Creazione e gestione Liste\n");
                        DayThree.GestisciListe();
                        break;

                    default:
                        Console.WriteLine("\nScelta inesistente! Riprova.\n");
                        break;
                }

                Console.WriteLine("\nPremi INVIO per tornare al menu principale...");
                Console.ReadLine();
            }
        }
    }
}