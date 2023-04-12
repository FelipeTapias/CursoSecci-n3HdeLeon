using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor1 = new("Juan", 40, "Cirujano");
            Dev dev1 = new("Felipe", 20, "C#");
            Console.WriteLine(dev1.GetData());
            Console.WriteLine(doctor1.GetData());
        }

        class Person
        {
            private string _name;
            private int _age;

            public Person(string name, int age)
            {
                _name = name;
                _age = age;     
            }

            public string GetInfo()
            {
                return _name + " " + _age;
            }
        }

        class Doctor: Person
        {
            private string _speciality;
            public Doctor(string name, int age, string speciality) : base(name, age)
            {
                _speciality = speciality;
            }

            public string GetData()
            {
                return GetInfo() + " " + _speciality;
            }
        }

        class Dev: Person
        {
            private string _language;

            public Dev(string name, int age, string language): base(name, age)
            {
                _language = language;
            }

            public string GetData()
            {
                return GetInfo() + " " + _language;
            }
        }

    }
}