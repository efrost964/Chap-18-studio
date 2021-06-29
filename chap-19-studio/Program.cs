using System;

namespace chap_19_studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu apps = new Menu();
            Menu mainCourses = new Menu();
            Menu desserts = new Menu();
            string response;
            Console.WriteLine("We're adding Appitizers.");
            do
            {
                apps.AddItem("appitizer");
                Console.WriteLine("Do you want to add another?");
                response = Console.ReadLine().ToLower();
                Console.Clear();
            } while (response.Contains("yes"));
            Console.WriteLine("We're adding Main courses.");
            do
            { 
                mainCourses.AddItem("main");
                Console.WriteLine("Do you want to add another?");
                response = Console.ReadLine().ToLower();
                Console.Clear();
            } while (response.Contains("yes"));
            Console.WriteLine("We're adding Desserts.");
            do
            {
                desserts.AddItem("dessert");
                Console.WriteLine("Do you want to add another?");
                response = Console.ReadLine().ToLower();
                Console.Clear();
            } while (response.Contains("yes"));
            Console.WriteLine("APPS");
            apps.PrintItems();
            Console.WriteLine("MAIN");
            mainCourses.PrintItems();
            Console.WriteLine("DESSERTS");
            desserts.PrintItems();
            mainCourses.RemoveItem();
            Console.Clear();
            mainCourses.PrintItem();

        }
    }
}
