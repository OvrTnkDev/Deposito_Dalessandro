namespace Utils
{
    public class Moto : Veicolo
    {
        public Moto(string targa)
            : base(targa) { }
        
        public string Ripara()
        {
            return $"Il Veicolo con Targa : {Targa} controllo Catena, Freni e gomme della moto.";
        }
    }
}