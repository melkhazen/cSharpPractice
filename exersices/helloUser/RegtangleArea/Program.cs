using System;

namespace RegtangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a width: ");
            String width = Console.ReadLine();

            Console.WriteLine("Enter a lingth: ");
            String length = Console.ReadLine();

            int area = AreaCalculator.GetArea(int.Parse(width), int.Parse(length));

            Console.WriteLine("The are is: " + area);
        }
    }
}
