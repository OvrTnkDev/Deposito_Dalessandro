using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

#region SINGLETON
sealed class BankContext
{
    public Dictionary<int, Cliente> cliente = new Dictionary<int, Cliente>();
    public Dictionary<int, Conto> conto = new Dictionary<int, Conto>();
    public Dictionary<int, List<Operazione>> operazione = new Dictionary<int, List<Operazione>>();
    public Dictionary<int, String> logger = new Dictionary<int, string>();
    public double Tasso { get; private set; } = 3.5;
    public string Valuta { get; private set; } = "EUR";


    private static readonly BankContext _instance = new BankContext();
    private BankContext() { }
    public static BankContext Instance => _instance;
}
#endregion

#region FACTORY METHOD ABSTRACT
public abstract class ContoFactory
{
    public abstract Conto NuovoConto(int idCliente);
}

public abstract class Conto
{
    public int IdConto { get; protected set; }
    public int IdCliente { get; protected set; }
    public double Saldo { get; protected set; }
    public string Tipo { get; protected set; } = "B";
        
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
        Tipo = "B";
    }
}

public class ContoPremium : Conto
{
    public ContoPremium(int idConto, int idCliente)
    {
        IdConto = idConto;
        IdCliente = idCliente;
        Saldo = 0;
        Tipo = "P";
    }
}

public class ContoStudent : Conto
{
    public ContoStudent(int idConto, int idCliente)
    {
        IdConto = idConto;
        IdCliente = idCliente;
        Saldo = 0;
        Tipo = "S";
    }
}
#endregion