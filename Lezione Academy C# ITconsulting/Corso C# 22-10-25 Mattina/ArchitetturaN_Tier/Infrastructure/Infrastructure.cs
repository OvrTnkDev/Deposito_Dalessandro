using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Infrastructure
{
    #region IMPLEMENTAZIONE INTERFACCE CONCRETE
    public class OrderRepo : IOrderRepo
    {
        private readonly Dictionary<Guid, Order> _orders = new();

        public IEnumerable<Order> List() => _orders.Values;

        public void Add(Order order)
        {
            if (order == null) throw new ArgumentNullException(nameof(order));
            _orders[order.Id] = order;
        }
        public Order? GetById(Guid id) => _orders.TryGetValue(id, out var o) ? o : null;
    }
    
    public class ProductRepo : IProductRepo
    {
        private readonly Dictionary<string, Product> _products = new(StringComparer.OrdinalIgnoreCase);

        public IEnumerable<Product> List() => _products.Values;

        public void Add(Product product)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));
            _products[product.Code] = product;
        }
        public Product? GetByCode(string code) => _products.TryGetValue(code, out var p) ? p : null;
    }
        public class LogNotify : INotifyServ, IClock
        {
            //DI - Dipendency Injection di Customer
            private readonly Customer _c;
            public void Notify() => Console.WriteLine($"Hai un avviso sulla tua casella postale: {_c.Email}");
            public void Time() => Console.WriteLine($"Inviato alle ore: {DateTime.Now.Hour}");
        }
    }

    #endregion