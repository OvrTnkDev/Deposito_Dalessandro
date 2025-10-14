using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Utils
{
    public abstract class VeicoloFactory
    {
        // Crea Veicolo: restituisce un IVeicolo
        public static IVeicolo CreaVeicolo(string v)
        {
            switch (v.ToLower())
            {
                case "auto":
                    return new Auto();
                case "moto":
                    return new Moto();
                case "camion":
                    return new Camion();
                default:
                    return null;
            }
        }
    }
}