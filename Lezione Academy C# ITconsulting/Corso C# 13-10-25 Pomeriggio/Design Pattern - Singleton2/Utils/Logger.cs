using System;
using System.ComponentModel.Design;

namespace Utils
{
    public sealed class Logger
    {
        private static Logger _instance;

        private Logger() { }

        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Logger();
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
