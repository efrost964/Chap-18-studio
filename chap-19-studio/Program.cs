using System;

namespace chap_19_studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.AddItem("Fish and chips", "Fried haddock with french fries", 13.99, "main course");
            menu.AddItem("Wings", "Chicken wings with BBQ, Buffalo, or Mild sauce", 8.99, "appetizer");
            menu.AddItem("Fried ice cream", "Fried vanilla ice cream", 4.99, "desserts");
            while (1 == 1)
            {
                menu.PrintItems();
                Console.ReadLine();
                Console.Clear();
                menu.Password();
                Console.Clear();
                string response = "";
                while (response.Contains(""))
                {
                    Console.WriteLine("Would you like to add, remove or print a single item? If no type exit.");
                    response = Console.ReadLine().ToLower();
                    if (response.Contains("add"))
                    {
                        do
                        {
                            menu.AddItemInput();
                            Console.WriteLine("Do you want to add another?");
                            response = Console.ReadLine().ToLower();
                            Console.Clear();
                        } while (response.Contains("yes"));

                    }
                    else if (response.Contains("remove"))
                    {
                        do
                        {
                            menu.RemoveItem();
                            Console.WriteLine("Do you want to remove another?");
                            response = Console.ReadLine().ToLower();
                            Console.Clear();
                        } while (response.Contains("yes"));
                    }
                    else if (response.Contains("print"))
                    {
                        do
                        {
                            menu.PrintItem();
                            Console.WriteLine("Do you want to print another item?");
                            response = Console.ReadLine().ToLower();
                            Console.Clear();
                        } while (response.Contains("yes"));
                    }
                    else if (response.Contains("exit"))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please input add, remove, or print.");
                    }
                    Console.Clear();
                }
            }
            //string response;
            //Console.WriteLine("We're adding Appitizers.");
            //do
            //{
            //    apps.AddItem("appitizer");
            //    Console.WriteLine("Do you want to add another?");
            //    response = Console.ReadLine().ToLower();
            //    Console.Clear();
            //} while (response.Contains("yes"));
            //Console.WriteLine("We're adding Main courses.");
            //do
            //{ 
            //    mainCourses.AddItem("main");
            //    Console.WriteLine("Do you want to add another?");
            //    response = Console.ReadLine().ToLower();
            //    Console.Clear();
            //} while (response.Contains("yes"));
            //Console.WriteLine("We're adding Desserts.");
            //do
            //{
            //    desserts.AddItem("dessert");
            //    Console.WriteLine("Do you want to add another?");
            //    response = Console.ReadLine().ToLower();
            //    Console.Clear();
            //} while (response.Contains("yes"));
            //Console.WriteLine("APPS");
            //apps.PrintItems();
            //Console.WriteLine("MAIN");
            //mainCourses.PrintItems();
            //Console.WriteLine("DESSERTS");
            //desserts.PrintItems();
            //mainCourses.RemoveItem();
            //Console.Clear();
            //mainCourses.PrintItem();

        }
    }
}
