namespace Utils
{
    public class CorsoPittura : Corso
    {
        public string Tecnica;

        public CorsoPittura(string nomeCorso, int durataOre, string docente, List<string> studenti, string tecnica)
                          : base(nomeCorso, durataOre, docente, studenti)
        {
            Tecnica = tecnica;
        }

        public override string ToString()
        {
            return base.ToString() + $"\tTecnica: {Tecnica}";
        }

        public override sealed void MetodoSpeciale()
        {
            Console.WriteLine($"Si lavora su una tela con tecnica: {Tecnica}");
            
        }
    }
}