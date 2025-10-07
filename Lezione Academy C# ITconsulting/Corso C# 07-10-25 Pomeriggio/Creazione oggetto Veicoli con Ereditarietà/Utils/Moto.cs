namespace Utils
{
    public class Moto : Veicolo
    {
        public string TipoManubrio;

        public Moto(string marca, string modello, string tipoManubrio)
            : base(marca, modello)
        {
            TipoManubrio = tipoManubrio;
        }

        public override string ToString()
        {
            return base.ToString() + $"\tManubrio: {TipoManubrio}";
        }
    }
}