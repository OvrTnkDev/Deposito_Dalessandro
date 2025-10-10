namespace Utils
{
    // Classe specializzata per gestire emergenze
    public class Computer : DispositivoElettronico
    {
        public Computer(string modello)
            : base(modello) { }

// Override corretto: stessa firma del metodo base
        public override void Avvia()
        {
            Console.WriteLine($"Il computer: {Modello}, si avvia...");
        }

// Override corretto: stessa firma del metodo base
        public override void Spegni()
        {
            Console.WriteLine($"Il computer: {Modello}, si spegne...");
        }
    }
}
