using System;
public class Cane
{
    //Propietà (campi)
    public string nome;
    public int eta;

    public void Abbaia()
    {
        Console.WriteLine($"{nome} dice: BAU!");
    }
}

public class Program
{
    public static void Main()
    {
        //Creazione di un oggetto (istanza della classe Cane)
        Cane mioCane = new Cane();

        //Assegnazione dei valori alle proprietà
        mioCane.nome = "Ghemon";
        mioCane.eta = 6;

        //Chiamata di un metodo sull'oggetto
        mioCane.Abbaia(); //Output: Ghemon dice: BAU!
    }
}