using System;

#region INTERFACCIA
// IProdotto: contratto base per tutti i tipi di prodotto venduti nel negozio.
// Cosa fa: espone proprietà e metodi minimi necessari (Nome, PrezzoBase, Descrizione)
// Perché: permette di trattare in modo uniforme gadget, skin, oggetti digitali, ecc.
//          Codice client e strategie possono dipendere su questa interfaccia senza
//          conoscere le implementazioni concrete.
public interface IProdotto
{
    // Nome identificativo del prodotto (readonly per il consumatore dell'interfaccia)
    string Nome { get; }

    // Prezzo base del prodotto prima di applicare sconti/tasse/strategie di prezzo
    decimal PrezzoBase { get; }

    // Restituisce una descrizione leggibile del prodotto (responsabilità di ogni implementazione)
    string Descrizione();
}

// IAddon: estende IProdotto per rappresentare un componente aggiuntivo o "addon".
// Cosa fa: reusa il contratto di IProdotto senza aggiungere nuovi membri.
// Perché: tipizzare addon separatamente permette, nel codice, di riconoscere e gestire
//          esplicitamente gli addon (per esempio per applicare regole diverse rispetto ai prodotti principali).
public interface IAddon : IProdotto { }

// IPricingStrategy: strategia che calcola il prezzo di un prodotto.
// Cosa fa: definisce un metodo che, dato un IProdotto, restituisce il prezzo finale.
// Perché: incapsula diverse politiche di pricing (sconti, tasse, bundle, promozioni) e
//          permette di cambiarle senza modificare le classi prodotto (Pattern Strategy).
public interface IPricingStrategy
{
    // Calcola e restituisce il prezzo finale (potrebbe includere sconti, IVA, arrotondamenti, ecc.)
    decimal CalcolaPrezzo(IProdotto prodotto);
}

// IOrderObserver: semplice observer per ricevere notifiche sugli ordini.
// Cosa fa: espone un metodo Aggiorna che passa un messaggio o stato al ricevente.
// Perché: supporta un meccanismo di notifica/pub-sub tra componenti (es. per logging,
//          aggiornare UI, inviare email) senza legare l'ordine a implementazioni concrete.
public interface IOrderObserver
{
    // Viene chiamato per notificare eventi o aggiornamenti rilevanti
    void Aggiorna(string messaggio);
}
#endregion

#region SINGLETON
public sealed class ShopContext
{
    // Campo che tiene l'istanza singola (Singleton).
    // Nota: per evitare il warning di nullable, possiamo dichiararlo come nullable
    // oppure inizializzarlo immediatamente. Qui dichiariamo come nullable per chiarezza.
    private static ShopContext? _instance;

    // Valuta e IVA sono configurazioni globali condivise dall'applicazione.
    // Sono proprietà modificabili per permettere test o configurazioni runtime.
    public string Valuta { get; set; } = "€";
    public decimal IVA { get; set; } = 0.22m;

    // Costruttore privato impedisce la creazione esterna dell'istanza, garantendo
    // che l'accesso avvenga solo tramite la proprietà statica Instance.
    private ShopContext() { }

    // Instance: accesso alla singola istanza (lazy-initialization).
    // Per semplicita' usiamo l'operatore di coalescenza assegnante (??=).
    // Se è necessaria la thread-safety in un'app multithread, considerare
    // l'uso di 'Lazy<ShopContext>' oppure un lock esplicito.
    public static ShopContext Instance => _instance ??= new ShopContext();
}
#endregion

#region CLASSI CONCRETE
// Gadget: implementazione concreta di IProdotto che rappresenta prodotti fisici "gadget".
// Cosa fa: incapsula nome e prezzo base e fornisce una descrizione formattata.
// Perché: separare il dato concreto permette di aggiungere nuove tipologie di prodotto
//          senza modificare il codice che consuma IProdotto (aperto per estensione).
public class Gadget : IProdotto
{
    public string Nome { get; private set; }
    public decimal PrezzoBase { get; private set; }

    public Gadget(string nome, decimal prezzo)
    {
        Nome = nome;
        PrezzoBase = prezzo;
    }

    public string Descrizione() => $"[Gadget] {Nome} - Prezzo: {PrezzoBase:C2}";
    
    // Lista predefinita
    public static List<Gadget> ListaPredefinita => new List<Gadget>
    {
        new Gadget("Portachiavi", 5.99m),
        new Gadget("Tazza", 9.99m),
        new Gadget("Cappellino", 14.99m)
    };
}

public class Skin : IProdotto
{
    public string Nome { get; private set; }
    public decimal PrezzoBase { get; private set; }

    public Skin(string nome, decimal prezzo)
    {
        Nome = nome;
        PrezzoBase = prezzo;
    }

    public string Descrizione() => $"[Skin] {Nome} - Prezzo: {PrezzoBase:C2}";

    public static List<Skin> ListaPredefinita => new List<Skin>
    {
        new Skin("Skin Rossa", 2.99m),
        new Skin("Skin Blu", 2.99m),
        new Skin("Skin Dorata", 4.99m)
    };
}

public class OggettoDigitale : IProdotto
{
    public string Nome { get; private set; }
    public decimal PrezzoBase { get; private set; }

    public OggettoDigitale(string nome, decimal prezzo)
    {
        Nome = nome;
        PrezzoBase = prezzo;
    }

    public string Descrizione() => $"[Digitale] {Nome} - Prezzo: {PrezzoBase:C2}";

    public static List<OggettoDigitale> ListaPredefinita => new List<OggettoDigitale>
    {
        new OggettoDigitale("E-book", 6.99m),
        new OggettoDigitale("Musica MP3", 1.99m),
        new OggettoDigitale("Video Tutorial", 14.99m)
    };
}
#endregion

#region DECORATORE ASTRATTO
#endregion

#region MAIN
#endregion