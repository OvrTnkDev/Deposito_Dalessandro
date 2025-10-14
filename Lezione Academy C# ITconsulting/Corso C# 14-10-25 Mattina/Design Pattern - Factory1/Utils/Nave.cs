using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Utils
{
    //Moto implementa IVeicolo
    public class Nave : IVeicolo
    {
        public void Avvia() => Console.WriteLine($"Avvio della Nave..");
        public void MostraTipo() => Console.WriteLine($"Tipo: Nave");
    }
}