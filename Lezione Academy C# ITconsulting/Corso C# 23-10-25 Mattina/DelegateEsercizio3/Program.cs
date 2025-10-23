using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

#region ENUM
public enum TipoPagamento {Carta, Paypal, Bonifico}
#endregion

#region INTERFACCE
public interface IPagamento
{
    void Pay(decimal totale);
}

public interface ILogger
{
    void Log(string message);
}

public interface IDiscountPolicy
{
    decimal ApplyDiscount(decimal amount);
}
#endregion

#region ENTITA'
public class CardPayment : IPagamento
{
    public void Pay(decimal totale) => Console.WriteLine($"Pagamento con Carta effettuato: {totale:C}");
}

public class PaypalPayment : IPagamento
{
    public void Pay(decimal totale) => Console.WriteLine($"Pagamento con PayPal effettuato: {totale:C}");
}

public class BonificoPayment : IPagamento
{
    public void Pay(decimal totale) => Console.WriteLine($"Pagamento con Bonifico effettuato: {totale:C}");
}

public class ConsoleLogger : ILogger
{
    public void Log(string message) => Console.WriteLine($"[LOG]: {message}");
}

public class NoDiscount : IDiscountPolicy
{
    public decimal ApplyDiscount(decimal amount) => amount;
}

public class TenPercentDiscount : IDiscountPolicy
{
    public decimal ApplyDiscount(decimal amount) => amount * 0.9m;
}
#endregion

#region FACTORY
public static class PagamentoFactory
{

    public static IPagamento Payment(TipoPagamento tipoPagamento)
    {
        return tipoPagamento switch
        {
            TipoPagamento.Carta => new CardPayment(),
            TipoPagamento.Paypal => new PaypalPayment(),
            TipoPagamento.Bonifico => new BonificoPayment(),
            _ => throw new ArgumentException("Tipo di pagamento non riconosciuto.")
        };
    }
}
#endregion

#region DELEGATE
public delegate void PagamentoCompletatoHandler(string id, decimal totale);
public class PaymentService
{
    private readonly IPagamento _pagamento;
    private readonly ILogger _logger;
    private readonly IDiscountPolicy _discountPolicy;

    public event PagamentoCompletatoHandler OnPagamentoCompletato;

    public PaymentService(IPagamento pagamento, ILogger logger, IDiscountPolicy discountPolicy = null)
    {
        _pagamento = pagamento;
        _logger = logger;
        _discountPolicy = discountPolicy ?? new NoDiscount();
    }

    public void ProcessPayment(string id, decimal totale)
    {
        decimal totaleScontato = _discountPolicy.ApplyDiscount(totale);
        _logger.Log($"Importo originale: {totale:C}, dopo sconto: {totaleScontato:C}");

        _pagamento.Pay(totaleScontato);

        OnPagamentoCompletato?.Invoke(id, totaleScontato);
    }
}
#endregion

#region CLIENT
class Program
{
    static void Main()
    {
        Console.Write("Inserisci importo: ");
        decimal importo = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Scegli metodo pagamento: 1=Carta, 2=PayPal, 3=Bonifico");
        int scelta = int.Parse(Console.ReadLine());
        TipoPagamento tipo = scelta switch
        {
            1 => TipoPagamento.Carta,
            2 => TipoPagamento.Paypal,
            3 => TipoPagamento.Bonifico,
            _ => throw new ArgumentException("Scelta non valida")
        };

        IPagamento pagamento = PagamentoFactory.Payment(tipo);
        ILogger logger = new ConsoleLogger();
        IDiscountPolicy discount = new TenPercentDiscount();

        PaymentService service = new PaymentService(pagamento, logger, discount);

        // Registrazione eventi
        service.OnPagamentoCompletato += (id, totale) => Console.WriteLine($"[EVENT] Pagamento {id} completato: {totale:C}");
        service.OnPagamentoCompletato += (id, totale) => Console.WriteLine($"[EMAIL SIMULATA] Inviata conferma pagamento {id}");

        // Processa pagamento
        service.ProcessPayment(Guid.NewGuid().ToString(), importo);
    }
}

#endregion