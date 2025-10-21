using System;

public class Giorni
{
    public enum GiorniSettimana { Lunedi, Martedi, Mercoledi, Giovedi, Venerdi, Sabato, Domenica }

    private GiorniSettimana _giorno;

    // Costruttore per impostare il tipo
    public Giorni(GiorniSettimana giorno)
    {
        _giorno = giorno;
    }

    // Metodo principale
    public void Controllo()
    {
        switch (_giorno)
        {
            case GiorniSettimana.Lunedi:
            case GiorniSettimana.Martedi:
            case GiorniSettimana.Mercoledi:
            case GiorniSettimana.Giovedi:
            case GiorniSettimana.Venerdi:
            case GiorniSettimana.Sabato:
            case GiorniSettimana.Domenica:
                Console.WriteLine($"Oggi è {_giorno}");
                break;

            default:
                throw new InvalidOperationException("Giorno non riconosciuto.");
        }
    }

    // Override di ToString per personalizzare l’output
    public override string ToString()
    {
        return $"Giorno selezionato: {_giorno}";
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        var g1 = new Giorni(Giorni.GiorniSettimana.Lunedi);
        var g2 = new Giorni(Giorni.GiorniSettimana.Sabato);

        // Stampa tramite ToString()
        Console.WriteLine(g1.ToString());   // Giorno selezionato: Lunedi
        Console.WriteLine(g2.ToString());   // Giorno selezionato: Sabato

        // Oppure usa il metodo Controllo()
        g1.Controllo();  // Oggi è Lunedi
        g2.Controllo();  // Oggi è Sabato
    }
}
