using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP2.Ex1
{
    public class Person
    {
        public string FirstName { get; set; } // Họ của người
        public string LastName { get; set; }  // Tên của người
        public int Age { get; set; }          // Tuổi của người

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        // Phương thức hiển thị thông tin của người
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}, Age: {Age}");
        }
    }

}
