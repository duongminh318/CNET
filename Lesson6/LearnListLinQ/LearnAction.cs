using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnListLinQ
{
    public class LearnAction
    {
        public void HandleStudentScore(Action<double> handleScore)
        {
            Console.WriteLine("input the student score");
            double score = double.Parse(Console.ReadLine());
            handleScore(score);

        }
    }
}
