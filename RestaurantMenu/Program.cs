
using System;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Menu menu = new Menu();
            /*            menu.PrintMenu();
                        menu.RemoveMenuItems(Menu.item1);
                        menu.PrintMenu();*/

            menu.AddMenuItems(Menu.item10);
            // menu.PrintItem(Menu.item2);
            menu.PrintMenu();

        }
    }
}
