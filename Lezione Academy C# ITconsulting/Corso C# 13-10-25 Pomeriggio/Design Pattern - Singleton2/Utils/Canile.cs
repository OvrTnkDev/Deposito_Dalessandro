using System;
using System.ComponentModel.Design;

namespace Utils
{
    public sealed class Canile
    {
        private static Canile _instance;

        private Canile() { }

        public static Canile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Canile();
                }
                return _instance;
            }
        }

        public string Log(string messaggio)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            return $"{timestamp}\t{messaggio}";
        }
    }
}
