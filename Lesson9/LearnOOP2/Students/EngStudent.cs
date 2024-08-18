using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP2.Students
{
    public class EngStudent : BaseStudent, IGetTotalScore
    {
        public double Eng { get; set; }
        public EngStudent(int id, string name, double math, double lit, double eng) : base(id, name, math, lit)
        {
            Eng = eng;
        }

        public override string GetInfo()
        {
            return base.GetInfo()+$"- English: {Eng}";
        }

        protected override double GetAvg()
        {
            return (Math + Lit + Eng) / 3;
        }

        // imclement interface
        public double GetTotalScore()
        {
            return (Math + Lit + Eng*2) / 4;
        }
    }


}
