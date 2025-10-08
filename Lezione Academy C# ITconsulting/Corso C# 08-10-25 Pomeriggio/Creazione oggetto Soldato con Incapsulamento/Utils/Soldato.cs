using System;

namespace Utils
{
    public class Soldato
    {
        private string _nome;
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _nome = value;
                }
            }
        }

        private string _grado;
        public string Grado
        {
            get
            {
                return _grado;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _grado = value;
                }
            }
        }
        
        private int _anniServizio;
        public int AnniServizio
        {
            get
            {
                return _anniServizio;
            }
            set
            {
                if (value > 0)
                {
                    _anniServizio = value;
                }
            }
        }

        public Soldato(string nome, string grado, int anniServizio)
        {
            Nome = nome;
            Grado = grado;
            AnniServizio = anniServizio;
        }

        public override string ToString()
        {
            return $"Nome Soldato: {Nome}\t" +
                   $"Grado Soldato: {Grado}\t" +
                   $"Anni di servizio: {AnniServizio}\t";
        }
    }
}