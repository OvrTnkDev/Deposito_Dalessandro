using System;

namespace Utils
{
    public class PagamentoCarta : MetodoPagamento
    {
        protected string Circuito { get; }

        public PagamentoCarta(decimal importo, string circuito) : base(importo)
        {
            if (!string.IsNullOrEmpty(circuito) &&
                (circuito.ToLower() == "visa" || circuito.ToLower() == "mastercard"))
                Circuito = circuito;
            else
                throw new ArgumentException("Circuito non valido (usa visa o mastercard).");
        }

        public override void EseguiPagamento() =>
            Console.WriteLine($"Pagamento di {Importo:C} con carta {Circuito}");

        public override void MostraMetodo() =>
            Console.WriteLine("Metodo di pagamento: Carta di credito");
    }
}
