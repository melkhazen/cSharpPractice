using System;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose a practice: \n 1) for array.");
            String input = Console.ReadLine();

            if (input == "1")
            {
                Array.arrayFun();
            }


        }
    }
}
