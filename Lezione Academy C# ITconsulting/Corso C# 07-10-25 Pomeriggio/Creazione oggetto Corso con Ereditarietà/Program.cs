using Utils;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        bool check = true;
        var garageA = new List<Utils.Auto>();
        var garageM = new List<Utils.Moto>();

        while (check)
        {
            Console.Clear();
            Console.WriteLine("Benvenuto nel Garage!\n");
            Console.WriteLine("MENU PRINCIPALE");
            Console.WriteLine("1. Aggiungi un nuovo veicolo");
            Console.WriteLine("2. Mostra tutti i veicoli");
            Console.WriteLine("0. Esci\n");

            Console.Write("Scelta: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    check = false;
                    Console.WriteLine("Arrivederci!");
                    break;

                case "1":
                    Console.Write("\nInserisci la marca: ");
                    string marca = Console.ReadLine();

                    Console.Write("Inserisci il modello: ");
                    string modello = Console.ReadLine();

                    Console.WriteLine("È un'auto (1) o una moto (2)? ");
                    string tipo = Console.ReadLine();

                    if (tipo == "1")
                    {
                        Console.Write("Numero di porte: ");
                        int porte = int.Parse(Console.ReadLine());
                        garageA.Add(new Utils.Auto(marca, modello, porte));
                    }
                    else if (tipo == "2")
                    {
                        Console.Write("Tipo di manubrio: ");
                        string manubrio = Console.ReadLine();
                        garageM.Add(new Utils.Moto(marca, modello, manubrio));
                    }

                    Console.WriteLine("\nVeicolo aggiunto con successo!");
                    Console.WriteLine("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("GARAGE AUTO\n");
                    if (garageA.Count == 0)
                        Console.WriteLine("Nessuna auto presente.");
                    else
                        garageA.ForEach(a => Console.WriteLine(a));

                    Console.WriteLine("\nGARAGE MOTO\n");
                    if (garageM.Count == 0)
                        Console.WriteLine("Nessuna moto presente.");
                    else
                        garageM.ForEach(m => Console.WriteLine(m));

                    Console.WriteLine("\nPremi un tasto per tornare al menu...");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Scelta non valida. Riprova.");
                    break;
            }
        }
    }
}