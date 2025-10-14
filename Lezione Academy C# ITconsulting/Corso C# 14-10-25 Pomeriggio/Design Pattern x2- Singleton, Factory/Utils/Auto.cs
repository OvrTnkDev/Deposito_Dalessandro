using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Utils
{
    //Auto implementa IVeicolo
    public class Auto : VeicoloFactory, IVeicolo
    {
        public void Avvia() => Console.WriteLine($"L'auto è stata avviata...");
        public void MostraTipo() => Console.WriteLine($"{GetType()}");
    }
}