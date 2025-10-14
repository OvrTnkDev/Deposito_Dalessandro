using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Utils.Factory
{
    public class Stampante : IDispositivo
    {
        public void Avvia() => Console.WriteLine($"La Stampante è stata avviata...");
        public void MostraTipo() => Console.WriteLine($"Tipo: {GetType()}");
    }
}