using IteratorPattern.Menus;
using System;
using System.Collections.Generic;

namespace IteratorPattern
{
    // The waitress
    class StartUp
    {
        static void Main(string[] args)
        {
            PancakeHouseMenu pancakeMenu = new PancakeHouseMenu();
            DinnerMenu dinnerMenu = new DinnerMenu();

            #region Bad implementation of PrintMenu() method

            //List<MenuItem> breakfastItems = pancakeMenu.MenuItems; // waitress is dependent on type List<MenuItem>
            //MenuItem[] dinnerItems = dinnerMenu.MenuItems; // waitress is also dependent on type MenuItem[]

            //foreach (var menuItem in breakfastItems)
            //{
            //    Console.WriteLine(menuItem.Name);
            //    Console.WriteLine(menuItem.Price);
            //    Console.WriteLine(menuItem.Description);
            //}

            //foreach (var menuItem in dinnerItems)
            //{
            //    Console.WriteLine(menuItem.Name);
            //    Console.WriteLine(menuItem.Price);
            //    Console.WriteLine(menuItem.Description);
            //}

            #endregion

            IIterator<MenuItem> pancakeIterator = pancakeMenu.CreateIterator();        
            IIterator<MenuItem> dinnerIterator = dinnerMenu.CreateIterator();

            Console.WriteLine("---Menu---");
            Console.WriteLine();
            Console.WriteLine("--Breakfast--");
            PrintMenu(pancakeIterator);
            Console.WriteLine();
            Console.WriteLine("--Lunch--");
            PrintMenu(dinnerIterator);
        }

        private static void PrintMenu(IIterator<MenuItem> iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = iterator.Next();

                Console.Write(menuItem.Name + ", ");
                Console.Write(menuItem.Price+ " -- ");
                Console.WriteLine(menuItem.Description);
            }
        }
    }
}
