using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

/// <summary>
/// (c)Задания 1, 2 из домашки в конце урока
/// </summary>
namespace threads
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Task 1
            ///Создайте поток, который "принимает" в себя коллекцию элементов,
            ///и вызывает из каждого элемента коллекции метод ToString() и выводит результат работы метода на экран.
            Thread thread = new Thread(new ParameterizedThreadStart((obj) => (obj as List<string>).ForEach(i => Console.WriteLine($"{i} - {Thread.CurrentThread.ManagedThreadId}"))));
            thread.Start(new List<string> { "asd", "qwe", "eeee", "oueee", "qwe", "eeee", "oueee" });
            #endregion

            #region Task 2
            Bank bank = new Bank { Name = default, Money = default, Percent = default };
            bank.Name = "Unprivate bank";
            bank.Money = 2000;
            bank.Percent = 3;
            #endregion



            Console.ReadKey();
        }

        #region Task 1
        private static void PrintCollection(object obj)
        {
            (obj as List<string>).ForEach(i => Console.WriteLine($"{i} - {Thread.CurrentThread.ManagedThreadId}"));
        }
        #endregion
    }

    #region Task 2
    /// <summary>
    /// Создайте класс Bank, в котором будут следующие свойства: int money, string name, int percent.
    /// Постройте класс так, чтобы при изменении одного из свойств, класса создавался новый поток, который записывал
    /// данные о свойствах класса в текстовый файл на жестком диске. 
    /// Класс должен инкапсулировать в себе всю логику многопоточности.
    /// </summary>
    public class Bank
    {
        private readonly object locker = new object();

        private int _money;
        public int Money
        {
            get { return _money; }
            set { UpdateProperty(ref _money, value); }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { UpdateProperty(ref _name, value); }
        }

        private int _percent;
        public int Percent
        {
            get { return _percent; }
            set { UpdateProperty(ref _percent, value); }
        }

        private void UpdateProperty<T>(ref T oldValue, T newValue)
        {
            if (!oldValue?.Equals(newValue) ?? newValue != null)
            {
                Thread thread = new Thread(LogData);
                thread.Start();
                thread.Join();
                oldValue = newValue;
            }
        }

        private void LogData()
        {
            lock (locker)
            {
                string props = $"at {DateTime.Now}(thread-{Thread.CurrentThread.ManagedThreadId}) : {nameof(Money)}={Money} , {nameof(Name)}={Name} , {nameof(Percent)}={Percent}\n";
                using (FileStream fs = new FileStream("log.txt", FileMode.OpenOrCreate))
                {
                    fs.Seek(0, SeekOrigin.End);
                    fs.Write(Encoding.UTF8.GetBytes(props), 0, props.Length);
                }
            }


        }
    }
    #endregion

}
