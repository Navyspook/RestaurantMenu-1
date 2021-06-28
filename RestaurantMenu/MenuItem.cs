using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    class MenuItem
    {
        public string itemName { get; set; }
        public double price { get; set; }
        public string description { get; set; }
        public string category { get; set; }


        public DateTime rightNow
        {
            get
            {
                DateTime date1 = DateTime.Now;
                return date1;
            }
        }

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

        public void ItemEntry(string ItemName, double Price, string Description, string Category)
        {
            this.itemName = ItemName;
            this.price = Price;
            this.description = Description;
            this.category = Category;
            Console.WriteLine($"{this.itemName}: ${this.price}\n{this.category}\n{this.description}\nItem Updated at: {rightNow}");
            
        }

}
}
