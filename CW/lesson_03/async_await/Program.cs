using System;
using System.Threading;
using System.Threading.Tasks;

namespace async_await
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TaskReturnTest.Start();

            Console.ReadLine();
        }

    }

    public static class TaskVoidTest
    {
        private static void Print(string str)
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"{str}Task {Thread.CurrentThread.ManagedThreadId}# {i}");
            }
        }

        public static void Start()
        {
            Task thread = new Task(() => Print(""));
            Task thread1 = new Task(() => Print("\t\t"));
            Task task = Task.Factory.StartNew(() => Print("\t"));

            thread.Start();
            thread1.Start();


            Task.WaitAll(thread, thread1, task);
        }
    }

    public class TaskReturnTest
    {
        private static int Fact(int n)
        {
            Thread.Sleep(1000);
            if (n == 0)
                return 1;
            return n * Fact(n - 1);
        }

        public static Task<int> FactAsync(int n)
        {
            return Task.Factory.StartNew(() => Fact(n));
        }

        public static void Start()
        {

            //Task.Factory.StartNew(() =>
            //{
            //    Task<int> res = FactAsync(5);
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine($"result = {res.Result}");// блокирующая строка
            //});

            Task<int> res = FactAsync(5);

            // колбек , то ,что нужно сделать по завершению таска
            res.ContinueWith((t) =>
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"res = {res.Result}");
            });

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-------------");
                Thread.Sleep(200);
            }
        }
    }

    public class CancelationTokenSample
    {
        private static CancellationToken token;

        private static CancellationTokenSource tokenSource;

        static CancelationTokenSample()
        {
            tokenSource = new CancellationTokenSource();
            token = tokenSource.Token;
        }

        public static void Start()
        {
            Task task = new Task(() => Print());
            task.Start();
            while (true)
            {
                Console.ReadKey();
                tokenSource.Cancel();
            }

        }

        private static void Print()
        {
            while (true)
            {
                //if (token.IsCancellationRequested)
                //    break;
                try
                {
                    token.ThrowIfCancellationRequested();
                }
                catch (OperationCanceledException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Token cancaled");
                    tokenSource = new CancellationTokenSource();
                    token = tokenSource.Token;
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                Console.WriteLine("Hello world");
                Thread.Sleep(300);
            };
        }
    }

    public class AsyncTaskReturnTest
    {
        private static int Fact(int n)
        {
            Thread.Sleep(1000);
            if (n == 0)
                return 1;
            return n * Fact(n - 1);
        }

        private static Task<int> FactAsync(int n)
        {
            return Task.Factory.StartNew(() => Fact(n));
        }

        private static async void PrintFact()
        {
            // before
            int res = await FactAsync(6);// awawit распаковует таску и то ,что дальше будет как кол бек
            // after
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"result = {res}");

        }

        public static void Start()
        {

            PrintFact();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-------------");
                Thread.Sleep(200);
            }
        }
    }

}
