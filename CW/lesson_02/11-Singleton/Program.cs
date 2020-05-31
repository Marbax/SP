using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11_Singleton
{
    class Program
    {
        static void Function()
        {
            Singleton singleton = Singleton.GetInstance();

            Console.WriteLine($"singleton create; HAshCode = {singleton.GetHashCode()}");

        }


        static void Main(string[] args)
        {
            var threads = new Thread[150];

            for (uint i = 0; i < 150; ++i)
            {
                threads[i] = new Thread(Function) { IsBackground = false };
                threads[i].Start();
            }
            Console.ReadKey();
        }
    }
}
