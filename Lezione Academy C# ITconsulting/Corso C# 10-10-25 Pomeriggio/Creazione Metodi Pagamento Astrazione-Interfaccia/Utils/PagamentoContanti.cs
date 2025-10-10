using System;

namespace Utils
{
    public class PagamentoContanti : MetodoPagamento
    {
        public PagamentoContanti(decimal importo) : base(importo) { }

        public override void EseguiPagamento() =>
            Console.WriteLine($"Pagamento di {Importo:C} in contanti");

        public override void MostraMetodo() =>
            Console.WriteLine("Metodo di pagamento: Contanti");
    }
}
