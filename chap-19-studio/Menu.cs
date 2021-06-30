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

        public void PrintItems()
        {
            foreach (MenuItem item in MenuList)
            {
                Console.WriteLine($"{item.NameOfItem}......${item.Price}\n {item.Description}.... Item added on {item.CreationDate.Month}/{item.CreationDate.Day}/{item.CreationDate.Year}\n");
            }
            Console.WriteLine($"Menu updated on {updatedOn.Month}/{updatedOn.Day}/{updatedOn.Year}");
        }

        public void Password()
        {

            Console.WriteLine("Are you an employee?");
            string userInput = Console.ReadLine().ToLower();
            if (userInput.Contains("yes"))
            {
                string password = "admin";
                string userPassword;
                do
                {
                    Console.WriteLine("Please input the password");
                    userPassword = Console.ReadLine().ToLower();

                } while (!userPassword.Contains(password));
                
            }
            else if(userInput.Contains("no"))
            {
                Console.WriteLine("Okay thank you have a nice day!!");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please answer yes or no.");
            }

        }
        public void AddItem(string name, string desc, double price, string cat)
        {
            MenuItem menuItem = new MenuItem(name, desc, cat, price);
            MenuList.Add(menuItem);
        }

        public void AddItemInput()
        {
            Console.WriteLine("What is the category of the item?");
            string category = Console.ReadLine();
            Console.WriteLine("What is the name of the item you wish to add?");
            string name = Console.ReadLine();
            Console.WriteLine("What is the price of the item?");
            double price = Double.Parse(Console.ReadLine());
            Console.WriteLine("What is a brief description of the item?");
            string desc = Console.ReadLine();
            MenuItem item = new MenuItem(name, desc, category, price);
            string itemCheck = "no";
            foreach (MenuItem item2 in MenuList)
            {
                if(Menu.Equals(item, item2))
                {
                    Console.WriteLine("This item already exists in the menu.");
                    itemCheck = "yes";
                    break;
                }
            }
            if(itemCheck.Contains("no"))
            {
                MenuList.Add(item);
                updatedOn = DateTime.Today;
            }
            
        }

        public void RemoveItem()
        {
            Console.WriteLine("What is the name of the item you would like removed?");
            string name = Console.ReadLine();

            for (int i = MenuList.Count - 1; i >= 0; i--)
            {
                if (name.Equals(MenuList[i].NameOfItem.ToLower()))
                {
                    MenuList.RemoveAt(i);
                }
            }
        }
        
        public void PrintItem()
        {
            Console.WriteLine("What is the name of the item you would like to print?");
            string name = Console.ReadLine().ToLower();
            string notInList = "yes";

            for (int i = MenuList.Count - 1; i >= 0; i--)
            {
                if (name.Contains(MenuList[i].NameOfItem.ToLower()))
                {
                    Console.WriteLine($"{MenuList[i].NameOfItem}......${MenuList[i].Price}\n {MenuList[i].Description}.... Item added on {MenuList[i].CreationDate.Month}/{MenuList[i].CreationDate.Day}/{MenuList[i].CreationDate.Year}\n");
                    notInList = "no";
                    break;
                }
            }
            if(notInList.Contains("yes"))
            {
                Console.WriteLine("Sorry that item isn't in our list");
            }
        }
        
    }

}
