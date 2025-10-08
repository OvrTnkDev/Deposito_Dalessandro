namespace Utils
{
    public class Artigliere : Soldato
    {
        private int _calibro;
        public int Calibro
        {
            get
            {
                return _calibro;
            }
            set
            {
                if (value > 0)
                {
                    _calibro = value;
                }
            }
        }

        public Artigliere(string nome, string grado, int anniServizio, int calibro)
            : base(nome, grado, anniServizio)
        {
            Calibro = calibro;
        }
        public override string ToString()
        {
            return base.ToString() + $"Calibro arma: {Calibro}\t";
        }
    }
}