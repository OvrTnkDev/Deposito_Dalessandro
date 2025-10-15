using System;
using System.Collections.Generic;

namespace Utils
{
    public class GestoreCreazioneutente : ISubject
    {
        //Il Lazy permette di controllare se l'istanza è gia presente o meno
        //'Istanziazione pigra' -> Singleton -> visto da uno degli esempi di Mirko
        private static readonly Lazy<GestoreCreazioneutente> _lazy =
        new Lazy<GestoreCreazioneutente>(() => new GestoreCreazioneutente());

        public static GestoreCreazioneutente Instance => _lazy.Value;
        private readonly List<IObserver> _observers = new List<IObserver>();
        private string _nome;
        private GestoreCreazioneutente() { }
        public void CreaUtente(string nomeUtente)
        {
            _nome = nomeUtente;
            UserFactory.Crea(nomeUtente);
            Notify(_nome);
        }

        public void Registra(IObserver o)
        {
            if (!_observers.Contains(o))
                _observers.Add(o);
        }

        public void Rimuovi(IObserver o) => _observers.Remove(o);

        public void Notify(string nomeUtente)
        {
            foreach (var o in _observers)
            {
                o.NotificaCreazione(nomeUtente);
            }
        }
    }
}