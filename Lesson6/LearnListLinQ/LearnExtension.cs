using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnListLinQ
{
    public class LearnExtension
    {
        public void Print(string message)
        {
            Console.WriteLine($"C1- the value is {message}");
        }   
    }

    // extension function (hàm mở rộng)
    public static class LearnExtension1
    {
        public static void Print(this string message)
        {
            Console.WriteLine($"C2 -the value is {message}");
        }
    }

  
}
