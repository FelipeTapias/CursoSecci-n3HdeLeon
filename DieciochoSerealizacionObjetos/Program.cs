using System;
using System.Text.Json;

namespace Serealizacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Beer myBeer = new()
            {
                Name = "Pilsen",
                Brand = "Bavaria"
            };

            // string json = "{\"Name\": \"Pilsen\", \"Brand\": \"Bavaria\"}";

            string json = JsonSerializer.Serialize(myBeer);
            Beer beer = JsonSerializer.Deserialize<Beer>(json);

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

            //string json2 = "[" +
            //    "{\"Name\": \"Pilsen\", \"Brand\": \"Bavaria\"}," +
            //    "{\"Name\": \"Aguila\", \"Brand\": \"Postobon\"}" +
            //    "]";

            string json2 = JsonSerializer.Serialize(beers);
            Beer[] beers2 = JsonSerializer.Deserialize<Beer[]>(json2);
        }
    }

    class Beer
    {
        public string Name { get; set; }
        public string Brand { get; set; }
    }
}