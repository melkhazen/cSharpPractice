using System;
using System.Collections.Generic;

namespace ArrayPractice
{
    class Program
    {

        static void Main(string[] args)
        {

            List<int> exampleArray = new List<int>();

            exampleArray.Add(8);
            exampleArray.Add(15);
            exampleArray.Add(2);
            exampleArray.Add(84);
            exampleArray.Add(1);
            exampleArray.Add(9);

            Console.WriteLine("Choose a practice: \n 1) for array. \n 2) for array fun. \n 3) for list even sum. \n 4) for five letters words. \n 5) for dictionnery.");
            String input = Console.ReadLine();

            if (input == "1")
            {
                Array.arrayFun();
            }
            else if (input == "2")
            {
                Array.stringToArray();
            }
            else if (input == "3")
            {
                Array.evenSum(exampleArray);
            }
            else if (input == "4")
            {
                Array.fiveLettersWords();
            }else if (input == "5")
            {
                Array.dictionarryPart();
            }


        }
    }
}
