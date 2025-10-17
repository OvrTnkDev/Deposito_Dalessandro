using System;
using System.Collections.Generic;
using System.Linq;

#region SINGLETON PATTERN
sealed class AppFunzionale
{
    private static readonly Lazy<AppFunzionale> lazy =
        new Lazy<AppFunzionale>(() => new AppFunzionale());

    public static AppFunzionale Instance => lazy.Value;

    private AppFunzionale() { }
}
#endregion

#region CLASSE UTENTE
public class Utente
{
    private int _Id;
    private int Id { get => _Id; set => _Id = value; }

    public string Username { get; set; }
    public string Email { get; set; }
    public DateTime DataCreazione { get; set; }
    public bool IsActive { get; set; }
    public Utente(string Username, string Email, DateTime DataCreazione, bool IsActive)
    {
        this.Username = Username;
        this.Email = Email;
        this.DataCreazione = DataCreazione;
        this.IsActive = IsActive;
    }
}

public class GestioneUtenti
{
    private Dictionary<int, List<Utente>> dizionarioUtenti = new Dictionary<int, List<Utente>>();

    public void AggiungiUtente(int id, Utente utente)
    {
        if (!dizionarioUtenti.ContainsKey(id))
        {
            dizionarioUtenti.Add(id, new List<Utente>());
        }
        dizionarioUtenti[id].Add(utente);
    }

    public void RimuoviUtente(int id)
    {
        if (dizionarioUtenti.ContainsKey(id))
        {
            dizionarioUtenti.Remove(id);
        }
    }

    public Utente OttieniUtente(int id)
    {
        dizionarioUtenti.TryGetValue(id, out List<Utente> utenti);
        return utenti?.FirstOrDefault();
    }

    public List<Utente> OttieniUtentiAttivi()
    {
        return dizionarioUtenti.Values.SelectMany(u => u).Where(u => u.IsActive).ToList();
    }

    public List<Utente> OttieniUtentiNonAttivi()
    {
        return dizionarioUtenti.Values.SelectMany(u => u).Where(u => !u.IsActive).ToList();
    }
    public List<Utente> OttieniTuttiUtenti()
    {
        return dizionarioUtenti.Values.SelectMany(u => u).ToList();
    }
}
#endregion

#region CLIENT
public class Program
{
    public static void Main(string[] Args)
    {
        AppFunzionale app = AppFunzionale.Instance;
        GestioneUtenti gestioneU = new GestioneUtenti();

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"__Menù Admin Gestione Utente__");
            
            Console.WriteLine($"1. Aggiungi Utente");
            Console.WriteLine($"2. Rimuovi Utente");
            Console.WriteLine($"3. Ottieni Utente");
            Console.WriteLine($"4. Ottieni Utenti Attivi");
            Console.WriteLine($"5. Ottieni Utenti Non Attivi");
            Console.WriteLine($"6. Esci");
            Console.Write("Seleziona un'opzione: ");

            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    // Aggiungi Utente
                    Console.Write("Inserisci ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Inserisci Username: ");
                    string username = Console.ReadLine();
                    Console.Write("Inserisci Email: ");
                    string email = Console.ReadLine();
                    DateTime dataCreazione = DateTime.Now;
                    Console.Write("Utente Attivo? (s/n): ");
                    bool isActive = Console.ReadLine().ToLower() == "s";

                    Utente nuovoUtente = new Utente(username, email, dataCreazione, isActive);
                    gestioneU.AggiungiUtente(id, nuovoUtente);
                    break;
                case "2":
                    // Rimuovi Utente
                    Console.Write("Inserisci ID Utente da rimuovere: ");
                    int idRimuovi = int.Parse(Console.ReadLine());
                    gestioneU.RimuoviUtente(idRimuovi);
                    break;
                case "3":
                    // Ottieni Utente
                    Console.Write("Inserisci ID Utente da ottenere: ");
                    int idOttieni = int.Parse(Console.ReadLine());
                    Utente utenteOttenuto = gestioneU.OttieniUtente(idOttieni);
                    if (utenteOttenuto != null)
                    {
                        Console.WriteLine($"Username: {utenteOttenuto.Username}, Email: {utenteOttenuto.Email}, Data Creazione: {utenteOttenuto.DataCreazione}, Attivo: {utenteOttenuto.IsActive}");
                    }
                    else
                    {
                        Console.WriteLine("Utente non trovato.");
                    }
                    break;
                case "4":
                    // Ottieni Utenti Attivi
                    List<Utente> utentiAttivi = gestioneU.OttieniUtentiAttivi();
                    if (utentiAttivi.Count > 0)
                    {
                        Console.WriteLine("Utenti Attivi:");
                        foreach (Utente utente in utentiAttivi)
                        {
                            Console.WriteLine($"Username: {utente.Username}, Email: {utente.Email}, Data Creazione: {utente.DataCreazione}, Attivo: {utente.IsActive}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nessun utente attivo trovato.");
                    }
                    break;
                case "5":
                    // Ottieni Utenti Non Attivi
                    List<Utente> utentiNonAttivi = gestioneU.OttieniUtentiNonAttivi();
                    if (utentiNonAttivi.Count > 0)
                    {
                        Console.WriteLine("Utenti Non Attivi:");
                        foreach (Utente utente in utentiNonAttivi)
                        {
                            Console.WriteLine($"Username: {utente.Username}, Email: {utente.Email}, Data Creazione: {utente.DataCreazione}, Attivo: {utente.IsActive}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nessun utente non attivo trovato.");
                    }
                    break;
                case "6":
                    //Esci
                    return;
                default:
                    Console.WriteLine("Opzione non valida.");
                    break;
            }
        }

    }
}
#endregion