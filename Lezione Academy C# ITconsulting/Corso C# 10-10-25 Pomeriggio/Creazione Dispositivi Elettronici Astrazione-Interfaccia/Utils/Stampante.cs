namespace Utils
{
    // Classe specializzata per gestire emergenze
    public class Stampante : DispositivoElettronico
    {
        public Stampante(string modello)
            : base(modello) { }

// Override corretto: stessa firma del metodo base
        public override void Avvia()
        {
            Console.WriteLine($"La stampante: {Modello}, si accende...");
        }

// Override corretto: stessa firma del metodo base
        public override void Spegni()
        {
            Console.WriteLine($"La stampante: {Modello}, va in StandBy...");
        }
    }
}
