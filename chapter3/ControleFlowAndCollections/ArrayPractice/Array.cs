using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Array
    {

        public static void arrayFun()
        {
            int[] arr = { 1, 1, 2, 3, 5, 8 };

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("**************");

            foreach (int i in arr)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

        }

        public static void stringToArray()
        {

            String stringGiven = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            String[] arr = stringGiven.Split(" ");

            Console.WriteLine(string.Join(",", arr));


        }

        public static void evenSum(List<int> arrayList)
        {

            int sumevenSumInArray = 0;
            for (int i = 0; i < arrayList.Count; i++)
            {
                if (arrayList[i] % 2 == 0)
                {
                    sumevenSumInArray += arrayList[i];
                }
            }
            Console.WriteLine("The even numbers sum in this array is: " + sumevenSumInArray);
        }

        public static void fiveLettersWords()
        {
            List<String> listOfWords = new List<String>();
            List<String> fiveLettersWords = new List<String>();

            listOfWords.Add("samir");
            listOfWords.Add("samira");
            listOfWords.Add("bilal");
            listOfWords.Add("Hamza");
            listOfWords.Add("Mohamed");

            String numberOfLettersChosenByUser;

            Console.WriteLine("choose a number of letters to pick: ");
            numberOfLettersChosenByUser = Console.ReadLine();

            foreach (String word in listOfWords)
            {
                if (word.Length == int.Parse(numberOfLettersChosenByUser))
                {
                    fiveLettersWords.Add(word);
                }

            }
            if (fiveLettersWords.Count == 0)
            {
                Console.WriteLine("there is no words with this lingth!");
            }

            Console.WriteLine(string.Join(",", fiveLettersWords));


        }

        public static void dictionarryPart()
        {

            Dictionary<int, String> listOfStudents = new Dictionary<int, string>();

            String studentID;
            do
            {
                Console.WriteLine("Enter a student ID: ");
                String input = Console.ReadLine();
                studentID = input;

                if (!Equals(studentID, ""))
                {
                    Console.WriteLine("Enter a studentID Name: ");
                    input = Console.ReadLine();
                    listOfStudents.Add(int.Parse(studentID), input);
                }
            }

            while (!Equals(studentID, ""));

            foreach (KeyValuePair<int, string> kvp in listOfStudents)
                Console.WriteLine("Student ID: {0}, Student Name: {1}", kvp.Key, kvp.Value);
        }
    }
}
