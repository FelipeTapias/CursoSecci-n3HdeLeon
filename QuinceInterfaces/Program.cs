using System;
using System.Xml.Linq;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Shark[] sharks = new Shark[]
            {
                new Shark("Tiburón Blanco", 56),
                new Shark("Tiburón Tigre", 65),
            };

            IFish[] fish = new IFish[]
            {
                new Siren(72),
                new Siren(53),
                new Shark("Tiburon Martillo", 56)
            };

            ShowFish(sharks);
            ShowAnimals(sharks);
            ShowFish(fish);

        }

        public static void ShowAnimals(IAnimal[] animals)
        {
            Console.WriteLine("- Mostramos los animales -");
            int i = 0;
            while (i < animals.Length)
            {
                Console.WriteLine(animals[i].Name);
                i++;
            }
        }
        public static void ShowFish(IFish[] fishs)
        {
            Console.WriteLine("- Mostramos los peces -");
            int i = 0;
            while (i < fishs.Length)
            {
                Console.WriteLine(fishs[i].Swin());
                i++;
            }
        }
    }

    public class Siren: IFish
    {
        public int Speed { get; set; }

        public Siren(int speed)
        {
            Speed = speed;
        }

        public string Swin()
        {
            return $"La Sirena nada a {Speed}km/h";
        }
    }

    public class Shark: IAnimal, IFish
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public Shark(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        public string Swin()
        {
            return $"{Name} top speed is {Speed} km/h";
        }

    }

    public interface IAnimal
    {
        public string Name { get; set; }
    }

    public interface IFish
    {
        public int Speed { get; set; }
        public string Swin();
    }


}