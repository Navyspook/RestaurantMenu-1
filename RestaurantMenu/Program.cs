
using System;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello James!");
            MenuItem guacamole = new MenuItem("Chips and Guacamole", 10.00, "Homemade Guacamole with corn tortillas", "Appetizer", "New!");
            guacamole.ItemEntry();


        }
    }
}
