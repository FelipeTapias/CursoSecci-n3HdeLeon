using System;

namespace SentenciaIF
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool areYouHungry = true;
            bool youHaveMoney = true;

            if (areYouHungry && youHaveMoney && isOpenRestaurant("Restaurant 24 horas", 7))
            {
                Console.WriteLine("Comes");
            } else
            {
                Console.WriteLine("No comes");
            }

            static bool isOpenRestaurant(string name, int hour = 0)
            {
                if (name == "Presto" && hour > 8 && hour < 23)
                {
                    return true;
                } 
                else if (name == "Restaurant 24 horas")
                {
                    return true;
                } else
                {
                    return false;
                }
            }
        }
    }
}