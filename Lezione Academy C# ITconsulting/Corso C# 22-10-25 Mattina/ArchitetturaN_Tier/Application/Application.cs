using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Infrastructure;

namespace Application
{
    public class OrdService
    {
        private readonly IOrderRepo _ords;
        private readonly INotifyServ _nfy;
        private readonly IClock _clock;
        private readonly Customer _custom;
        public OrdService(IOrderRepo ords, INotifyServ nfy, IClock clock) { _ords = ords; _clock = clock; _nfy = nfy; }

        public IEnumerable<Order> List() => _ords.List();
        public void Notify() => Console.WriteLine($"Hai creato un nuovo ordine!");
        public void Time() => Console.WriteLine($"Creato alle ore: {DateTime.Now.Hour}");
        public Order CreateOrder(string name, string email)
        {
            var odr = new Order(_custom);
            _ords.Add(odr);
            Notify();
            Time();
            return odr;
        }

    }

    public class ProdService
    {
        private readonly IProductRepo _prods;
        public ProdService(IProductRepo prods) => _prods = prods;
        public IEnumerable<Product> List() => _prods.List();
        public Product? Require(string code) => _prods.GetByCode(code);
        public void CreateProduct(string code, string name, decimal price)
        {
            if (string.IsNullOrWhiteSpace(code)) throw new ArgumentException("Inserisci il codice.");
            _prods.Add(new Product(code, name, price));
        }
    }
}