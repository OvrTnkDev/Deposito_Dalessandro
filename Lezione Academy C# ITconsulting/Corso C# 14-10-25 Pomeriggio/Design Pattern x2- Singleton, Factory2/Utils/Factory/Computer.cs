using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Utils.Factory
{
    public class Computer : IDispositivo
    {
        public void Avvia() => Console.WriteLine($"Il Computer è stato avviato...");
        public void MostraTipo() => Console.WriteLine($"Tipo: {GetType()}");
    }
}