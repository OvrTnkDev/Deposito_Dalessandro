public class ContoBancario
{
    // Campo privato (non accessibile direttamente dall esterno)
    private double saldo;
    public string nomeContoBancario;
    // Proprietà per accedere al saldo in modo controllato
    public double Saldo
    {
        get { return saldo; } // permette 1a lettura del saldo
        set
        {
            if (value >= 0)    // solo valori validi
                saldo = value;
        }
    }

    public string NomeContoBancario
    {
        { get return nomeContoBancario;
         private set; }
    }

    public class Programma
    {
        public static void Main()
        {
            ContoBancario conto = new ContoBancario();

            // conto.NomeContoBancario = "Intesa SanPaolo";
            // Console.WriteLine(conto.NomeContoBancario);

            conto.Saldo = 1560.90;
            Console.WriteLine(conto.Saldo);

            conto.Saldo -= 510;
            Console.WriteLine(conto.Saldo);
        }
    }
}

