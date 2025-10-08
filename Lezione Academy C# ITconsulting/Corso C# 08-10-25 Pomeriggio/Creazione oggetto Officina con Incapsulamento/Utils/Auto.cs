namespace Utils
{
    public class Auto : Veicolo
    {
        public Auto(string targa)
            : base(targa) { }

        public string Ripara()
        {
            return $"Il Veicolo con Targa : {Targa} controllo Olio, Freni e motore dell'auto.";
        }
    }
}