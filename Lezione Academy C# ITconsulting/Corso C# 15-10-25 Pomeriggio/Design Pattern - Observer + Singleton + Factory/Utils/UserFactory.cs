using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Utils
{
    public static class UserFactory
    {
        public static IUser Crea(string nomeUtente)
        {
            return new Utente(nomeUtente);
        }
    }
}