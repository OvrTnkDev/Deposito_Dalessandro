using System;

#region INTERFACCIA
// 1. Component: definisce l'interfaccia dell'oggetto
public interface IBevanda
{
    string Descrizione();
    double Costo();
}
#endregion

#region CLASSI CONCRETE
// 2. ConcreteComponent: oggetto base senza decorazioni
public class Caffe : IBevanda
{
    public string Descrizione() => "Caffè dall'aroma Arabica.";
    public double Costo() => 1.20;
}

public class Te : IBevanda
{
    public string Descrizione() => "Tè nero, come il carbone.";
    public double Costo() => 2.50;
}
#endregion

#region DECORATORE ASTRATTO
// 3. Decorator: classe astratta che implementa IComponent
//    e incapsula un IComponent interno
public abstract class DecoratoreBevanda : IBevanda
{
    // Riferimento al componente "decorato"
    protected IBevanda _bevanda;

    // Costruttore: richiede un componente da decorare
    protected DecoratoreBevanda(IBevanda bevanda)
    {
        _bevanda = bevanda;
    }

    // Delegazione dell'operazione al componente interno
    public virtual string Descrizione() => _bevanda.Descrizione();
    public virtual double Costo() => _bevanda.Costo();
}
#endregion

#region DECORATORE CONCRETO
// 4. ConcreteDecoratorA: aggiunge comportamento prima e dopo la chiamata
public class ConLatte : DecoratoreBevanda
{
    public ConLatte(IBevanda bevanda)
        : base(bevanda) { }

    public override string Descrizione() => base.Descrizione() + "\nCon Latte";
    public override double Costo() => base.Costo() + 0.70;
}

public class ConCioccolato : DecoratoreBevanda
{
    public ConCioccolato(IBevanda bevanda)
        : base(bevanda) { }

    public override string Descrizione() => base.Descrizione() + "\nCon Cioccolato";
    public override double Costo() => base.Costo() + 1.00;
}

public class ConPanna : DecoratoreBevanda
{
    public ConPanna(IBevanda bevanda)
        : base(bevanda) { }

    public override string Descrizione() => base.Descrizione() + "\nCon Panna";
    public override double Costo() => base.Costo() + 0.30;
}
#endregion

#region MAIN
// Esempio di utilizzo (Client)
class Program
{
    static void Main(string [] Args)
    {
        // Oggetto di base
        IBevanda caffe = new Caffe();
        Console.WriteLine("Client: chiamo Caffè");
        Console.WriteLine(caffe.Descrizione());
        Console.WriteLine(caffe.Costo());

        IBevanda te = new Te();
        Console.WriteLine("Client: chiamo tè");
        Console.WriteLine(te.Descrizione());
        Console.WriteLine(te.Costo());

        // Decoro conLatte
        IBevanda conLatte = new ConLatte(caffe);
        Console.WriteLine("\nClient: decorato con? ");
        Console.WriteLine(conLatte.Descrizione());
        Console.WriteLine();
        Console.WriteLine($"{conLatte.Costo()}, senza latte {caffe.Costo()}");

        IBevanda conCioccolato = new ConCioccolato(caffe);
        Console.WriteLine("\nClient: decorato con? ");
        Console.WriteLine(conCioccolato.Descrizione());
        Console.WriteLine();
        Console.WriteLine($"{conCioccolato.Costo()}, senza cioccolato {caffe.Costo()}");

        IBevanda conPanna = new ConPanna(caffe);
        Console.WriteLine("\nClient: decorato con? ");
        Console.WriteLine(conPanna.Descrizione());
        Console.WriteLine();
        Console.WriteLine($"{conPanna.Costo()}, senza panna {caffe.Costo()}");

        //te concatenato
        IBevanda conLatteT = new ConLatte(te);
        Console.WriteLine("\nClient: decorato con? ");
        Console.WriteLine(conLatteT.Descrizione());
        Console.WriteLine();
        Console.WriteLine($"{conLatteT.Costo()}, senza latte {te.Costo()}");

        IBevanda conCioccolatoT = new ConCioccolato(conLatteT);
        Console.WriteLine("\nClient: decorato con? ");
        Console.WriteLine(conCioccolatoT.Descrizione());
        Console.WriteLine();
        Console.WriteLine($"{conCioccolatoT.Costo()}, senza cioccolato e latte {te.Costo()}");

        IBevanda conPannaT = new ConPanna(conCioccolatoT);
        Console.WriteLine("\nClient: decorato con? ");
        Console.WriteLine(conPannaT.Descrizione());
        Console.WriteLine();
        Console.WriteLine($"{conPannaT.Costo()}, senza panna, cioccolato e latte {te.Costo()}");
    }
}
#endregion