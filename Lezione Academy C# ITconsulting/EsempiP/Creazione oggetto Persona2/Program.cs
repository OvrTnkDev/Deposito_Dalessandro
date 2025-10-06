using System;
public class Persona
{
    //Propietà (campi)
    public string nome1;
    public string cognome1;
    public int annoNascita1;
    //Costruttore con parametri
    public Persona(string nome, string cognome, int annoNascita)
    {
        nome1 = nome;
        cognome1 = cognome;
        annoNascita1 = annoNascita;
    }
    public void Video()
    {
        Console.WriteLine($"{nome1} - {cognome1} è nato nel {annoNascita1}");
    }
}

public class Program
{
    public static void Main()
    {
        //Creazione di un oggetto (istanza della classe Persona)
        Persona p = new Persona("Fabio", "D'alessandro", 1998);

        //Chiamata di un metodo sull'oggetto
        p.Video();

        //Creazione di un oggetto (istanza della classe Persona)
        Persona p1 = new Persona("Luca", "Massima", 2000);

        //Chiamata di un metodo sull'oggetto
        p1.Video();
    }
}