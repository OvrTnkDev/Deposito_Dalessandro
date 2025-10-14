using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Utils.Factory
{
    public class DispositivoFactory
    {
        public static IDispositivo CreaDispositivo(string tipo)
        {
            switch (tipo.ToLower())
            {
                case "computer": return new Computer();
                case "stampante":return new Stampante();
                default: throw new KeyNotFoundException($"{tipo} Scelta ambigua");;
            }
        }
    }
}