using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice
{
    class AliceString
    {
        public static String AliceStringReturn()
        {
            List<String> array = new List<String>();
            String paragraphe = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("make a choce: \n 1) search");
            String UserInput = Console.ReadLine();

            if (int.Parse(UserInput) == 1)
            {
                array = paragraphe.ToLower().Split(" ").ToList();
                Console.WriteLine("enter a search term: ");
                String input = Console.ReadLine();
                if (array.Contains(input.ToLower()))
                {
                    Console.WriteLine("The index of " + input + " is: " + paragraphe.IndexOf(input));
                    String newParagraphe = paragraphe.Replace(input, "****");
                    Console.WriteLine(newParagraphe);
                    return "True";
                }
                else
                {
                    return "False";
                }

            }
            String output = "hi";


            return output;
            
        } 
    }
}
