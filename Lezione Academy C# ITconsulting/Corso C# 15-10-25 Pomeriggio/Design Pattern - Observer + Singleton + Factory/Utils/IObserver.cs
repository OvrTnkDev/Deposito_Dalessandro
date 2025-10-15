using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Chi osserva - (l'osservatore)
namespace Utils
{
    public interface IObserver
    {
        void NotificaCreazione(string nomeUtente);
    }
}