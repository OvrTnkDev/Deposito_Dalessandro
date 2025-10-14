using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Utils
{
    //Auto implementa IVeicolo
    public class Moto : IVeicolo
    {
        public void Avvia() => Console.WriteLine($"La moto è stata avviata...");
        public void MostraTipo() => Console.WriteLine($"{GetType()}");
    }
}