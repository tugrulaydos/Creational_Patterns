using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    //Thread Safe Singleton
    internal class Singleton
    {
        private static Singleton _instance;

        private static readonly object _lock = new object();
        public string Value { get; set; } //We'll use this this property to prove our singleton really works.
        private Singleton()
        {


        }        

        public static Singleton GetInstance(string value)
        {

            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {                     
                         
                        _instance = new Singleton();
                        _instance.Value = value;
                    }
                }

            }

            return _instance;
          

        }
       
    }
}
