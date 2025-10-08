namespace Utils
{
    public class CorsoMusica : Corso
    {
        public string Strumento;

        public CorsoMusica(string nomeCorso, int durataOre, string docente, List<string> studenti, string strumento)
                          : base(nomeCorso, durataOre, docente, studenti)
        {
            Strumento = strumento;
        }

        public override string ToString()
        {
            return base.ToString() + $"\tStrumento: {Strumento}";
        }

        public override sealed void MetodoSpeciale()
        {
            Console.WriteLine($"Si tiene una prova pratica dello strumento: {Strumento}");
            
        }

    }
}