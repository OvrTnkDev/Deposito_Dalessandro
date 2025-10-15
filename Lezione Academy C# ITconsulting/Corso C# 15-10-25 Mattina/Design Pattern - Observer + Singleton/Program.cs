using System;
using System.Collections.Generic;
using Utils;
class Program
{
    static void Main(string[] Args)
    {
        var mobile = new MobileApp();
        var email = new EmailClient();

        // Registrazione degli observer
        NewsAgency.Instance.Attach(mobile);
        NewsAgency.Instance.Attach(email);
        NewsAgency.Instance.News = "Hanno ucciso l'uomo Ragno";
        NewsAgency.Instance.News = "Joker nuovo Presidente di Gotham";

        // Rimuove un observer
        NewsAgency.Instance.Detach(mobile);


        NewsAgency.Instance.News = "Batman muore di crepacuore";

        if (object.ReferenceEquals(NewsAgency.Instance, NewsAgency.Instance))
            Console.WriteLine("Stessa istanza");
        else
            Console.WriteLine("Istanze diverse");
    }
}