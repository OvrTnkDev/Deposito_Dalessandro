using System;

namespace Utils
{
    // Interfaccia
    public class  PagamentoContanti : IPagamento
    {
        public PagamentoContanti(decimal importo) :base(importo)
        {}

        public override void EseguiPagamento()=> Console.WriteLine($"Pagamento di {Importo}£ in contanti");
        public override void MostraMetodo() => Console.WriteLine($"Metodo di pagamento: Contanti");
    }
}
