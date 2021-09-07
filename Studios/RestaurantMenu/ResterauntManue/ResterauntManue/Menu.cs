using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResterauntManue
{
    class Menu
    {

        public static void createANewItem()
        {

            MenuItem newItem = new MenuItem();

            Console.WriteLine("add a new item to the menu: \n Name: ");
            string input = Console.ReadLine();
            newItem.Name = input;

            Console.WriteLine("\n Price: ");
            input = Console.ReadLine();
            newItem.Price = int.Parse(input);

            Console.WriteLine("\n Description: ");
            input = Console.ReadLine();
            newItem.Description = input;

            Console.WriteLine(" \n Category: ");
            input = Console.ReadLine();
            newItem.Category = input;

            Console.WriteLine("The new item is: " + newItem.Name + "\n Price: " + newItem.Price + "$ \n Description: " + newItem.Description + " \n Category: " + newItem.Category + " \n it was updated on: " + newItem.timeString);
        }
    }
}
