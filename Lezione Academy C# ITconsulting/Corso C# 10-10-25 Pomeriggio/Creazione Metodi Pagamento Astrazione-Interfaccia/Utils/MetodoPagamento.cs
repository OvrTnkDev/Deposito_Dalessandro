using System;

namespace Utils
{
    public abstract class MetodoPagamento : Pagamento
    {
        protected MetodoPagamento(decimal importo) : base(importo) { }
    }
}
