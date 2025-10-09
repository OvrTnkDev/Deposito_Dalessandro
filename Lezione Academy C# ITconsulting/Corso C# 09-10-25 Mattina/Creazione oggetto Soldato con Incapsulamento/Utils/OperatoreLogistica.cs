using System;

namespace Utils
{
    // Classe specializzata per la logistica
    public class OperatoreLogistica : Operatore
    {
        // Campo privato per il numero di consegne
        private int _numeroConsegne;

        // Proprietà pubblica con controllo di validità
        public int NumeroConsegne
        {
            get => _numeroConsegne;
            set
            {
                if (value >= 0)
                    _numeroConsegne = value;
                else
                    Console.WriteLine("Il numero di consegne non può essere negativo!");
            }
        }

        // Costruttore: inizializza le proprietà della classe base e specifiche
        public OperatoreLogistica(string nome, string turno, int numeroConsegne)
            : base(nome, turno)
        {
            NumeroConsegne = numeroConsegne;
        }

        // Override del metodo base: comportamento specifico per la logistica
        public override void EseguiCompito()
        {
            Console.WriteLine($"Operatore Logistica: {Nome} ({Turno})");
            Console.WriteLine($"Coordinamento di {NumeroConsegne} consegne");
        }
    }
}
