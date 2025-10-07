namespace Utils.Libro
{
    public class Libro
    {
        //Propietà (campi)
        public string Titolo;
        public string Autore;
        public int AnnoDiPubblicazione;

        public Libro(string titolo, string autore, int annoDiPubblicazione)
        {
            Titolo = titolo;
            Autore = autore;
            AnnoDiPubblicazione = annoDiPubblicazione;
        }
        public override string ToString()
        {
            return $"Titolo: {Titolo}\tAutore: {Autore}\tAnno: {AnnoDiPubblicazione}";
        }

        public override bool Equals(Object obj)
        {
            if (obj is Libro altro)
            {
                return this.Titolo == altro.Titolo && this.Autore == altro.Autore;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Titolo, Autore);
        }

    }
}
