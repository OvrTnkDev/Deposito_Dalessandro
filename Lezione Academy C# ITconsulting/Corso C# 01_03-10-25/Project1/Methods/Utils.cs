namespace Methods;

public static class Utils
{
    public static void Hello(string name)
    {
        Console.WriteLine($"Ciao {name}");
    }

    public static void PariDispari(int number)
    {
        if ((number % 2) == 0)
        {
            Console.WriteLine($"{number} è pari!");
        }
        else
        {
            Console.WriteLine($"{number} è dispari!");
        }
    }

    public static int CalcoloPotenza(int baseNum, int esponente)
    {
        int risultato = 1;
        for (int i = 0; i < esponente; i++)
        {
            risultato *= baseNum;
        }
        return risultato;
    }

    public static void Raddoppia(ref int number)
    {
        number *= 2;
    }

    public static void AggiustaData(ref int day, ref int month, ref int year)
    {
        if (day > 30) { month += 1; day -= 30; }
        if (month > 12) { year += 1; month -= 12; }
    }

    public static void Dividi(int numeratore, int denominatore, out float quoziente, out float resto)
    {
        quoziente = numeratore / denominatore;
        resto = numeratore % denominatore;
    }

    public static void AnalizzaParola(string testo, out int countVoc, out int countCons, out int countSp)
    {
        char[] vocali = { 'a', 'e', 'i', 'o', 'u' };
        countVoc = 0;
        countCons = 0;
        countSp = 0;

        if (!string.IsNullOrEmpty(testo))
        {
            foreach (char c in testo)
            {
                if (char.IsWhiteSpace(c))
                {
                    countSp++;
                }
                else
                {
                    char lower = char.ToLower(c);
                    if (Array.Exists(vocali, v => v == lower))
                    {
                        countVoc++;
                    }
                    else if (char.IsLetter(c))
                    {
                        countCons++;
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Non hai scritto nulla");
        }
    }

    public static int Somma(int n1, int n2)
    {
        return n1 + n2;
    }

    public static int Somma(int n1, int n2, int n3)
    {
        return n1 + n2 + n3;
    }

    public static double Somma(double n1, double n2)
    {
        return n1 + n2;
    }

    public static float Somma(float n1, float n2)
    {
        return n1 + n2;
    }

    public static int Analizza(string testo)
    {
        int c = 0;
        if (!string.IsNullOrEmpty(testo))
        {
            foreach (char a in testo)
            {
                if (!char.IsWhiteSpace(a)) { c++; }
            }
        }
        else { Console.WriteLine($"La stringa è vuota!!"); }
        return c;
    }

    public static int Analizza(string testo, char carattere)
    {
        int c = 0;

        if (!string.IsNullOrEmpty(testo))
        {
            foreach (char a in testo)
            {
                if (a == carattere) { c++; }
                ;
            }
        }
        else { Console.WriteLine($"La stringa è vuota!!"); }
        return c;
    }
    public static void Analizza(string testo, bool a)
    {
        a = false;
        char[] vocali = { 'a', 'e', 'i', 'o', 'u' };
        int countVoc = 0;
        int countCons = 0;

        if (!string.IsNullOrEmpty(testo))
        {
            foreach (char c in testo)
            {
                char lower = char.ToLower(c);
                if (a == true)
                {
                    if (Array.Exists(vocali, v => v == lower))
                    {
                        countVoc++;
                    }
                }
                if (char.IsLetter(c) && a == false)
                {
                    countCons++;
                }
            }
        }
        else
        {
            Console.WriteLine("Non hai scritto nulla");
        }
        
        Console.WriteLine($"{a}");
        
        Console.WriteLine($"Nel testo: {testo}\t" +
        $"Ci sono {countVoc} vocali\t" +
        $"Ci sono {countCons} consonanti\t");
    }
}
