using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Utils
{
    //Auto implementa IVeicolo
    public class Camion : VeicoloFactory, IVeicolo
    {
        public void Avvia() => Console.WriteLine($"Il Camion è stato avviato...");
        public void MostraTipo() => Console.WriteLine($"{GetType()}");
    }
}