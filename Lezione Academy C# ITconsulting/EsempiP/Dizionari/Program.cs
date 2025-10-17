using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        //Dichiarazione semplice di un dizionario
        Dictionary<int, string> dizionario = new Dictionary<int, string>();

        //Inizializzazione del dizionario con valori
        var dizionarioInit = new Dictionary<int, string>
        {
            {1, "uno"},
            {2, "due"},
            {3, "tre"}
        };
        //Aggiunta di elementi al dizionario
        dizionarioInit.Add(4, "quattro");

        foreach (var elemento in dizionarioInit)
        {
            Console.WriteLine($"chiave: {elemento.Key}, valore: {elemento.Value}");
        }
    }
}