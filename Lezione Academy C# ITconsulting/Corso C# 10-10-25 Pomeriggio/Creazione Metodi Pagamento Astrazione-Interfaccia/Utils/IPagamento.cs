using System;

namespace Utils
{
    // Interfaccia
    public interface IPagamento: MetodoPagamento
    {
        private decimal _importo;
        protected decimal Importo
        {
            get => _importo;
            set
            {
                if (value > 0)
                    _importo = value;
                else
                    Console.WriteLine("Limporto è errato!");
            }
        }


        public IPagamento(decimal importo) :base(importo)
        {
            Importo = importo;
        }

        public override void EseguiPagamento();
        public override void MostraMetodo();
    }
}
