using System;

namespace Utils
{
    public abstract class Pagamento
    {
        protected decimal Importo { get; set; }

        protected Pagamento(decimal importo)
        {
            if (importo > 0)
                Importo = importo;
            else
                throw new ArgumentException("L'importo deve essere maggiore di zero.");
        }

        public abstract void EseguiPagamento();
        public abstract void MostraMetodo();
    }
}
