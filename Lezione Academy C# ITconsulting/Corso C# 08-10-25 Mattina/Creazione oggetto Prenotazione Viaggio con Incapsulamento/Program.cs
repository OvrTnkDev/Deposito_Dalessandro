using System;
using Utils;

class Program
{
    static void Main()
    {
        PrenotazioneViaggi viaggio = new PrenotazioneViaggi();

        Console.Write("Inserisci la Destinazione: ");
        string destinazione = Console.ReadLine();
        viaggio.Destinazione = destinazione;

        bool continua = true;

        while (continua)
        {
            Console.Clear();
            Console.WriteLine($"=== GESTIONE DESTINAZIONE {viaggio.Destinazione} ===");
            Console.WriteLine("1. Visualizza stato Destinazione");
            Console.WriteLine("2. Effettua prenotazione");
            Console.WriteLine("3. Annulla prenotazione");
            Console.WriteLine("0. Esci");
            Console.Write("\nScelta: ");

            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    viaggio.VisualizzaStato();
                    break;

                case "2":
                    Console.Write("Quanti posti vuoi prenotare? ");
                    if (int.TryParse(Console.ReadLine(), out int postiPrenotare))
                    {
                        viaggio.EffettuaPrenotazione(postiPrenotare);
                    }
                    else
                    {
                        Console.WriteLine("Numero non valido.");
                    }
                    break;

                case "3":
                    Console.Write("Quanti posti vuoi annullare? ");
                    if (int.TryParse(Console.ReadLine(), out int postiAnnullare))
                    {
                        viaggio.AnnullaPrenotazione(postiAnnullare);
                    }
                    else
                    {
                        Console.WriteLine("Numero non valido.");
                    }
                    break;

                case "0":
                    continua = false;
                    Console.WriteLine("Arrivederci!");
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
