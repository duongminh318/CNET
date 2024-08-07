using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnListLinQ
{
    public class LearnAction
    {
        // tuỳ chỉnh danh sách sinh viên bằng một action
        public void HandleStudentScore(Action<double> handleScore) //tham số là 1 hàm
        {
            Console.WriteLine("input the student score");
            double score = double.Parse(Console.ReadLine());
            handleScore(score);

        }
    }
}
