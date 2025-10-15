using System;
using System.Collections.Generic;
using Utils;
class Program
{
    static void Main()
    {
        var subject = new WeatherCenter();

        var observerA = new DisplayConsole();
        var observerB = new DisplayMobile();

        // Registrazione degli observer
        subject.Attach(observerA);
        subject.Attach(observerB);

        // Cambia lo stato: innesca Notify() e chiama Update() su tutti gli observer
        subject.WeatherUpdt("Nuvoloso");
        subject.WeatherUpdt("Soleggiato");

        // Rimuove un observer
        subject.Detach(observerA);

        // Ancora un cambiamento di stato: solo Observer B verrà notificato
        subject.WeatherUpdt("Piovoso");
    }
}