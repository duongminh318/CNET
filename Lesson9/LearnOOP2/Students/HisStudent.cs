using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP2.Students
{
    public class HisStudent : BaseStudent
    {
        public double His { get; set; }
        public HisStudent(int id, string name, double math, double lit, double his) : base(id, name, math, lit)
        {
            His = his;
        }
    }
}
