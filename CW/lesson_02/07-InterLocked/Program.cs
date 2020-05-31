using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07_InterLocked
{
    class Program
    {
        // Счетчик запущеных потоков.
        static private long counter;
        static private readonly Random random = new Random();

        private static void Function()
        {
            int time = random.Next(1, 12);
            Thread.Sleep(time);

            // Поток увеличивает счетчик.
            //Interlocked.Increment(ref counter);

            counter++;
            try
            {
                // Поток ожидает произвольный период времени от 1 до 12 секунд.
                time = random.Next(1, 12);
                Thread.Sleep(time);
            }
            finally
            {
                // Поток уменьшает счетчик. 
                //Interlocked.Decrement(ref counter);
                counter--;
            }
        }

        // Проверка количества запущеных потоков. 
        private static void Report()
        {
            while (true)
            {
                long number = Interlocked.Read(ref counter);

                Console.WriteLine("{0} поток(ов) активно.", number);
                Thread.Sleep(100);
            }
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var reporter = new Thread(Report) { IsBackground = true };
            reporter.Start();

            var threads = new Thread[150];

            for (uint i = 0; i < 150; ++i)
            {
                threads[i] = new Thread(Function);
                threads[i].Start();
            }

            Thread.Sleep(10000);
        }
    }
}
