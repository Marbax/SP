using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06_Priority
{
    // Приоритеты потоков. 

    class ThreadWork
    {
        public Thread RunThread;
        static bool _stop;
        readonly ConsoleColor color;

        public int Count { get; set; }

        public ThreadWork(string name, ConsoleColor color)
        {
            RunThread = new Thread(Run) { Name = name };
            this.color = color;
            Console.ForegroundColor = this.color;
            Console.WriteLine("Поток " + RunThread.Name + " начат.");
        }

        void Run()
        {
            do
            {
                Count++;
            }
            while (_stop == false && Count < 20000000);

            _stop = true;
            Console.WriteLine("\nПоток " + RunThread.Name + " завершен.");
        }

        public void BeginInvoke()
        {
            RunThread.Start();
        }

        public void EndInvoke()
        {
            RunThread.Join();
        }

        public ThreadPriority Priority
        {
            set { RunThread.Priority = value; }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.SetWindowSize(80, 40);

            var work1 = new ThreadWork("с высоким приоритетом", ConsoleColor.Red);
            var work2 = new ThreadWork("с низким приоритетом", ConsoleColor.Yellow);
            var work3 = new ThreadWork("с низким приоритетом", ConsoleColor.White);
            var work4 = new ThreadWork("с высоким приоритетом", ConsoleColor.Green);
            var work5 = new ThreadWork("с низким приоритетом", ConsoleColor.Cyan);
            var work6 = new ThreadWork("с высоким приоритетом", ConsoleColor.DarkBlue);

            // Установить приоритеты для потоков. 
            work1.Priority = ThreadPriority.Highest;
            work2.Priority = ThreadPriority.Lowest;
            work3.Priority = ThreadPriority.Lowest;
            work4.Priority = ThreadPriority.Highest;
            work5.Priority = ThreadPriority.Lowest;
            work6.Priority = ThreadPriority.Highest;

            work2.BeginInvoke();
            work1.BeginInvoke();
            work4.BeginInvoke();
            work3.BeginInvoke();
            work5.BeginInvoke();
            work6.BeginInvoke();


            work1.EndInvoke();
            work4.EndInvoke();
            work3.EndInvoke();
            work5.EndInvoke();
            work2.EndInvoke();
            work6.EndInvoke();

            Console.WriteLine();
            Console.WriteLine("Поток " + work1.RunThread.Name + " досчитал до " + work1.Count);
            Console.WriteLine("Поток " + work2.RunThread.Name + " досчитал до " + work2.Count);
            Console.WriteLine("Поток " + work3.RunThread.Name + " досчитал до " + work3.Count);
            Console.WriteLine("Поток " + work4.RunThread.Name + " досчитал до " + work4.Count);
            Console.WriteLine("Поток " + work5.RunThread.Name + " досчитал до " + work5.Count);
            Console.WriteLine("Поток " + work6.RunThread.Name + " досчитал до " + work6.Count);

            // Delay.
            Console.ReadKey();
        }
    }
}
