using System;

namespace Utils
{
    // Classe specializzata per gestire la sicurezza
    public class OperatoreSicurezza : Operatore
    {
        // Campo privato per l'area di sorveglianza
        private string _areaSorvegliata;

        // Proprietà pubblica con controllo di validità
        public string AreaSorvegliata
        {
            get => _areaSorvegliata;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _areaSorvegliata = value;
                else
                    Console.WriteLine("Il campo è vuoto!");
            }
        }

        // Costruttore: inizializza le proprietà eredite e specifiche
        public OperatoreSicurezza(string nome, string turno, string areaSorvegliata)
            : base(nome, turno)
        {
            AreaSorvegliata = areaSorvegliata;
        }

        // Override del metodo base: comportamento specifico per la sicurezza
        public override void EseguiCompito()
        {
            Console.WriteLine($"Operatore di Sicurezza: {Nome} ({Turno})");
            Console.WriteLine($"Sorveglianza nell'area: {AreaSorvegliata}");
        }
    }
}
