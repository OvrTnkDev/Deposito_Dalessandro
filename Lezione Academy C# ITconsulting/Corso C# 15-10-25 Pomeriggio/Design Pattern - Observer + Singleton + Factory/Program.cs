using System;
using Utils;

class Program
{
    static void Main(string[] Args)
    {
        // Creazione observer concreti
        var mobile = new MobileObserver();
        var email = new EmailObserver();

        // Registrazione degli observer al GestoreCreazioneutente (Singleton)
        GestoreCreazioneutente.Instance.Registra(mobile);
        GestoreCreazioneutente.Instance.Registra(email);

        // Creazione utenti
        GestoreCreazioneutente.Instance.CreaUtente("Peter Parker");
        GestoreCreazioneutente.Instance.CreaUtente("Joker");

        // Rimuove un observer
        GestoreCreazioneutente.Instance.Rimuovi(mobile);

        // Creazione di un altro utente
        GestoreCreazioneutente.Instance.CreaUtente("Bruce Wayne");

        // Verifica Singleton
        if (object.ReferenceEquals(GestoreCreazioneutente.Instance, GestoreCreazioneutente.Instance))
            Console.WriteLine("Stessa istanza");
        else
            Console.WriteLine("Istanze diverse");
    }
}
