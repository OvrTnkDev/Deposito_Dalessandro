using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Utils
{
    //Moto implementa IVeicolo
    public class Moto : IVeicolo
    {
        public void Avvia() => Console.WriteLine($"Avvio della moto..");
        public void MostraTipo() => Console.WriteLine($"Tipo: Moto");
    }
}