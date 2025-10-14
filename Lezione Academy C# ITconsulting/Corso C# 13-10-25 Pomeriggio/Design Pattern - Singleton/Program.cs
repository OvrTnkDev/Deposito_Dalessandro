using Utils;
class Program
{
    static void Main(string[] args)
    {
        bool check = true;
        var logger = Logger.Instance;
        
        do
        {
            Console.WriteLine(logger.ScriviMessaggio("Applicazione avviata"));

            Console.WriteLine($"1 per uscire");
            if (Console.ReadLine() == "1") { check = false; }
        } while (check);
    }
}
