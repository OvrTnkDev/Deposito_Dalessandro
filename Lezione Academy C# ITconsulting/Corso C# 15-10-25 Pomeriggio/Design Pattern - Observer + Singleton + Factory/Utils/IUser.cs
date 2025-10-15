using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Utils
{
    // 1. IUser: definisce l'interfaccia dell'utente da creare
    public interface IUser
    {
        string Nome { get; }
        void CreaUtente();
    }
}