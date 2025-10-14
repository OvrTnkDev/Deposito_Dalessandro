using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Utils
{
    // 1. Veicolo: definisce l'interfaccia del veicolo
    public interface IVeicolo
    {
        void Avvia();
        void MostraTipo();
    }
}