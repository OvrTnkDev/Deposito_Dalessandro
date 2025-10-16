using System;

#region INTERFACCIA
// 1. Component: definisce l'interfaccia dell'oggetto
public interface ITorta
{
    string Descrizione();
}
#endregion

#region CLASSI CONCRETE
// 2. ConcreteComponent: oggetto base senza decorazioni
public class TortaCioccolato : ITorta
{
    public string Descrizione() => "Torta al Cioccolato:\n";
}

public class TortaVaniglia : ITorta
{
    public string Descrizione() => "Torta alla Vaniglia:\n";
}

public class TortaFrutta : ITorta
{
    public string Descrizione() => "Torta alla Frutta:\n";
}
#endregion

#region DECORATORE ASTRATTO
// 3. Decorator: classe astratta che implementa IComponent
//    e incapsula un IComponent interno
public abstract class DecoratoreTorta : ITorta
{
    // Riferimento al componente "decorato"
    protected ITorta _torta;

    // Costruttore: richiede un componente da decorare
    protected DecoratoreTorta(ITorta torta)
    {
        _torta = torta;
    }

    // Delegazione dell'operazione al componente interno
    public virtual string Descrizione() => _torta.Descrizione();
}
#endregion

#region DECORATORE CONCRETO
// 4. ConcreteDecoratorA: aggiunge comportamento prima e dopo la chiamata
public class ConGlassa : DecoratoreTorta
{
    public ConGlassa(ITorta torta)
        : base(torta) { }

    public override string Descrizione() => base.Descrizione() + "\n+ Glassa";
}

public class ConFragole : DecoratoreTorta
{
    public ConFragole(ITorta torta)
        : base(torta) { }

    public override string Descrizione() => base.Descrizione() + "\n+ Fragole";
}

public class ConPanna : DecoratoreTorta
{
    public ConPanna(ITorta torta)
        : base(torta) { }

    public override string Descrizione() => base.Descrizione() + "\n+ Panna";
}
#endregion

#region FACTORY
public class TortaFactory
{
    private static TortaFactory _instance;

    private TortaFactory() { }

    public static TortaFactory Instance => _instance ??= new TortaFactory();

    public ITorta CreaTorta(string tipo)
    {
        return tipo.ToLower().Trim() switch
        {
            "cioccolato" => new TortaCioccolato(),
            "vaniglia" => new TortaVaniglia(),
            "frutta" => new TortaFrutta(),
            _ => null
        };
    }
}
#endregion

#region MAIN
// Esempio di utilizzo (Client)
class Program
{
    static void Main()
    {
        Console.Clear();
        bool continua = true;

        while (continua)
        {
            Console.WriteLine("=== Benvenuto nella Pasticceria ===");
            Console.WriteLine("Scegli la torta base:");
            Console.WriteLine("1 - Cioccolato");
            Console.WriteLine("2 - Vaniglia");
            Console.WriteLine("3 - Frutta");
            Console.WriteLine("0 - Esci");

            string sceltaBase = Console.ReadLine();
            ITorta torta = sceltaBase switch
            {
                "1" => TortaFactory.Instance.CreaTorta("cioccolato"),
                "2" => TortaFactory.Instance.CreaTorta("vaniglia"),
                "3" => TortaFactory.Instance.CreaTorta("frutta"),
                "0" => null,
                _ => null
            };

            if (torta == null)
            {
                if (sceltaBase == "0")
                {
                    Console.WriteLine("Arrivederci!");
                    break;
                }
                Console.WriteLine("Scelta non valida.\n");
                continue;
            }

            bool decorazioneFinita = false;
            while (!decorazioneFinita)
            {
                Console.WriteLine("\nAggiungi decorazioni:");
                Console.WriteLine("1 - Glassa");
                Console.WriteLine("2 - Fragole");
                Console.WriteLine("3 - Panna");
                Console.WriteLine("0 - Nessuna/Finito");

                string sceltaDeco = Console.ReadLine();
                switch (sceltaDeco)
                {
                    case "1":
                        torta = new ConGlassa(torta);
                        break;
                    case "2":
                        torta = new ConFragole(torta);
                        break;
                    case "3":
                        torta = new ConPanna(torta);
                        break;
                    case "0":
                        decorazioneFinita = true;
                        break;
                    default:
                        Console.WriteLine("Scelta decorazione non valida.");
                        break;
                }
            }

            Console.WriteLine("\nEcco la tua torta:");
            Console.WriteLine(torta.Descrizione());
            Console.WriteLine("\n------------------------------\n");
        }
    }
}
#endregion