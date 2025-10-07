namespace Utils
{
    public class Auto : Veicolo
    {
        public int NumeroPorte;

        public Auto(string marca, string modello, int numeroPorte)
            : base(marca, modello)
        {
            NumeroPorte = numeroPorte;
        }

        public override string ToString()
        {
            return base.ToString() + $"\tPorte: {NumeroPorte}";
        }
    }
}
