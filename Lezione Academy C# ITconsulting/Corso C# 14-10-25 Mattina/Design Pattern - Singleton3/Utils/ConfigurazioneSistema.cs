using System;
using System.Collections.Generic;

namespace Utils
{
    public sealed class ConfigurazioneSistema
    {
        private readonly Dictionary<string, string> _myDict = new();
        private static ConfigurazioneSistema _instance;

        private ConfigurazioneSistema() { }

        public static ConfigurazioneSistema Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConfigurazioneSistema();
                }
                return _instance;
            }
        }

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
