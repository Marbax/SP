using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace reflex
{

    class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public void Print(string str) { Console.WriteLine($"\nI am print {str}"); }

        public int GetRndNum(double a, double b) => 21;

        public static void Foo() { }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Type pointType = typeof(Point);

            #region metadata
            PropertyInfo[] props = pointType.GetProperties();
            foreach (var item in props)
                Console.WriteLine(item.Name);

            Console.WriteLine();
            foreach (var method in pointType.GetMethods())
                Console.WriteLine(method.Name);

            Console.WriteLine();
            foreach (var field in pointType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance))
                Console.WriteLine(field.Name);


            Console.WriteLine();
            foreach (var method in pointType.GetMethods())
            {
                Console.Write($"{(method.IsPublic ? "public " : "private ")}");
                string returnType = method.ReturnType.Name;
                Console.Write(returnType + " ");
                Console.Write(method.Name+ "(");

                foreach (var param in method.GetParameters())
                    Console.Write($"{param.ParameterType.Name} {param.Name}, ");

                Console.WriteLine("\b\b); \n");
            }
            #endregion


            #region Invoke method
            Console.WriteLine();
            MethodInfo printMethod = pointType.GetMethod("Print");

            object oPoint = Activator.CreateInstance(pointType);
            printMethod.Invoke(oPoint, new object[] {"olololo" });
            Console.WriteLine();
            #endregion



        }
    }
}
