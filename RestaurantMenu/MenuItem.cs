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
        //DateTime rightNow { get; set; }

        public MenuItem(string itemname, double price, string description, string category)
        {
            this.ItemName = itemname;
            this.Price = price;
            this.Description = description;
            this.Category = category;

        }
        public MenuItem(string itemname, double price, string description, string category, string newOrNot)
        {
            this.ItemName = itemname;
            this.Price = price;
            this.Description = description;
            this.Category = category;
            this.New = newOrNot;
        }
        public void ItemEntry()
        {
            Console.WriteLine($"{this.ItemName}: ${this.Price}\n{this.Category}\n{this.Description}\n{this.New}");

        }



        // list out all menu items
        //code last updated

        // this class return list/dictionary? 

    }
}
