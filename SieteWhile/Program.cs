using System;


namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 10)
            {
                Console.WriteLine("Iteración de i: " + i);
                i++;
            }

            int j = 0;
            while (j < 100)
            {
                if (j > 10)
                    break;

                Console.WriteLine("Iteración de j: " + j);
                j++;
            }

            int k = 100;
            while (k > 0)
            {
                Console.WriteLine("Iteración de k: " + k);
                k--;
            }

            string[] friends = new string[7]
            {
                "Alicia",
                "Paco",
                "Ana",
                "Andres",
                "Luis",
                "Karla",
                "Jorge"
            };

            int index = 0;

            while (index < friends.Count())
            {
                Console.WriteLine(friends[index]);
                index++;
            }

            bool run = false;

            do
            {
                Show();
            } while (run);

            static void Show()
            {
                Console.WriteLine("Entre una vez y ya");
            }
        }
    }
}