using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03_GlobalVar
{
    class Program
    {
        // Общая переменная счетчик.
        //[ThreadStatic] //TODO Снять комментарий Для каждого потока - свой экз.переменной counter
        public static int counter;

        // Рекурсивный запуск потоков.
        public static void Method()
        {
            if (counter < 100)
            {
                counter++; // Увеличение счетчика вызваных методов.
                Console.WriteLine(counter + " - СТАРТ --- " + Thread.CurrentThread.GetHashCode());
                var thread = new Thread(Method);
                thread.Start();
                //thread.Join(); // Закомментировать.               
            }

            Console.WriteLine("Поток {0} завершился.", Thread.CurrentThread.GetHashCode());
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Запуск вторичного потока.
            var thread = new Thread(Method);
            thread.Start();
            //thread.Join();

            Console.WriteLine("Основной поток завершил работу...");

            // Задержка.
            Console.ReadKey();
        }
    }
}
