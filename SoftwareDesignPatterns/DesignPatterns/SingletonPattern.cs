using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.DesignPatterns
{

//           Problem:
//          Ensure that a class has only one instance, and provide a global point of access to that instance.

//          Solution:
//        The Singleton pattern ensures that a class has only one instance and provides a method
//        to access that instance.This pattern is useful when you need to control access to shared resources,
//        such as a configuration manager or a connection pool.

    public class SingletonPattern
    {
        private static SingletonPattern _instance;
        private static readonly object _lock = new object();

        // Private constructor to prevent instantiation
        private SingletonPattern() { }

        // Public method to get the instance of the Singleton
        public static SingletonPattern Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonPattern();
                    }
                    return _instance;
                }
            }
        }
    }

}
