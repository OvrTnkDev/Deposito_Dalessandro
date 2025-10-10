using System;

namespace Utils
{
    public class PagamentoPayPal : MetodoPagamento
    {
        protected string EmailUtente { get; }

        public PagamentoPayPal(decimal importo, string emailUtente) : base(importo)
        {
            if (!string.IsNullOrEmpty(emailUtente) && emailUtente.Contains('@'))
                EmailUtente = emailUtente;
            else
                throw new ArgumentException("Email non valida o mancante '@'.");
        }

        public override void EseguiPagamento() =>
            Console.WriteLine($"Pagamento di {Importo:C} tramite PayPal ({EmailUtente})");

        public override void MostraMetodo() =>
            Console.WriteLine("Metodo di pagamento: PayPal");
    }
}
