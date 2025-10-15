using System;
using System.Collections.Generic;

namespace Utils
{
    public class NewsAgency : INewsSubscriber
    {
        //Il Lazy permette di controllare se l'istanza è gia presente o meno
        //'Istanziazione pigra' -> Singleton -> visto da uno degli esempi di Mirko
        private static readonly Lazy<NewsAgency> _lazy =
        new Lazy<NewsAgency>(() => new NewsAgency());

        public static NewsAgency Instance => _lazy.Value;
        private readonly List<IObserver> _observers = new List<IObserver>();
        private string _news;
        private NewsAgency() { }
        public string News
        {
            get => _news;
            set
            {
                _news = value;
                Notify(_news);
            }
        }

        public void Attach(IObserver observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
        }

        public void Detach(IObserver observer) => _observers.Remove(observer);

        public void Notify(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }
    }
}