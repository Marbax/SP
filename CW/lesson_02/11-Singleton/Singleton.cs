using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Singleton
{
    class Singleton
    {
        static Singleton singleton;
        static private readonly object block = new object();
        static Singleton()
        {
            //singleton = new Singleton();
        }
        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if (singleton != null) return singleton;
            //singleton = new Singleton();
            lock (block)
            {
                if (singleton != null) return singleton;
                singleton = new Singleton();
            }
            return singleton;
        }


    }
}
