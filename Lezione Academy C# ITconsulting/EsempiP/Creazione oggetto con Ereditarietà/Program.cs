using System;

// ** EREDITARIETA' **

//Classe padre
public class Animale
{
    public void FaiVerso()
    {
        Console.WriteLine($"L'animale fa un verso.");
    }
}

//Classe derivata, viene usato :
public class Cane : Animale
{
    public void Scodinzola()
    {
        Console.WriteLine($"Il cane scodinzola.");

    }
}

public class Program
{
    public static void Main()
    {
        //Creazione di un oggetto (istanza della classe Cane) che sarebbe la derivata
        Cane mioCane = new Cane();

        //Assegnazione dei valori alle proprietà
        mioCane.FaiVerso();
        mioCane.Scodinzola();
    }
}