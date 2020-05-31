using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
// Lock - не принимает типов значений, а только ссылочные.
namespace _10_Monitor
{
    class Program
    {
        static private int counter = 0;

        // Нельзя использовать объекты блокировки структурного типа.
        // block - не может быть структурным.
        //static private int block = 0;
        static private object block = new object();

        static private void Function()
        {
            for (int i = 0; i < 50; ++i)
            {
                Thread.Sleep(11);

                //Console.WriteLine(++counter);
                lock ((object)block)
                {
                    Console.WriteLine(++counter);
                }
                //Console.WriteLine(++counter);
                // Устанавливается блокировка постоянно в новый object (boxing).
                //Monitor.Enter((object)block);
                //try
                //{
                //    Console.WriteLine(++counter);
                //}
                //finally
                //{
                //    // Попытка снять блокировку с незаблокированного объекта (boxing создает новый объект).
                //    Monitor.Exit((object)block);
                //}
            }
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread[] threads = { 
                new Thread(Function), 
                new Thread(Function), 
                new Thread(Function), 
                new Thread(Function), 
                new Thread(Function) };

            foreach (Thread t in threads)
            {
                t.Start();
            }
            Console.WriteLine(counter);
            // Задержка.
            Console.ReadKey();
        }
    }
}
