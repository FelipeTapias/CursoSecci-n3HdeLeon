using System;

namespace FormatoJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Beer MyBeer = new()
            {
                Name = "Pilsen",
                Brand = "Bavaria"
            };

            string json = "{\"Name\": \"Pilsen\", \"Brand\": \"Bavaria\"}";

            Beer[] beers = new Beer[]
            {
                new Beer() 
                { 
                    Name = "Pilsen",
                    Brand = "Bavaria"
                },
                new Beer()
                {
                    Name = "Aguila",
                    Brand = "Postobon"
                }
            };

            string json2 = "["+
                "{\"Name\": \"Pilsen\", \"Brand\": \"Bavaria\"}," +
                "{\"Name\": \"Aguila\", \"Brand\": \"Postobon\"}" +
                "]";
        }
    }

    class Beer
    {
        public string Name { get; set; }
        public string  Brand { get; set; }
    }
}