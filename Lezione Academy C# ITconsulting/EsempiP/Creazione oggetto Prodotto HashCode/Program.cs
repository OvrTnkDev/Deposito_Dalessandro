using System;
using System.Reflection.Metadata.Ecma335;
public class Prodotto
{
    //Propietà (campi)
    public string name;
    public double prezzo;

    public override int GetHashCode()
    {
        return HashCode.Combine(name, prezzo);
    }

}

public class Program
{
    public static void Main()
    {
        //Creazione di un oggetto (istanza della classe Prodotto)
        Prodotto a = new Prodotto { name = "Penna", prezzo = 1.50 };
        Prodotto b = new Prodotto { name = "Penna", prezzo = 1.50 };

        Console.WriteLine($"{a.GetHashCode()}");
        Console.WriteLine($"{b.GetHashCode()}");
        //Uguale se i valori sono gli stessi
    }
}