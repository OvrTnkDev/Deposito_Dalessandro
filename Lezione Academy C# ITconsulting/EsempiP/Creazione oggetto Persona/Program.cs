using System;
public class Persona
{
    //Propietà (campi)
    public string nome1;
    public int eta1;

    public Persona(string nome, int eta)
    {
        nome1 = nome;
        eta1 = eta;
    }

    public void Presentati()
    {
        Console.WriteLine($"Ciao sono {nome1} e ho {eta1}");
    }
}

public class Program
{
    public static void Main()
    {
        //Creazione di un oggetto (istanza della classe Persona)
        Persona p = new Persona("Fabio", 26);

        //Chiamata di un metodo sull'oggetto
        p.Presentati();

                //Creazione di un oggetto (istanza della classe Persona)
        Persona p1 = new Persona("Fabio", 26);

        //Chiamata di un metodo sull'oggetto
        p1.Presentati();
    }
}