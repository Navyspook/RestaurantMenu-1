using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    class Menu
    {
        //create list of items in MenuItems
        //displays prices and category 
        public List<string> MenuItems { get; set; }

        public DateTime TimeDate { get; set; }

        public static MenuItem guacamole = new MenuItem("Chips and Guacamole", 10.00, "Homemade Guacamole with corn tortillas", "Appetizer", "New!");
        public static MenuItem breadsticks = new MenuItem("Bread Sticks", 3.00, "Bread sticks with butter and garlic.", "Appetizer");
        public static MenuItem chips = new MenuItem("Chips and Dip ", 4.99, "Chips with mild salsa.", "Appetizer");
        public static MenuItem wings = new MenuItem("Buffalo Wings", 5.99, "Buffalo Wings with celery and ranch.", "Main Course");
        public static MenuItem steak = new MenuItem("Steak", 15.99, "14oz Ribeye with roasted garlic mashed potatos.", "Main Course");
        public static MenuItem cheeseCake = new MenuItem("Cheese Cake", 5.99, "New York style cheesecake.", "Dessert");
        public static MenuItem applePie = new MenuItem("Apple Pie", 4.99, "Mama's original apple pie ala mode.", "Dessert");
        public static MenuItem fruit = new MenuItem("Fresh Fruit", 4.99, "Assortment of fresh fruits.", "Dessert");


        public static List<MenuItem> items = new List<MenuItem>
        {
            {guacamole}, 
            {breadsticks},
            {chips},
            {wings},
            {steak},
            {cheeseCake},
            {applePie},
            {fruit},
        };

        public void PrintMenu()
        {
            foreach (MenuItem food in items)
            {
                this.TimeDate = DateTime.Now;
                Console.WriteLine(food.ItemEntry());
                Console.WriteLine(TimeDate);
            }
               
         }








    }
}
