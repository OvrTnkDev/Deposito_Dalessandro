using System;

namespace Utils
{
    // Classe generica di un operatore
    public class Operatore
    {
        private string _nome;
        public string Nome
        {
            get => _nome;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _nome = value;
                else
                    Console.WriteLine("Il nome non può essere vuoto!");
            }
        }

        private string _turno;
        public string Turno
        {
            get => _turno;
            set
            {
                // Accetta solo "giorno" o "notte"
                if (!string.IsNullOrEmpty(value) &&
                    (value.ToLower() == "giorno" || value.ToLower() == "notte"))
                    _turno = value;
                else
                    Console.WriteLine($"{value} non può essere inserito come turno!");
            }
        }

        public Operatore(string nome, string turno)
        {
            Nome = nome;
            Turno = turno;
        }

        // Metodo virtuale, sovrascrivibile dalle sottoclassi
        public virtual void EseguiCompito()
        {
            Console.WriteLine("Operatore generico in servizio!");
        }
    }
}
