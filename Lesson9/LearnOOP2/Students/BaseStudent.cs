using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP2.Students
{
    public class BaseStudent
    {
        // Thuộc tính tự động với getter và setter
        public int Id { get; set; }
        public string Name { get; set; }
        public double Math { get; set; }
        public double Lit { get; set; }

        // Constructor của lớp BaseStudent
        public BaseStudent(int id, string name, double math, double lit)
        {
            Id = id;
            Name = name;
            Math = math;
            Lit = lit;
        }
    }
}
