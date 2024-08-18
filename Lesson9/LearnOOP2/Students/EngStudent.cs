using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP2.Students
{
    public class EngStudent : BaseStudent
    {
        public double Eng { get; set; }
        public EngStudent(int id, string name, double math, double lit, double eng) : base(id, name, math, lit)
        {
            Eng = eng;
        }
    }
}
