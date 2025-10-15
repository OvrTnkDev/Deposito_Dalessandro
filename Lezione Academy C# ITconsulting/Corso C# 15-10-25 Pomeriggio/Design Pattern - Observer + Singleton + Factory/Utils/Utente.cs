using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Utils
{
    //Utente implementa IUser
    public class Utente : IUser
    {
        public string Nome { get; }

        public Utente(string nome)
        {
            Nome = nome;
        }

        public void CreaUtente()
        {
            Console.WriteLine($"Utente {Nome} creato!");
        }
    }
}