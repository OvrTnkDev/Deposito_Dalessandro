using System;
public class Studenti
{
    //Propietà (campi)
    public string nome1;
    public int matricola1;
    public double media1;

    public Studenti(string nome, int eta)
    {
        nome1 = nome;
        matricola1 = eta;
    }
    public void Media()
    {
        Console.WriteLine($"Ciao {nome1} - {matricola1}, inserisci i tuoi 3 ultimi voti!");
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Inserisci il {i + 1}° voto: ");
            media1 += int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"la tua media è {media1 / 3}");
    }
}

public class Program
{
    public static void Main()
    {
        //Creazione di un oggetto (istanza della classe Persona)
        Studenti s = new Studenti("Fabio", 2654);

        //Chiamata di un metodo sull'oggetto
        s.Media();

                //Creazione di un oggetto (istanza della classe Persona)
        Studenti s1 = new Studenti("Luigi", 2634);

        //Chiamata di un metodo sull'oggetto
        s1.Media();
    }
}