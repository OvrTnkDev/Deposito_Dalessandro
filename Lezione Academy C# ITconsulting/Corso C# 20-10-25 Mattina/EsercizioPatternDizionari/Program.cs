using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

#region SINGLETON
sealed class BankContext : ISubject
{
    public Dictionary<int, Cliente> cliente = new Dictionary<int, Cliente>();
    public Dictionary<int, Conto> conto = new Dictionary<int, Conto>();
    public Dictionary<int, List<Operazione>> operazione = new Dictionary<int, List<Operazione>>();
    public Dictionary<int, String> logger = new Dictionary<int, string>();
    public double Tasso { get; private set; } = 3.5;
    public string Valuta { get; private set; } = "EUR";

    private readonly List<IObserver> _observers = new List<IObserver>();

    private static readonly BankContext _instance = new BankContext();
    private BankContext() { }
    public static BankContext Instance => _instance;

    public void Subscribe(IObserver observer)
    {
        if (!_observers.Contains(observer)) _observers.Add(observer);
    }

    public void Unsubscribe(IObserver observer)
    {
        if (_observers.Contains(observer)) _observers.Remove(observer);
    }

    public void Notify(string message)
    {
        foreach (var o in _observers)
            o.Update(message);
    }
}
#endregion

#region FACTORY METHOD ABSTRACT
public abstract class ContoFactory
{
    public abstract Conto NuovoConto(int idCliente);
}

public abstract class Conto
{
    public int IdConto { get; set; }
    public int IdCliente { get; set; }
    public double Saldo { get; set; }
    public string Tipo { get; set; } = "Base";

    // Strategy per il calcolo degli interessi
    public ICalcoloInteressi? CalcolatoreInteressi { get; set; }

    public void ApplicaInteressi()
    {
        if (CalcolatoreInteressi == null) return;
        double interesse = CalcolatoreInteressi.Calcola(Saldo);
        Saldo += interesse;
        // Notifica gli observer se presenti
        BankContext.Instance.Notify($"Interessi applicati conto {IdConto}: {interesse:+0.00;-0.00}");
    }
        
}
#endregion

#region ENTITY
public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
}

public class Operazione
{
    public int Id { get; set; }
    public DateTime Data { get; set; } = DateTime.Now;
    public string Descrizione { get; set; } = string.Empty;
    public double Importo { get; set; }
}
#endregion

#region STRATEGY
public interface ICalcoloInteressi
{
    double Calcola(double saldo);
}

public class CalcoloInteressiBase : ICalcoloInteressi
{
    public double Calcola(double saldo) => saldo * 0.05;
}

public class CalcoloInteressiPremium : ICalcoloInteressi
{
    public double Calcola(double saldo) => saldo * 0.03;
}

public class CalcoloInteressiStudent : ICalcoloInteressi
{
    public double Calcola(double saldo) => saldo * 0.005;
}
#endregion

#region OBSERVER
public interface IObserver
{
    void Update(string message);
}

public interface ISubject
{
    void Subscribe(IObserver observer);
    void Unsubscribe(IObserver observer);
    void Notify(string message);
}

public class LoggerObserver : IObserver
{
    public void Update(string message)
    {
        var ctx = BankContext.Instance;
        int id = ctx.logger.Count + 1;
        ctx.logger[id] = message;
    }
}
#endregion

#region FACTORY METHOD CONCRETE
public class ContoCorrenteFactory : ContoFactory
{
    public override Conto NuovoConto(int idCliente)
    {
        Conto conto = idCliente switch
        {
            1 => new ContoBase(BankContext.Instance.conto.Count + 1, idCliente),
            2 => new ContoPremium(BankContext.Instance.conto.Count + 1, idCliente),
            3 => new ContoStudent(BankContext.Instance.conto.Count + 1, idCliente),
            _ => throw new ArgumentException("Tipo di cliente non valido"),
        };

        return conto;
    }
}

public class ContoBase : Conto
{
    public ContoBase(int idConto, int idCliente)
    {
        IdConto = idConto;
        IdCliente = idCliente;
        Saldo = 0;
        Tipo = "Base";
        CalcolatoreInteressi = new CalcoloInteressiBase();
    }
}

public class ContoPremium : Conto
{
    public ContoPremium(int idConto, int idCliente)
    {
        IdConto = idConto;
        IdCliente = idCliente;
        Saldo = 0;
        Tipo = "Premium";
        CalcolatoreInteressi = new CalcoloInteressiPremium();
    }
}

public class ContoStudent : Conto
{
    public ContoStudent(int idConto, int idCliente)
    {
        IdConto = idConto;
        IdCliente = idCliente;
        Saldo = 0;
        Tipo = "Studente";
        CalcolatoreInteressi = new CalcoloInteressiStudent();
    }
}
#endregion

#region CLIENT
class Program
{
    static void Main()
    {
        var ctx = BankContext.Instance;

        var factory = new ContoCorrenteFactory();
        var logger = new LoggerObserver();
        ctx.Subscribe(logger);

        while (true)
        {
            Console.WriteLine($"---- Bank System ----");
            Console.WriteLine($"1. Crea nuovo conto");
            Console.WriteLine($"0. Esci");
            Console.Write("Seleziona un operazione: ");
            int scelta = int.Parse(Console.ReadLine() ?? "0");
            if (scelta == 0) break;

            if (scelta == 1)
            {
                // create new account
                Console.Write("Inserisci ID cliente: ");
                int idCliente = int.Parse(Console.ReadLine() ?? "0");
                Console.Write("\nInserisci nome cliente: ");
                string nomeCliente = Console.ReadLine() ?? string.Empty;
                var cliente = new Cliente { Id = idCliente, Nome = nomeCliente };
                ctx.cliente[cliente.Id] = cliente;

                Console.WriteLine($"---- Scelta tipo conto ----");
                Console.WriteLine($"1. Crea nuovo conto Base");
                Console.WriteLine($"1. Crea nuovo conto Premium");
                Console.WriteLine($"1. Crea nuovo conto Studente");
                Console.WriteLine($"0. Esci");
                int tipoConto = int.Parse(Console.ReadLine() ?? "0");
                if (tipoConto == 0) break;
                if (tipoConto < 1 || tipoConto > 3)
                {
                    Console.WriteLine("Tipo di conto non valido.");
                    continue;
                }
                else
                {
                    var conto = factory.NuovoConto(tipoConto);
                    conto.IdCliente = idCliente;
                    ctx.conto[conto.IdConto] = conto;
                    Console.WriteLine($"Conto creato con successo. ID cliente: {conto.IdCliente}, Tipo: {conto.Tipo}");
                }
            }
        }
    }
}
#endregion