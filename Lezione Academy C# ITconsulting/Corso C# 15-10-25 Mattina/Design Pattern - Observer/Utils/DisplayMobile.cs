using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Utils
{
    public class DisplayMobile : IObserver
    {
        public void Update(string message)
        {Console.WriteLine($"Meteo aggiornato: {message}");}
    }
}