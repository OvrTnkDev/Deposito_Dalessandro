using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Utils
{
    // 1. IVeicolo: definisce l'interfaccia dell Veicolo
    public interface IVeicolo
    {
        void Avvia();
        void MostraTipo();
    }
}