using System;
using System.Xml.Linq;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> numbers = new(10);
            numbers.Add(10);
            numbers.Add(6);

            MyList<string> strings = new(10);
            strings.Add("Felipe");
            strings.Add("Tapias");

            MyList<Person> person = new(10);
            person.Add(new Person() { Name = "Felipe", Country = "Colombia" });
            person.Add(new Person() { Name = "Andrés", Country = "Canadá" });

            Console.WriteLine(numbers.GetString());
            Console.WriteLine(strings.GetString());
            Console.WriteLine(person.GetString());

            Console.WriteLine(numbers.GetElement(1));
            Console.WriteLine(strings.GetElement(0));
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Name}, País: {Country}";
        }
    }

    class MyList<T>
    {
        private readonly T[] _elements;
        private int _index = 0;

        public MyList(int n)
        {
            _elements = new T[n];
        }

        public void Add(T element)
        {
            if (_index < _elements.Length)
            {
                _elements[_index] = element;
                _index++;
            }
        }

        public T GetElement(int index)
        {
            if (index < _index && index >= 0)
                return _elements[index];

            return default;
        }

        public string GetString()
        {
            int i = 0;
            string result = "";
            while (i < _index)
            {
                result += _elements[i].ToString() + "|";
                i++;

            }

            return result;

        }
    }
}