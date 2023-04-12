using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {

            Person felipe = new()
            {
                Name = "Felipe",
                Age = 20
            };

            Person andres = new()
            {
                Name = "Andres",
                Age = 32
            };
            Console.WriteLine(Person.GetCount());

        }

        public static class A
        {
            public static void Some()
            {

            }
        }

        public class Person
        {
            public static int Count = 0;
            public string Name { get; set; }
            public int Age { get; set; }

            public Person()
            {
                Count++;
            }

            public static string GetCount()
            {
                //return "Esta clase se ha utilizado " + Count + " veces";
                return $"Esta clase se ha utilizado {Count} veces";
            }
        
        }
    }
}