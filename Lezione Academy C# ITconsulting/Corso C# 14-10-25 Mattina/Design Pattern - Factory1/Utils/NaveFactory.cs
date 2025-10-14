using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Utils
{
    public abstract class NaveFactory
    {
        // Crea Veicolo: restituisce un IVeicolo
        public static IVeicolo CreaVeicolo(string v)
        {
            switch (v.ToLower())
            {
                case "nave":
                    return new Nave();
                default:
                    return null;
            }
        }
    }
}