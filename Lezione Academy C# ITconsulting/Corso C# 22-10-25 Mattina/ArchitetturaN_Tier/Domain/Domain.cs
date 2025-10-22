using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    #region INTERFACCE
    public interface IOrderRepo
    { }
    public interface IProductRepo
    { }
    public interface INotifyServ
    {
        void Notify(string message);
    }
    public interface IClock
    {
        void Time();
    }

    #endregion

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
            Items.Add(item);
        }

        public decimal CalculateTotal() => Items.Sum(i => i.Price * i.Quantity);

        public void ChangeStatus(OrderStatus status) => Status = status;
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
    
    #endregion
}