
using System;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello James!");
            MenuItem cheeseballs = new MenuItem();
            cheeseballs.ItemEntry("Cheese balls", 5.50, "yummy yummy cheese balls", "lunch");

        }
    }
}
