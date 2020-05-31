using System;

namespace DemoLib
{
    public enum FamalyStatus { Married, Single };

    [Serializable]
    public class Person
    {

        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public FamalyStatus Status { get; set; }

        public Person() : this("", "", 0) { }

        public Person(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Status = FamalyStatus.Single;
        }


        public override string ToString() => $"{Name} {LastName} {Age} {Status}";
    }
}
