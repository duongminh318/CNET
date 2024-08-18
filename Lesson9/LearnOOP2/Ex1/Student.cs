using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP2.Ex1
{
    public class Student : Person
    {
        public int StudentID { get; set; }             // Mã số sinh viên
        public List<Course> Courses { get; set; }      // Danh sách các khóa học đã đăng ký

        public Student(int studentID, string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {
            StudentID = studentID;
            Courses = new List<Course>();
        }

        // Phương thức để thêm khóa học vào danh sách
        public void EnrollCourse(Course course)
        {
            Courses.Add(course);        // thêm course vào list khoá học của sinh viên này
        }

        // Phương thức hiển thị thông tin của sinh viên
        public void DisplayStudentInfo()
        {
            DisplayInfo();  // Gọi phương thức DisplayInfo() từ lớp Person
            Console.WriteLine($"Student ID: {StudentID}");
            Console.WriteLine("Enrolled Courses: " + string.Join(", ", Courses));
        }
    }

}
