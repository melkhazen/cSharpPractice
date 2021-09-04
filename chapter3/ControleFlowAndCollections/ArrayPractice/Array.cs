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
    }
}
