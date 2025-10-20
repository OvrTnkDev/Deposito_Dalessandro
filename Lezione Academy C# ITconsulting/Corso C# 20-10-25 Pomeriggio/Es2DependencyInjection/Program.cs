using System;
using System.Collections.Generic;

#region INTERFACES
// FASE 1 : INTERFACCIA PAYMENT
public interface IPaimentGateway
{
    void PaypalGateway(string message);
    void StripeGateway(string message);
}
#endregion

#region CLASSES
// FASE 2 : CLASSE PaymentProcessor CHE IMPLEMENTA L'INTERFACCIA IPaimentGateway
public class PayPalPayment : IPaimentGateway
{
    public void PaypalGateway(string message) => Console.WriteLine($"Processing PayPal payment: {message}");
    public void StripeGateway(string message) => throw new NotImplementedException();
}

public class StripePayment : IPaimentGateway
{
    public void StripeGateway(string message) => Console.WriteLine($"Processing Stripe payment: {message}");
    public void PaypalGateway(string message) => throw new NotImplementedException();
}
// FASE 3 : CLASSE PaymentService RICEVE TRAMITE COSTRUTTORE UN OGGETTO DI TIPO IPaimentGateway
public class PaymentProcessor
{
    // DIPENDENCY INJECTION TRAMITE COSTRUTTORE
    private readonly IPaimentGateway _paymentGateway;
    // INIETTORE L'OGGETTO DI TIPO IGREETER
    public PaymentProcessor(IPaimentGateway paymentGateway)
    {
        _paymentGateway = paymentGateway;
    }
    // METODO CHE UTILIZZA L'OGGETTO INIETTATO
    public void CheckPayment(int choice, string message)
    {
        if (choice == 1) _paymentGateway.PaypalGateway(message);
        else if (choice == 2) _paymentGateway.StripeGateway(message);
    }

}
#endregion

#region CLIENT
// FASE 4 : CLIENT CHE ISTANZIA GLI OGGETTI E LI COLLEGA

public class Program
{
    public static void Main (string[] Args)
    {
        Console.WriteLine("Select Payment Method: 1 for PayPal, 2 for Stripe");
        int choice = int.Parse(Console.ReadLine());
        IPaimentGateway paymentGateway;

        if (choice == 1)
        {
            paymentGateway = new PayPalPayment();
        }
        else
        {
            paymentGateway = new StripePayment();
        }

        PaymentProcessor paymentProcessor = new PaymentProcessor(paymentGateway);
        paymentProcessor.CheckPayment(choice, "Order #12345 - $99.99");
    }
}
    #endregion