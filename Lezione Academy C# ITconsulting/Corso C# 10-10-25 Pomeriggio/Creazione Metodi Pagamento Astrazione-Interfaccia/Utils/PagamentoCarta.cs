using System;

namespace Utils
{
    // Interfaccia
    public class  PagamentoCarta : IPagamento
    {
        private string _circuito;
        protected string Circuito
        {
            get => _circuito;
            set
            {
                if (!string.IsNullOrEmpty(value) && (value.ToLower="visa" || value.ToLower="mastercard"))
                    _circuito = value;
                else
                    Console.WriteLine("Il campo è vuoto oppure il circuito è errato!");
            }
        }


        public PagamentoCarta(decimal importo, string circuito) :base(importo)
        {
            Circuito = circuito;
        }

        public override void EseguiPagamento()=> Console.WriteLine($"Pagamento di {Importo}£ con carta (circuito: {Circuito})");
        public override void MostraMetodo() => Console.WriteLine($"Metodo di pagamento: Carta di credito");
    }
}
