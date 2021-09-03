using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloUser
{
    public class HelloUser
    {
        public static String getHelloUser()
    {

          Console.WriteLine("What is your name:");
          String name = Console.ReadLine();
        return "Hello, " + name;
    }
  }
}