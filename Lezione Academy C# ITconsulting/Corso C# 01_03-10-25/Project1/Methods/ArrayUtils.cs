using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using System.Linq;
using System.IO.Compression;

//namespace Methods.ArrayUtils;
namespace Methods;

public static class ArrayUtils
{
    //Creo l'instanza di Random
    static Random r = new Random();

    public static void CalcolaStampaMatrici(int b, int c)
    {
        int[,] a = new int[b, c];
        int l1 = a.GetLength(0);
        int l2 = a.GetLength(1);
        int sum = 0;

        for (int i = 0; i < l1; i++)
        {
            for (int j = 0; j < l2; j++)
            {
                Console.Write($"Inserisci il valore per cella [{i},{j}]: ");
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine($"Hai completato la matrice:");
        for (int i = 0; i < l1; i++)
        {
            for (int j = 0; j < l2; j++)
            {
                sum += a[i, j];
                Console.Write(a[i, j] + "\t");
            }
        }
        Console.WriteLine($"La somma della matrice è: {sum}");
    }

    public static void RandomArray(int numberVector)
    {
        int[] vector = new int[numberVector];

        for (int i = 0; i < vector.Length; i++)
        {
            int rNumber = r.Next(0, 101);
            vector[i] = rNumber;
            Console.WriteLine($"{i + 1}° numero:\t{vector[i]}");
        }
        //Utilizzo funzione nuova di Linq per mininmo e massimo
        Console.WriteLine($"Il numero massimo:{vector.Max()}\t" +
        $"Il numero minimo è: {vector.Min()}");
    }

    public static void ArrayReord(int veclength)
    {
        int[] v = new int[veclength];

        for (int i = 0; i < v.Length; i++)
        {
            Console.WriteLine($"Inserisci il {i + 1}° numero: ");
            v[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < v.Length; i++)
        {
            Console.Write($"Il {i + 1}° numero del vettore originale è: {v[i]}\n");
        }

        //Inverto l'array con il reverse
        Array.Reverse(v);
        for (int i = 0; i < v.Length; i++)
        {
            Console.Write($"Il {i + 1}° numero del vettore invertito è: {v[i]}\n");
        }
    }

    public static void Matrici4x4()
    {
        int[,] a = new int[4, 4];
        int l1 = a.GetLength(0);
        int l2 = a.GetLength(1);
        int sum = 0;
        int sum1 = 0;
        int sum2 = 0;
        int sum3 = 0;
        int sum4 = 0;

        for (int i = 0; i < l1; i++)
        {
            for (int j = 0; j < l2; j++)
            {
                a[i, j] = r.Next(1, 51);
            }
        }

        Console.WriteLine($"Hai completato la matrice:");
        for (int i = 0; i < l1; i++)
        {
            for (int j = 0; j < l2; j++)
            {
                sum += a[i, j];
                Console.Write(a[i, j] + "\t");
                if (i == 0) { sum1 += a[i, j]; }
                if (i == 1) { sum2 += a[i, j]; }
                if (i == 2) { sum3 += a[i, j]; }
                if (i == 3) { sum4 += a[i, j]; }
            }
            Console.WriteLine();
        }
        //Con la funzione Math calcolo il maggiore
        int maxNumV2D = Math.Max(Math.Max(sum1, sum2), Math.Max(sum3, sum4));
        Console.WriteLine($"La somma della prima matrice è {sum1}");
        Console.WriteLine($"La somma della seconda matrice è {sum2}");
        Console.WriteLine($"La somma della terza matrice è {sum3}");
        Console.WriteLine($"La somma della quarta matrice è {sum4}");
        Console.WriteLine($"Il valore massimo è {maxNumV2D}");


        Console.WriteLine($"La somma totale della matrice è: {sum}");
    }

    public static void Matrici5x5()
    {
        int[,] a = new int[5, 5];
        int l1 = a.GetLength(0);
        int l2 = a.GetLength(1);
        int sum = 0;
        int sum1 = 0;
        int sum2 = 0;
        int sum3 = 0;
        int sum4 = 0;
        int sum5 = 0;

        for (int i = 0; i < l1; i++)
        {
            for (int j = 0; j < l2; j++)
            {
                a[i, j] = r.Next(1, 51);
            }
        }

        Console.WriteLine($"Hai completato la matrice:");
        for (int i = 0; i < l1; i++)
        {
            for (int j = 0; j < l2; j++)
            {
                sum += a[i, j];
                Console.Write(a[i, j] + "\t");
                if (i == 0) { sum1 += a[i, j]; }
                if (i == 1) { sum2 += a[i, j]; }
                if (i == 2) { sum3 += a[i, j]; }
                if (i == 3) { sum4 += a[i, j]; }
                if (i == 4) { sum5 += a[i, j]; }
            }
            Console.WriteLine();
        }


        int diagP = (a[0, 0] + a[1, 1] + a[2, 2] + a[3, 3] + a[4, 4]);
        int diagS = (a[0, 4] + a[1, 3] + a[2, 2] + a[3, 1] + a[4, 0]);

        //Con la funzione Linq calcolo il maggiore
        int[] vector2D = [sum1, sum2, sum3, sum4, sum5];
        int maxNumV2D = vector2D.Max();
        Console.WriteLine($"La somma della prima matrice è {sum1}");
        Console.WriteLine($"La somma della seconda matrice è {sum2}");
        Console.WriteLine($"La somma della terza matrice è {sum3}");
        Console.WriteLine($"La somma della quarta matrice è {sum4}");
        Console.WriteLine($"La somma della quinta matrice è {sum5}");
        Console.WriteLine($"Il valore massimo è {maxNumV2D}");
        Console.WriteLine($"La diagonale principale è {diagP}");
        Console.WriteLine($"La diagonale secondaria è {diagS}");
        Console.WriteLine($"Il valore maggiore tra d principale e d secondaria è: {Math.Max(diagS, diagP)}");

        Console.WriteLine($"La somma totale della matrice è: {sum}");
    }

    public static void CreateList()
    {
        List<int> l = new List<int>();

        Console.WriteLine($"Inserisci 5 numeri all'interno della lista!");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Inserisci il {i + 1}° numero: ");
            l.Add(int.Parse(Console.ReadLine()));
        }
        Console.WriteLine($"Ci sono {l.Count()} elementi. Quale vuoi rimuovere? ");
        int rem = (int.Parse(Console.ReadLine())) - 1;
        Console.WriteLine($"{rem}");
        Console.ReadKey();

        l.RemoveAt(rem);
        Console.WriteLine($"Hai rimosso {l[rem]}");

        foreach (int i in l)
        {
            Console.WriteLine($"{i}");
        }
        Console.WriteLine($"Adesso ci sono {l.Count()} elementi.");
    }
}
