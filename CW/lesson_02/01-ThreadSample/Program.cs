using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_ThreadSample
{
    class Program
    {
        // Метод выполяняющийся во Вторичном потоке.
        private static void Method()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Method Start");
            Thread.Sleep(10000);
            Console.WriteLine("Method End");
        }

        private static void ThreadFunc()
        {
            Console.WriteLine($"ID Вторичного потока: {Thread.CurrentThread.ManagedThreadId}" );
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < 160; i++)
            {
                Thread.Sleep(20);
                Console.Write(".");
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Вторичный поток завершился.");
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //// Создание нового потока.
            ////var thread = new Thread(new ThreadStart(ThreadFunc));
            var thread = new Thread(ThreadFunc);
            Console.WriteLine($"GetHashCode Первичного потока: {Thread.CurrentThread.GetHashCode()} \n" );
            Console.WriteLine($"ID Первичного потока: {Thread.CurrentThread.ManagedThreadId} \n");
            //Console.WriteLine("Запуск нового потока...");

            thread.Start();
            //Console.WriteLine(Thread.CurrentThread.GetHashCode());
            //// Ожидание первичным потоком, завершения работы вторичного потока.
            //thread.Join(); //TODO Снять комментарий.
           
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Test");
            for (int i = 0; i < 160; i++)
            {
                Thread.Sleep(20);
                Console.Write("-");
            }

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\nПервичный поток завершился.");

            // Задержка.
            Console.ReadKey();
        }
    }
}
