using System;

namespace Utils
{
    // Classe generica di un operatore
    public abstract class DispositivoElettronico
    {
        private string _modello;
        public string Modello
        {
            get => _modello;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _modello = value;
                else
                    Console.WriteLine("Il modello non può essere vuoto!");
            }
        }


        public DispositivoElettronico(string modello)
        {
            Modello = modello;
        }

        public abstract void Avvia();
        public abstract void Spegni();

        // Metodo virtuale, sovrascrivibile dalle sottoclassi
        public virtual void MostraInfo()
        {
            Console.WriteLine($"Modello: {_modello}");
        }
    }
}
