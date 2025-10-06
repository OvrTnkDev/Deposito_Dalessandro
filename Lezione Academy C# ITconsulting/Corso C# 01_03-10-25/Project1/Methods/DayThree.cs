namespace Methods
{
    public static class DayThree
    {
        public static void SommaGiorno3()
        {
            Console.WriteLine($"La somma int: {Utils.Somma(33, 45)}");
            Console.WriteLine($"La somma double: {Utils.Somma(33.7912d, 45.1243d)}");
            Console.WriteLine($"La somma float: {Utils.Somma(33.79f, 45.12f)}");
            Console.WriteLine($"La somma int 3 parametri: {Utils.Somma(33, 45, 49)}");
        }

        public static void AnalizzaTesto()
        {
            Console.Write("Inserisci un testo: ");
            string testo = Console.ReadLine();
            Console.WriteLine($"Caratteri senza spazi: {Utils.Analizza(testo)}");
        }

        public static void AnalizzaLettera()
        {
            Console.Write("Inserisci un testo: ");
            string testo = Console.ReadLine();
            Console.Write("Inserisci la lettera da ricercare: ");
            char lettera = char.Parse(Console.ReadLine());
            Console.WriteLine($"La lettera '{lettera}' compare {Utils.Analizza(testo, lettera)} volte");
        }

        public static void AnalizzaVocaliConsonanti()
        {
            Console.Write("Inserisci un testo: ");
            string testo = Console.ReadLine();
            Console.Write("True per consonanti / False per vocali: ");
            bool isConsonanti = bool.Parse(Console.ReadLine());
            Utils.Analizza(testo, isConsonanti);
        }

        public static void MatriciPersonalizzate()
        {
            Console.Write("Dimensioni righe: ");
            int righe = int.Parse(Console.ReadLine());
            Console.Write("Dimensioni colonne: ");
            int colonne = int.Parse(Console.ReadLine());
            ArrayUtils.CalcolaStampaMatrici(righe, colonne);
        }

        public static void ArrayCasuale()
        {
            Console.Write("Lunghezza del vettore: ");
            int lunghezza = int.Parse(Console.ReadLine());
            ArrayUtils.RandomArray(lunghezza);
        }

        public static void ArrayRiordinato()
        {
            Console.Write("Lunghezza del vettore: ");
            int lunghezza = int.Parse(Console.ReadLine());
            ArrayUtils.ArrayReord(lunghezza);
        }

        public static void MatriciPredefinite()
        {
            ArrayUtils.Matrici4x4();
            ArrayUtils.Matrici5x5();
        }

        public static void GestisciListe()
        {
            ArrayUtils.CreateList();
        }
    }
}
