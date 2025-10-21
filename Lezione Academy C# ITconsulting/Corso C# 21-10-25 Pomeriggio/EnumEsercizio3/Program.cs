using System;

public class Transazione
{
    public enum TipoTransazione { Acquisto, Rimborso, Trasferimento }

    private TipoTransazione _transazione;

    // Costruttore per impostare il tipo
    public Transazione(TipoTransazione tipo)
    {
        _transazione = tipo;
    }

    // Metodo principale
    public void Controllo()
    {
        switch (_transazione)
        {
            case TipoTransazione.Acquisto:
                Acquisto();
                break;

            case TipoTransazione.Rimborso:
                Rimborso();
                break;

            case TipoTransazione.Trasferimento:
                Trasferimento();
                break;

            default:
                throw new InvalidOperationException("Tipo di transazione non riconosciuto.");
        }
    }

    // Metodi d'esempio
    private void Acquisto() => Console.WriteLine("Eseguito Acquisto");
    private void Rimborso() => Console.WriteLine("Eseguito Rimborso");
    private void Trasferimento() => Console.WriteLine("Eseguito Trasferimento");
}


public class Program
{
    public static void Main(string[] args)
    {
        // Istanzia e controlla vari tipi di transazione
        var t1 = new Transazione(Transazione.TipoTransazione.Acquisto);
        var t2 = new Transazione(Transazione.TipoTransazione.Rimborso);
        var t3 = new Transazione(Transazione.TipoTransazione.Trasferimento);

        t1.Controllo(); // Output: Eseguito Acquisto
        t2.Controllo(); // Output: Eseguito Rimborso
        t3.Controllo(); // Output: Eseguito Trasferimento
    }
}
