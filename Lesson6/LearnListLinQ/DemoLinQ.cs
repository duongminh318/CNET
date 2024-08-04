using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnListLinQ
{
    public class DemoLinQ
    {
        public List<int> numbers = new List<int>() { 10, 5, 4, 3, 50, 30, 7, 8, 5, 15, 13 };

        public void PrintOddNumbers()
        {
            //var result= numbers.Where(x=>x%2!=0).ToList();
            var result = numbers.Where(x => x % 2 != 0).OrderByDescending(x => x).ToList();
            PrintResult(result);
        }

        public void PrintOne()
        {
            var firstElement = numbers.Where(x => x % 2 != 0).OrderBy(x => x).FirstOrDefault();
            Console.WriteLine(firstElement);
        }

        public void PrintResult(List<int> result)
        {
            if (!result.Any()) // nếu ko có phần tử nào --> false 
            {
                Console.WriteLine("result is emty");
                return;
            }
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
        // over ride in ra list string
        public void PrintResult(List<string> result)
        {
            foreach (string i in result)
            {
                Console.WriteLine(i);
            }
        }
        public void PrintSelect()
        {
            var result = numbers.Select(s => s * 2).ToList();
            PrintResult(result);
        }
        // hàm lọc số lẻ
        private string GetNumber(int number) => number % 2 == 0 ? "so chan" : "sole";
        public void PrintSelect1()
        {
            var result = numbers.Select(s => $"{s} is {GetNumber(s)}").ToList();
            PrintResult(result);
        }

        /* lấy ra n phần tử take(n)
         * bỏ qua n phần tử skip(n)
         */
        public void TakeSkip()
        {
            var result = numbers.Skip(3).Take(3).ToList();
            PrintResult(result);
        }
    
    // kiểm tra có phần tử nào không
    public void AllAny()
    {
        var result = numbers.Any(s => s % 2 != 0); // nếu thấy 1 phần tử nào đó thoả --> true
        Console.WriteLine(result);
    }


}

}
