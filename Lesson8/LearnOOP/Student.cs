using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP
{
    public class Student
    {
        private const string ageError = "age must be from 12 tp 15";
        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }



        private string name;
        public string Name
        {
            get
            {
                return $"Student: {name}";
            }
            set
            {
                name = value;
            }
        }



        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 12 && value <= 15)
                {
                    age = value;
                }
                else
                {
                    throw new Exception(ageError);
                }


            }
        }

        private string address;
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
    }
}
