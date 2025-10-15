using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// chi viene osservato
namespace Utils
{
    public interface ISubject
    {
        void Registra(IObserver o);
        void Rimuovi(IObserver o);
        void Notify(string nomeUtente);
    }
}