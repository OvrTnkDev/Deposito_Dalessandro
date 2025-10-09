namespace Utils
{
    // Classe specializzata per gestire emergenze
    public class OperatoreEmergenza : Operatore
    {
        private int _livelloUrgenza;
        public int LivelloUrgenza
        {
            get => _livelloUrgenza;
            set
            {
                // Controllo con pattern matching
                if (value is >= 0 and <= 5)
                    _livelloUrgenza = value;
                else
                    Console.WriteLine($"{value} non può essere inserito come livello urgenza!");
            }
        }

        public OperatoreEmergenza(string nome, string turno, int livelloUrgenza)
            : base(nome, turno)
        {
            LivelloUrgenza = livelloUrgenza;
        }

        // Override corretto: stessa firma del metodo base
        public override void EseguiCompito()
        {
            Console.WriteLine($"Operatore {Nome} in servizio ({Turno}).");
            Console.WriteLine($"Gestione Emergenza di livello: {LivelloUrgenza}");
        }
    }
}
