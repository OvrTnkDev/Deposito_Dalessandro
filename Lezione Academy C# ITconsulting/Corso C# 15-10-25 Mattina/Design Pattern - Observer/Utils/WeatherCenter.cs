using System;
using System.Collections.Generic;

namespace Utils
{
    public class WeatherCenter : ISubject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private string _dati;
        public string Dati
        {
            get => _dati;
            set
            {
                _dati = value;
            }
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }

        public void WeatherUpdt(string dati)
        {
            if (!string.IsNullOrEmpty(dati))
            {
                _dati = dati;
                Notify($"I campi sono stati aggiornati, dati: {_dati}");
            }
            else
            {
                Notify("I campi non sono stati aggiornati, campo vuoto!");
            }
        }
    }
}
