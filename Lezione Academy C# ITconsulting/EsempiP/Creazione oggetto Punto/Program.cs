using System;
using System.Reflection.Metadata.Ecma335;
public class Punto
{
    //Propietà (campi)
    public int x;
    public int y;

    public override bool Equals(object obj)
    {
        if (obj is Punto altro)
        {
            return this.x == altro.x && this.y == altro.y;
        }
        return false;
    }

}

public class Program
{
    public static void Main()
    {
        //Creazione di un oggetto (istanza della classe Cane)
        Punto a = new Punto{ x = 1, y = 1 };
        Punto b = new Punto { x = 1, y = 1 };
//Output: Ghemon dice: BAU!
        Console.WriteLine($"{a.Equals(b)}");
    }
}