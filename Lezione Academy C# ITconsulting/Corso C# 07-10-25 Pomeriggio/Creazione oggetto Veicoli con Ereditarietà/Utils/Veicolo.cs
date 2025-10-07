namespace Utils
{
    public class Veicolo
    {
        public string Marca;
        public string Modello;

        public Veicolo(string marca, string modello)
        {
            Marca = marca;
            Modello = modello;
        }

        public override string ToString()
        {
            return $"Marca: {Marca}\tModello: {Modello}";
        }
    }
}
