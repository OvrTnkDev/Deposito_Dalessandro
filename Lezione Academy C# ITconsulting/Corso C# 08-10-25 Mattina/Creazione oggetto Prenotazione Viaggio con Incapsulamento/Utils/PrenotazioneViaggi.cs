using System;

namespace Utils
{
    public class PrenotazioneViaggi
    {
        private int _postiPrenotati;

        public int PostiPrenotati
        {
            get
            {
                return _postiPrenotati;
            }
            set
            {
                if (value >= 0)
                {
                    _postiPrenotati = value;
                }
            }
        }
        
        public string Destinazione { get; set; }

        private const int MaxPosti = 20;

        public int PostiDisponibili
        {
            get
            {
                return MaxPosti - PostiPrenotati;
            }
        }


        public bool EffettuaPrenotazione(int numeroPosti)
        {
            if (numeroPosti <= 0)
            {
                Console.WriteLine("Numero di posti non valido.");
                return false;
            }
            
            if (numeroPosti > PostiDisponibili)
            {
                Console.WriteLine("Non ci sono abbastanza posti liberi.");
                return false;
            }

            PostiPrenotati += numeroPosti;
            Console.WriteLine($"{numeroPosti} posti prenotati con successo.");
            return true;
        }

        // Metodo per annullare prenotazioni
        public bool AnnullaPrenotazione(int numeroPosti)
        {
            if (numeroPosti <= 0 || numeroPosti > PostiPrenotati)
            {
                Console.WriteLine("Numero di posti da annullare non valido.");
                return false;
            }

            PostiPrenotati -= numeroPosti;
            Console.WriteLine($"{numeroPosti} posti annullati con successo.");
            return true;
        }

        // Metodo per visualizzare lo stato del volo
        public void VisualizzaStato()
        {
            Console.WriteLine($"\nDestinazione: {Destinazione}");
            Console.WriteLine($"Posti Prenotati: {PostiPrenotati}");
            Console.WriteLine($"Posti Liberi: {PostiDisponibili}");
        }
    }
}