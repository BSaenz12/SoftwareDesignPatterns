using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.DesignPatterns
{
    public class Singleton
    {
        private static Singleton _instance;
        private static readonly object _lock = new object();

        // Private constructor to prevent instantiation
        private Singleton() { }

        // Public method to get the instance of the Singleton
        public static Singleton Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                    return _instance;
                }
            }
        }
    }

}
