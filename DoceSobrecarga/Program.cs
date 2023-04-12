using System;

namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                1,2,3,4,5,6,7,8,9
            };

            Math math = new();
            Console.WriteLine(math.Sum(5,8));
            Console.WriteLine(math.Sum("12", "89"));
            Console.WriteLine(math.Sum(numbers)); 
        }

        public class Math
        {
            public int Sum(int a, int b)
            {
                return a + b;
            }

            public int Sum(string a, string b)
            {
                return int.Parse(a) + int.Parse(b);
            }

            public int Sum(int[] numbers)
            {
                int result = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    result += numbers[i];
                }

                int j = 0;
                while (j < numbers.Length)
                {
                    result += numbers[j];
                    j++;
                }

                return result;
            }
        }
    }
}