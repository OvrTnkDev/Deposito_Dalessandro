using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Utils
{
    //Auto implementa IVeicolo
    public class Auto : IVeicolo
    {
        public void Avvia() => Console.WriteLine($"Avvio dell'auto..");
        public void MostraTipo() => Console.WriteLine($"Tipo: Auto");
    }
}