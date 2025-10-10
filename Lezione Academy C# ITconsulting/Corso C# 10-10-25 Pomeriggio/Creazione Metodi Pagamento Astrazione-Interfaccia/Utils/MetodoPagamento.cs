using System;

namespace Utils
{
    // Classe concreta della classe astratta
    public class MetodoPagamento : Pagamento
    {
        private decimal _importo;
        protected decimal Importo
        {
            get => _importo;
            set
            {
                if (value = 0)
                    _importo = value;
                else
                    Console.WriteLine("Limporto è errato!");
            }
        }


        public MetodoPagamento(decimal importo)
        {
            Importo = importo;
        }

        public override void EseguiPagamento();
        public override void MostraMetodo();
    }
}
