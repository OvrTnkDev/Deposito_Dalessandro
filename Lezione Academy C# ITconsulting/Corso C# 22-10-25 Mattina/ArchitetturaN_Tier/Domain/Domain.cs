using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Domain
{
    #region ENUM
    // tipo speciale in C# che consente di definire un gruppo di valori costanti,leggibili e organizzati.
    public enum OrderStatus { New, Paid, Shipped, Cancelled}
    #endregion

    #region CLASSI (ENTITA')
    // Un record è un tipo di riferimento (reference type) introdotto in C# 9, pensato per rappresentare dati immutabili.
    public record Product(string Code, string Name, decimal Price);
    public class Customer
    {
        public int Id { get; }
        public string Name { get; }
        public string Email { get; }

        public Customer(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }
    public class Order
    {
        //Garantisce che ogni oggetto abbia un Id univoco, senza doverlo passare nel costruttore.
        public Guid Id { get; } = Guid.NewGuid();
        public Customer Customer { get; }
        public List<OrderItem> Items { get; } = new();
        public OrderStatus Status { get; private set; } = OrderStatus.New;

        public Order(Customer customer)
        {
            /* nameof serve per ottenere il nome di variabili, proprietà, metodi o classi come stringa in modo sicuro,
            evitando errori tipografici o problemi durante il refactoring. */
            Customer = customer ?? throw new ArgumentNullException(nameof(customer));
        }

        public void AddItem(OrderItem item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            if (Status != OrderStatus.New) throw new ArgumentNullException();
            Items.Add(item);
        }

        public decimal CalculateTotal() => Items.Sum(i => i.Price * i.Quantity);

        public void ChangeStatus(OrderStatus status) => Status = status;
        public void Pay(bool b) { if (Status == OrderStatus.New) { b = true; } }
        public void Ship(bool b) { if (Status == OrderStatus.Paid) { b = true; } }
        public void Cancel(bool b){if(Status == OrderStatus.Paid && Status != OrderStatus.Shipped){ b=true; }}
    }
    public class OrderItem
    {
        public Product Product { get; }
        public int Quantity { get; }
        public decimal Price => Product.Price;

        public OrderItem(Product product, int quantity)
        {
            // Controlla se product è null.
            Product = product ?? throw new ArgumentNullException(nameof(product));
            Quantity = quantity;
        }
    }
    public record Money(decimal Amount, string Currency = "EUR");

    // Servizio singleton che gestisce tutti gli ordini
    public sealed class OrderManager
    {
        private static readonly Lazy<OrderManager> _lazy = new Lazy<OrderManager>(() => new OrderManager());
        public static OrderManager Instance => _lazy.Value;

        private readonly List<Order> _orders = new();

        private OrderManager() { }

        public void AddOrder(Order order) => _orders.Add(order);
        public IEnumerable<Order> GetAllOrders() => _orders;
    }
    #endregion

        #region INTERFACCE
    public interface IOrderRepo
    {
        // Restituisce tutti gli ordini
        IEnumerable<Order> List();

        // Aggiunge un ordine
        void Add(Order order);

        // Trova un ordine per id
        Order? GetById(Guid Id);
    }
    public interface IProductRepo
    {
         // Restituisce tutti i prodotti
        IEnumerable<Product> List();

        // Aggiunge un prodotto
        void Add(Product product);

        // Trova un prodotto per codice
        Product? GetByCode(string code);
    }
    public interface INotifyServ
    {
        void Notify();
    }
    public interface IClock
    {
        void Time();
    }

    #endregion

}