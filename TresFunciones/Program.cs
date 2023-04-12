using System;

namespace Funciones
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            int c = a + b;
            int d = a + b;

            Suma(5,8);
            int m = Multi(5,5);
            Console.WriteLine(m);
        }

        static int Multi(int n1, int n2)
        {
            return n1 * n2;
        }

        static void Suma(int n1, int n2)
        {
            int n3 = n1 + n2;
            Console.WriteLine(n3);
        }

        static void show()
        {
            Console.WriteLine("Hola, soy un texto que se imprime desde una función");
        }

    }
}