using System;

namespace Utils.Utility
{
    public static class Utility
    {
        public static void GustiDisponibili()
        {
            string[] gusti = { "Mango", "Fragola", "Limone", "Uva", "Pomodoro", "Peperoncino" };
            double[] prezzi = { 0.90, 0.70, 0.40, 1.20, 1.60, 1.90 };

            Console.Clear();
            Console.WriteLine("Benvenuto nella gelateria DolceGelo!");
            Console.WriteLine("Oggi abbiamo i seguenti gusti disponibili:\n");

            if (gusti.Length != prezzi.Length)
            {
                Console.WriteLine("Errore: il numero di gusti non corrisponde al numero di prezzi!");
                Console.WriteLine("Premi un tasto per tornare al menu principale...");
                Console.ReadKey();
                return;
            }

            for (int i = 0; i < gusti.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {gusti[i]} \t -> {prezzi[i]:0.00}$");
            }

            Console.WriteLine("\nScegli il tuo gusto inserendo il numero corrispondente (oppure 0 per tornare indietro):");
            Console.Write("Scelta: ");

            string input = Console.ReadLine();

            if (!int.TryParse(input, out int scelta))
            {
                Console.WriteLine("\nInput non valido! Premi un tasto per tornare al menu...");
                Console.ReadKey();
                return;
            }

            if (scelta == 0)
            {
                Console.WriteLine("\nTorno al menu principale...");
                return;
            }

            if (scelta < 1 || scelta > gusti.Length)
            {
                Console.WriteLine("\nScelta non valida! Premi un tasto per tornare al menu...");
                Console.ReadKey();
                return;
            }

            int index = scelta - 1;
            Console.WriteLine($"\nHai scelto il gusto ->{gusti[index]}<-, prezzo: {prezzi[index]:0.00}$");
            Console.WriteLine("Grazie per aver scelto DolceGelo");
            Console.WriteLine("\nPremi un tasto per tornare al menu principale...");
            Console.ReadKey();
        }
    }
}
