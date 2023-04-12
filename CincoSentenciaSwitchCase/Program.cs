using System;

namespace SentenciaSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 7;

            switch (op)
            {
                case 1:
                    Console.WriteLine("Seleccionaste el 1");
                    break;
                case 2:
                    Console.WriteLine("Selecconaste el 2");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Seleccionaste el 3 o el 4");
                    break;
                case < 0:
                case > 100:
                    Console.WriteLine("Fuera de rango");
                    break;
                case > 4 and < 10:
                    Console.WriteLine("Seleccionaste una opción del 4 hasta el 10");
                    break;
                default:
                    Console.WriteLine("Inválido");
                    break;
            }
        }
    }
}