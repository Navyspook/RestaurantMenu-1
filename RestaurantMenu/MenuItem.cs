using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    class MenuItem
    {
        public string ItemName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public string New { get; set; }
        
        public DateTime TimeDate { get; set; }

        public MenuItem(string itemname, double price, string description, string category)
        {
            this.ItemName = itemname;
            this.Price = price;
            this.Description = description;
            this.Category = category;
            this.TimeDate = DateTime.now;

<<<<<<< HEAD
        public static void SayIfNew (DateTime RightNow)
        {
            DateTime date1 = DateTime.Now;
            DateTime d2 = new DateTime(date1-1);

            flag = DateTime.Equals(d1, d2);

            if (flag == true)
                Console.WriteLine("Given dates are equal");
            else
                Console.WriteLine("Given dates are not equal");
        }
=======
        }
        public MenuItem(string itemname, double price, string description, string category, string newOrNot)
        {
            this.ItemName = itemname;
            this.Price = price;
            this.Description = description;
            this.Category = category;
            this.New = newOrNot;
            this.TimeDate = DateTime.Now;
            
>>>>>>> 1c6f5a2ae32582b375d3f52f16c3e698a959c57c

        }
        public string ItemEntry()
        {
<<<<<<< HEAD
            this.itemName = ItemName;
            this.price = Price;
            this.description = Description;
            this.category = Category;
            Console.WriteLine($"{this.itemName}: ${this.price}\n{this.category}\n{this.description}\nItem Updated at: {rightNow}");
            
        }

}
=======
            Console.WriteLine();
            return $"___________________________________________\n{this.ItemName}: ${this.Price}\n{this.Category}\n{this.Description}\n{this.New}\nAdded on:{TimeDate}\n___________________________________________";
  

        }



        // list out all menu items
        //code last updated

        // this class return list/dictionary? 

    }
>>>>>>> 1c6f5a2ae32582b375d3f52f16c3e698a959c57c
}
