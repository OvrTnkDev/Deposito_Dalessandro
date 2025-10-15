using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Utils
{
    public class MobileApp : IObserver
    {
        public void Update(string message)
        {Console.WriteLine($"Notification on mobile: {message}");}
    }
}