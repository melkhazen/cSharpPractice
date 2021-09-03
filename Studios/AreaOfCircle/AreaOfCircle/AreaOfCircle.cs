using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfCircle
{
    class AreaOfCircle
    {
        public static String Area()
        {
            Console.WriteLine("enter a radious: ");
            String input = Console.ReadLine();
            while (int.Parse(input) <= 0 )
            {
                Console.WriteLine("you need a positive number, enter a radious: ");
                input = Console.ReadLine();
            }

            Double pi = Math.PI;
            Double areaOfCircle =  pi * int.Parse(input) * int.Parse(input);
            String output = "The area of the circle deppanding on the radious is: " + areaOfCircle;
            Console.WriteLine(output);

            return output;

        }
    }
}
