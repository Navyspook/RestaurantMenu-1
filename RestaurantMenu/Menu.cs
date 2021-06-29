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

        public static MenuItem item1 = new MenuItem("Chips and Guacamole", 10.00, "Homemade Guacamole with corn tortillas", "Appetizer", "New!");
        public static MenuItem item2 = new MenuItem("Bread Sticks", 3.00, "Bread sticks with butter and garlic.", "Appetizer");
        public static MenuItem item3 = new MenuItem("Chips and Dip ", 4.99, "Chips with mild salsa.", "Appetizer");
        public static MenuItem item4 = new MenuItem("Buffalo Wings", 5.99, "Buffalo Wings with celery and ranch.", "Main Course");
        public static MenuItem item5 = new MenuItem("Steak", 15.99, "14oz Ribeye with roasted garlic mashed potatos.", "Main Course");
        public static MenuItem item6 = new MenuItem("Cheese Cake", 5.99, "New York style cheesecake.", "Dessert");
        public static MenuItem item7 = new MenuItem("Apple Pie", 4.99, "Mama's original apple pie ala mode.", "Dessert");
        public static MenuItem item8 = new MenuItem("Fresh Fruit", 4.99, "Assortment of fresh fruits.", "Dessert");
        public static MenuItem item9 = new MenuItem("Cheese Balls", 8.99, "Assortment of fresh fruits.", "Appetizer", "New");
        public static MenuItem item10 = new MenuItem("1", 2, "3", "New");


        public List<MenuItem> listOfMenuItems = new List<MenuItem>
                {
                    {item1},
                    {item2},
                    {item3},
                    {item4},
                    {item5},
                    {item6},
                    {item7},
                    {item8},
                    {item9},
                    
                };

    //    public List<MenuItem> listOfMenuItems = new List<MenuItem> { };


        public void PrintItem(MenuItem specificItem)
        {
            int index = listOfMenuItems.IndexOf(specificItem);
            Console.WriteLine(listOfMenuItems[index].ItemEntry());
        }
        public void AddMenuItems(MenuItem item)
        {
            this.listOfMenuItems.Add(item);
        }

        public void RemoveMenuItems(MenuItem item)
        {
            this.listOfMenuItems.Remove(item);
        }

        public void PrintMenu()
        {
            foreach (MenuItem food in listOfMenuItems)
            {
                this.TimeDate = DateTime.Now;
                Console.WriteLine(food.ItemEntry());
            }
                Console.WriteLine($"Menu Last Updated On: {TimeDate}");

        }
      









    }
}
