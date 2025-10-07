using System;
using System.Collections.Generic;
using Utils.Videoteca;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        bool check = true;
        var catalogo = new List<Videoteca>();

        while (check)
        {
            Console.Clear();
            Console.WriteLine("Benvenuto nella tua videoteca!\n");
            Console.WriteLine("MENU PRINCIPALE");
            Console.WriteLine("1. Aggiungi un nuovo film");
            Console.WriteLine("2. Mostra tutti i film");
            Console.WriteLine("3. Ricerca per Genere");
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
                    bool continua = true;

                    while (continua)
                    {
                        Console.Write("\nInserisci il Titolo: ");
                        string titolo = Console.ReadLine();

                        Console.Write("Inserisci il Regista: ");
                        string regista = Console.ReadLine();

                        Console.Write("Inserisci l'Anno: ");
                        if (!int.TryParse(Console.ReadLine(), out int anno))
                        {
                            Console.WriteLine("Anno non valido. Riprova.");
                            continue;
                        }

                        Console.Write("Inserisci il Genere: ");
                        string genere = Console.ReadLine();

                        var film = new Videoteca(titolo, regista, anno, genere);
                        catalogo.Add(film);

                        Console.WriteLine("\nFilm aggiunto con successo!");
                        Console.Write("Vuoi inserire un altro film? (Si/No): ");
                        string risposta = Console.ReadLine()?.ToLower();

                        if (risposta != "si")
                        {
                            continua = false;
                        }
                    }
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("Catalogo Film\n");

                    if (catalogo.Count == 0)
                    {
                        Console.WriteLine("Nessun film presente nella videoteca.");
                    }
                    else
                    {
                        int i = 1;
                        foreach (var film in catalogo)
                        {
                            Console.WriteLine($"{i++}. {film}\n");
                        }
                    }

                    Console.WriteLine("Premi un tasto per tornare al menu...");
                    Console.ReadKey();
                    break;

                case "3":
                    Console.Write("Inserisci il genere interessato: ");
                    string gen = Console.ReadLine()?.ToLower();

                    Console.WriteLine("\nFilm trovati:\n");

                    if (catalogo.Count == 0)
                    {
                        Console.WriteLine("Nessun film presente nella videoteca.");
                    }
                    else
                    {
                        int i = 1;
                        bool trovato = false;
                        foreach (var film in catalogo)
                        {
                            if (film.Genere.ToLower() == gen)
                            {
                                Console.WriteLine($"{i++}. {film}\n");
                                trovato = true;
                            }
                        }

                        if (!trovato)
                        {
                            Console.WriteLine("Nessun film presente con questo genere.");
                        }
                    }

                    Console.WriteLine("Premi un tasto per tornare al menu...");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Scelta non valida. Riprova.");
                    break;
            }
        }
    }
}