using System;

using System;

public class Program
{
    // Dichiarazione delegate
    delegate void Saluto(string nome);

    // Metodo compatibile
    static void Ciao(string nome)
    {
        Console.WriteLine($"Ciao {nome}");
    }
    // Delegati con parametri
    static void EseguiSaluto(string nome, Saluto saluto)
    {
        saluto(nome);
    }
    // Metodo Main
    public static void Main(string[] args)
    {
        // Uso del delegate
        Saluto s = Ciao;
        s("Fabio");

        //Uso delegate parametro
        EseguiSaluto("Luisa", Ciao);
    }
}
