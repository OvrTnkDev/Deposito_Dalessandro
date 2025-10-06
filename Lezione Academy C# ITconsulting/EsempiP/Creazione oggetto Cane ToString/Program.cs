using System;
public class Cane
{
    //Propietà (campi)
    public string nome;
    public int eta;

    public void Abbaia()
    {
        Console.WriteLine($"{nome} dice: BAU!");
        Console.WriteLine($"e ha {eta}");
    }

    public override string ToString()
    {
        return $"Nome: {nome}\t eta: {eta}";
    }
}

public class Program
{
    public static void Main()
    {
        //Creazione di un oggetto (istanza della classe Cane)
        Cane mioCane = new Cane();
        Cane c = new Cane { nome = "Cicco", eta = 8 };

        //Assegnazione dei valori alle proprietà
        mioCane.nome = "Ghemon";
        mioCane.eta = 6;

        //Chiamata di un metodo sull'oggetto
        mioCane.Abbaia(); //Output: Ghemon dice: BAU!
        Console.WriteLine($"{c}");
    }
}