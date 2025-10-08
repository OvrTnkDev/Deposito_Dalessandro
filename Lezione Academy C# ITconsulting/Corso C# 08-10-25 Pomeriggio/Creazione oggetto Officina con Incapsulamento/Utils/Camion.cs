namespace Utils
{
    public class Camion : Veicolo
    {
        public Camion(string targa)
            : base(targa) { }
        
        public string Ripara()
        {
            return $"Il Veicolo con Targa : {Targa} controllo Sospensioni, Freni rinforzati e carico del Camion.";
        }
    }
}