namespace Utils
{
    public class CorsoDanza : Corso
    {
        public string Stile;

        public CorsoDanza(string nomeCorso, int durataOre, string docente, List<string> studenti, string stile)
                          : base(nomeCorso, durataOre, docente, studenti)
        {
            Stile = stile;
        }

        public override string ToString()
        {
            return base.ToString() + $"\tStile: {Stile}";
        }

        public override sealed void MetodoSpeciale()
        {
            Console.WriteLine($"Esecuzione coreografica nello stile: {Stile}");
            
        }
    }
}