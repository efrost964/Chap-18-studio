using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap_19_studio
{
    class Menu
    {
        public static List<MenuItem> MenuList = new List<MenuItem>();
        public static DateTime updatedOn = DateTime.Today;

        public static void PrintItems()
        {
            foreach (MenuItem item in MenuList)
            {
                Console.WriteLine($"{item.NameOfItem}......${item.Price}\n {item.Description}.... Item added on {item.CreationDate.Month}/{item.CreationDate.Day}/{item.CreationDate.Year}\n");
            }
            Console.WriteLine($"Menu updated on {updatedOn.Month}/{updatedOn.Day}/{updatedOn.Year}");
        }

        public static void AddItem()
        {
            Console.WriteLine("What is the type of item you wish to add?");
            string category = "appetizer";
            Console.WriteLine("What is the name of the item you wish to add?");
            string name = Console.ReadLine();
            Console.WriteLine("What is the price of the item?");
            double price = Double.Parse(Console.ReadLine());
            Console.WriteLine("What is a brief description of the item?");
            string desc = Console.ReadLine();
            MenuItem item = new MenuItem(name, desc, category, price);
            MenuList.Add(item);
            updatedOn = DateTime.Today;
        }

        public static void RemoveItem()
        {
            Console.WriteLine("What is the name of the item you would like removed?");
            string name = Console.ReadLine();

            for (int i = MenuList.Count; i >=0; i--)
            {
                if (name.Equals(MenuList[i].NameOfItem))
                {
                    MenuList.RemoveAt(i);
                }
            }
        }
        
        public static void PrintItem()
        {
            Console.WriteLine("What is the name of the item you would like removed?");
            string name = Console.ReadLine().ToLower();

            for (int i = MenuList.Count; i >= 0; i--)
            {
                if (name.Contains(MenuList[i].NameOfItem.ToLower()))
                {
                    Console.WriteLine($"{MenuList[i].NameOfItem}......${MenuList[i].Price}\n {MenuList[i].Description}.... Item added on {MenuList[i].CreationDate.Month}/{MenuList[i].CreationDate.Day}/{MenuList[i].CreationDate.Year}\n");
                }
                else
                {
                    Console.WriteLine("There is no item on the menu by that name.");
                }
            }
        }
    }

}
