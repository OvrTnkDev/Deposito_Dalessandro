using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Utils
{
    public class EmailClient : IObserver
    {
        public void Update(string message)
        {Console.WriteLine($"Email send: {message}");}
    }
}