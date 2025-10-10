using System;

namespace Utils
{
    // Interfaccia
    public class  PagamentoPayPal : IPagamento
    {
        private string _emailUtente;
        protected string EmailUtente
        {
            get => _emailUtente;
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Contains('@'))
                    _emailUtente = value;
                else
                    Console.WriteLine("Il campo è vuoto oppure hai dimenticato la @!");
            }
        }


        public PagamentoPayPal(decimal importo, string emailUtente) :base(importo)
        {
            EmailUtente = emailUtente;
        }

        public override void EseguiPagamento()=> Console.WriteLine($"Pagamento di {Importo}£ con PayPal da: {EmailUtente}");
        public override void MostraMetodo() => Console.WriteLine($"Metodo di pagamento: PayPal");
    }
}
