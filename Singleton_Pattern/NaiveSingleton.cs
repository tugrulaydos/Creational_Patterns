using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    internal sealed class NaiveSingleton
    {
        private static NaiveSingleton _instance;

        public string Value { get; set; }

        private NaiveSingleton()
        {

        }

        public static NaiveSingleton GetInstance()
        {

            if(_instance == null )
            {
                _instance = new NaiveSingleton();
            }

            return _instance;

        }

    }
}
