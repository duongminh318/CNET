using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP
{
    public  class Student2
    {
        private const string ageError = "age must be from 12 tp 15";
        public int Id { get; set; }
        public string Address { get; set; }
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

        public string Info
        {
            get
            {
                return $"Id: {Id} - Name: {Name} - Age: {Age} - Address: {Address}";
            }
        }

        public string Info2 => $"Id: {Id} - Name: {Name} - Age: {Age} - Address: {Address}";
        public void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Age: {Age}, Address: {Address}");
        }
        public Student2(int id, string name, int age, string address)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Address = address;
        }

        // Constructor với 3 tham số
        public Student2(int id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }
    }
}
