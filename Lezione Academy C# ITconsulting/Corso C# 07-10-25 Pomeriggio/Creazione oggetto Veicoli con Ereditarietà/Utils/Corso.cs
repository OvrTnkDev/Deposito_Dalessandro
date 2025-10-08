namespace Utils
{
    public class Corso
    {
        public string NomeCorso;
        public int DurataOre;
        public string Docente;
        public List<string> Studenti;

        public Corso(string nomeCorso, int durataOre, string docente, List<string> studenti)
        {
            NomeCorso = nomeCorso;
            DurataOre = durataOre;
            Docente = docente;
            Studenti = studenti;
        }

        public virtual string ToString()
        {
            return $"Nome del Corso: {NomeCorso}\tDurata delle Ore: {DurataOre}\t" +
                    $"Docente: {Docente}\tStudenti{Studenti}";
        }

        public virtual void MetodoSpeciale()
        {
            Console.WriteLine($"");
            
        }
    }
}
