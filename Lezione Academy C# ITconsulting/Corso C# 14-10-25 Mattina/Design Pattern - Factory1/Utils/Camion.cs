using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Utils
{
    //Camion implementa IVeicolo
    public class Camion : IVeicolo
    {
        public void Avvia() => Console.WriteLine($"Avvio del Camion..");
        public void MostraTipo() => Console.WriteLine($"Tipo: Camion");
    }
}