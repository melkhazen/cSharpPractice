using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCounter
{
    class LettersCounter
    {

        public static void stringMethod()
        {

            String stringNeeded = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus";
            List<char> singleChars = new List<char>();
            int counter = 0;
            for (int i = 0; i < stringNeeded.Length; i++)
            {
                if (!singleChars.Contains(stringNeeded[i]))
                {
                    singleChars.Add(stringNeeded[i]);
                }
            }

            for (int i = 0; i < singleChars.Count; i++)
            {
                for (int j = 0; j < stringNeeded.Length; j++)
                {
                    if(Equals(stringNeeded[j], singleChars[i]))
                    {
                        counter += 1;
                    }
                }
                Console.WriteLine(singleChars[i] + ": " + counter);
                counter = 0;
            }
        }
    }
}

