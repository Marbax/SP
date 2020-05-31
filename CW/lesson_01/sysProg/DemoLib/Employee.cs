using System;

namespace DemoLib
{
    [Serializable]
    public class Employee : Person
    {

        public string Position { get; set; }
        public decimal Salary { get; set; }

        public Employee() : this("", 0M, "", "", 0) { }

        public Employee(string position, decimal salary, string name, string lastName, int age) :
            base(name, lastName, age)
        {
            Position = position;
            Salary = salary;
        }

        public override string ToString() => base.ToString() + $" {Position} {Salary}";
    }
}
