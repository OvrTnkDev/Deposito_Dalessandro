using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

//BookHub: Gestione ordini librerie con DI e Factory method
#region INTERFACCIA
// Interfaccia per il servizio di inventario
public interface IInventoryService
{
    bool IsInStock(string title, int quantity);
}
// Interfaccia per il processo di pagamento
public interface IPaymentProcessor
{
    void ProcessPayment(int bookId, decimal amount);
}
// Interfaccia per la strategia di pricing
public interface IPricingStrategy
{
    decimal GetPrice(List<int> bookIds);
}
// Interfaccia per il prodotto libro
public interface IProduct
{
    string Code { get; }
    string Title { get; }
    decimal Price { get; }
    bool IsDigital { get; }
}
#endregion

#region CLASSI PER FACTORY
    // Metodo per creare un digital book
    public class DigitalBook : IProduct
{
    public string Code => "01"; // Codice per digital book
    public string Title => "Digital Book";
    public decimal Price => 19.99m;
    public bool IsDigital => true;
    }

    // Metodo per creare un print book
    public class PrintBook : IProduct
    {
    public string Code => "02"; // Codice per print book
    public string Title => "Print Book";
    public decimal Price => 29.99m;
    public bool IsDigital => false;
    }
#endregion

#region FACTORY METHOD
// Factory method per creare istanze di libri
public static class ProductFactory
{
    public static IProduct BookCreator(string productCode, string title, decimal price)
    {
        // Controllo se il productCode inizia con "01" per digital book
        if (productCode.StartsWith("01"))
        {
            return new DigitalBook();
        }
        // Controllo se il productCode inizia con "02" per print book
        else if (productCode.StartsWith("02"))
        {
            return new PrintBook();
        }
        // Altrimenti lancio un'eccezione
        throw new ArgumentException($"Tipo di libro non valido: {productCode}");
    }
}
#endregion

#region CLASSE SERVICE
// Servizio di gestione ordini
public class OrderService
{

    // Dipendenze iniettate tramite il costruttore
    private readonly IInventoryService _inventoryService;
    private readonly IPaymentProcessor _paymentProcessor;
    private readonly IPricingStrategy _pricingStrategy;
    // Costruttore
    public OrderService(IInventoryService inventoryService, IPaymentProcessor paymentProcessor, IPricingStrategy pricingStrategy)
    {
        _inventoryService = inventoryService;
        _paymentProcessor = paymentProcessor;
        _pricingStrategy = pricingStrategy;
    }


    #endregion

#region CLIENT

    class Program
    {
        static void Main(string[] args)
        {
            // Esempio di utilizzo del factory method
            IProduct digitalBook = ProductFactory.BookCreator("01-12345", "Digital Transformation", 29.99m);
            IProduct printBook = ProductFactory.BookCreator("02-67890", "C# Programming", 49.99m);

            Console.WriteLine($"Created book: {digitalBook.Title}, Price: {digitalBook.Price}");
            Console.WriteLine($"Created book: {printBook.Title}, Price: {printBook.Price}");
        }
    }
}
#endregion