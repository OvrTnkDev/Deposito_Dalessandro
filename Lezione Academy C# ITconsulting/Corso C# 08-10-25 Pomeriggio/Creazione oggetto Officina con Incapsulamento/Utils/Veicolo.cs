using System;

namespace Utils
{
    public class Veicolo
    {
        private string _targa;
        public string Targa
        {
            get
            {
                return _targa;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _targa = value;
                }
            }
        }

        public Veicolo(string targa)
        {
            Targa = targa;
        }

        public string Ripara()
        {
            return $"Il Veicolo con Targa : {Targa} viene controllato.";
        }
    }
}