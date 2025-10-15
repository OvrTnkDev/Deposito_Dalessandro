using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// chi viene osservato
namespace Utils
{
    public interface INewsSubscriber
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(string message);
    }
}