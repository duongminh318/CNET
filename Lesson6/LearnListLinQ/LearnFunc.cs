using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnListLinQ
{
    public class LearnFunc
    {
        // nhập điểm của học sinh, điểm từ 0=>10
        public void InputScore()
        {
            var math = ValidateScoreWithCondition("math", MathCondition);
            var history = ValidateScoreWithCondition("history", HistoryCondition); // 1-100
            var english = ValidateScoreWithCondition("english", EnglishCondition); // 1-1000
            Console.WriteLine(math);
            Console.WriteLine(history);
            Console.WriteLine(english);
        }

        //cách 1 viết điều kiện tường minh
        private double ValidateScore(string subject)
        {
            Console.WriteLine($"Input the {subject} score");
            var check = double.TryParse(Console.ReadLine(), out var score) && score >= 0 && score <= 10;
            while (!check)
            {
                Console.WriteLine($"The {subject} score is not correct,reinput");
                check = double.TryParse(Console.ReadLine(), out score) && score >= 0 && score <= 10;
            }
            return score;
        }

        //cách 2: điều kiện, đối số là 1 function, (delegate)

        public double ValidateScoreWithCondition(string subject, Func<double, bool> condition)
        {
            Console.WriteLine($"Input the {subject} score");
            var check = double.TryParse(Console.ReadLine(), out var score) && condition(score);
            while (!check)
            {
                Console.WriteLine($"The {subject} score is not correct,reinput");
                check = double.TryParse(Console.ReadLine(), out score) && condition(score);
            }
            return score;
        }

        private bool MathCondition(double score)
        {
            return score >= 0 && score <= 10;
        }

        private bool HistoryCondition(double score)
        {
            // 1-100
            return score >= 1 && score <= 100;
        }

        private bool EnglishCondition(double score)
        {
            // 1-1000
            return score >= 1 && score <= 1000;
        }

        public List<int> CreateList(List<int> numbers, Func<int, bool> checkCondition)
        {
            var result = new List<int>();
            foreach (int number in numbers)
            {
                if (checkCondition(number)) // hàm checkCondition là 1 dk linq
                                            // --> dc chuyền vào main s=>s gì đó
                {
                    result.Add(number);
                }
            }
            return result;
        }


    }
}
