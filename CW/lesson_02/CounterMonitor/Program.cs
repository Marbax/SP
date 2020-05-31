using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CounterMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = new MyCounter();
            Thread[] thread = new Thread[5];
            for (int i = 0; i < 5; i++)
            {
                thread[i] = new Thread(counter.UpdateFields);
                thread[i].Start();
            }

            for (int i = 0; i < 100; i++)
            {
                Console.Write(counter.Count + " ");
                Thread.Sleep(10);
            }
            Console.ReadKey();
        }

        class MyCounter
        {
            // для блокировки
            private object locker = new object();
            int count;
            public int Count
            {
                get { return count; }
            }
            public void UpdateFields()
            {
                for (int i = 0; i < 1000000; ++i)
                {
                    //++count;

                    // 1. Cпособ синхронизации
                    //Interlocked.Increment(ref count);

                    // 2. Cпособ синхронизации Monitor
                    //try
                    //{
                    //    Monitor.Enter(locker);
                    //    ++count;
                    //}
                    //finally
                    //{
                    //    Monitor.Exit(locker);
                    //}

                    // 3. Cпособ синхронизации lock
                    lock (locker)
                    {
                        ++count;
                    }
                }
            }

        }


    }
}
