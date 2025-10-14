using System;
using System.Collections.Generic;

namespace Utils.Singleton
{
    public sealed class ConfigurazioneSistema
    {
            // Lazy + thread-safe
    private static readonly Lazy<ConfigurazioneSistema> _lazy =
        new Lazy<ConfigurazioneSistema>(() => new ConfigurazioneSistema());

    public static ConfigurazioneSistema Instance => _lazy.Value;
        private readonly Dictionary<string, string> _myDict = new();
        private static ConfigurazioneSistema _instance;

        private ConfigurazioneSistema() { }

        public void Imposta(string k, string v)
        {
            if (string.IsNullOrWhiteSpace(k))
                throw new ArgumentException("La chiave non può essere vuota.", nameof(k));

            if (_myDict.ContainsKey(k))
                _myDict[k] = v;      // Aggiorna
            else
                _myDict.Add(k, v);   // Inserisce
        }

        public string? Leggi(string k)
        {
            if (_myDict.TryGetValue(k, out var value))
                return value;

            throw new KeyNotFoundException($"Chiave '{k}' non trovata");
        }

        public void StampaTutte()
        {
            foreach (var (key, value) in _myDict)
            {
                Console.WriteLine($"Key: {key}\tValue: {value}");
            }
        }
    }
}
