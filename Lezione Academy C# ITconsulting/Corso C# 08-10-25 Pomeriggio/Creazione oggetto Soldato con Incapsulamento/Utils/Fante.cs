namespace Utils
{
    public class Fante : Soldato
    {
        private string _arma;
        public string Arma
        {
            get
            {
                return _arma;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _arma = value;
                }
            }
        }

        public Fante(string nome, string grado, int anniServizio, string arma)
            : base(nome, grado, anniServizio)
        {
            Arma = arma;
        }
        
        public override string ToString()
        {
            return base.ToString() + $"Arma Soldato: {Arma}\t";
        }
    }
}