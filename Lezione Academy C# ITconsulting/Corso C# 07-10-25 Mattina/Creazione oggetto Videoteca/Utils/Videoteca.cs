namespace Utils.Videoteca
{
    public class Videoteca
    {
        //Propietà (campi)
        public string Titolo;
        public string Regista;
        public int Anno;
        public string Genere;

        public Videoteca(string titolo, string regista, int anno, string genere)
        {
            Titolo = titolo;
            Regista = regista;
            Anno = anno;
            Genere = genere;
        }

        public object[] GetFilmArray()
        {
            return new object[] { Titolo, Regista, Anno, Genere };
        }

        public override string ToString()
        {
            return $"Titolo: {Titolo}\nRegista: {Regista}\tAnno: {Anno}\tGenere: {Genere}";
        }
    }
}
