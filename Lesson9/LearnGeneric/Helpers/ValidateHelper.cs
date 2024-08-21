using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnGeneric.Helpers
{
    public static class ValidateHelper
    {
        public static decimal ValidateDecimal(string field, Func<decimal, bool> condition)
        {
            Console.WriteLine($"Input the {field}");
            var check = decimal.TryParse(Console.ReadLine(), out decimal value) && condition(value);
            while (!check)
            {
                Console.WriteLine($"The {field} is not in correct format, re input the {field}");
                check = decimal.TryParse(Console.ReadLine(), out value) && condition(value);
            }
            return value;
        }

        public static int ValidateInt(string field, Func<int, bool> condition)
        {
            Console.WriteLine($"Input the {field}");
            var check = int.TryParse(Console.ReadLine(), out int value) && condition(value);
            while (!check)
            {
                Console.WriteLine($"The {field} is not in correct format, re input the {field}");
                check = int.TryParse(Console.ReadLine(), out value) && condition(value);
            }
            return value;
        }
    }
}
