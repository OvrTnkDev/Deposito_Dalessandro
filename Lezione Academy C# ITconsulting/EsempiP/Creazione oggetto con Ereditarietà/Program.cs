using System;

// ** EREDITARIETA' **

//Classe padre
public class Animale
{
    protected int Eta;
    public void FaiVerso()
    {
        Console.WriteLine($"L'animale fa un verso.");
    }

    public virtual void Mangia()
    {
        Console.WriteLine($"L'animale mangia.");
    }

    public void Dorme()
    {
        Console.WriteLine($"L'animale dorme.");
    }

    public void ImpostaEta(int nuovaEta)
    {
        Eta = nuovaEta;
    }
}

//Classe derivata, viene usato :
public class Cane : Animale
{
    public void Scodinzola()
    {
        Console.WriteLine($"Il cane scodinzola.");
    }

    public void FaiVersoC()
    {
        base.FaiVerso();
        Console.WriteLine($"Il cane abbaia.");
    }

    public override void Mangia()
    {
        base.Mangia();
        Console.WriteLine($"Il cane mangia.");
    }

    public new void Dorme()
    {
        base.Dorme();
        Console.WriteLine($"Il cane dorme.");
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
        mioCane.FaiVersoC();
        mioCane.Mangia();
        mioCane.Dorme();
         mioCane.ImpostaEta(3);
    }
}