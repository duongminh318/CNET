using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP2.Ex1
{
    public class Teacher : Person
    {
        public int TeacherID { get; set; }              // Mã số giáo viên
        public List<Course> TeachingCourses { get; set; } // Danh sách các khóa học đang dạy

        public Teacher(int teacherID, string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {
            TeacherID = teacherID;
            TeachingCourses = new List<Course>();
        }

        // Phương thức để thêm khóa học vào danh sách dạy
        public void AddCourse(Course course)
        {
            TeachingCourses.Add(course);
        }

        // Phương thức hiển thị thông tin của giáo viên
        public void DisplayTeacherInfo()
        {
            DisplayInfo();  // Gọi phương thức DisplayInfo() từ lớp Person
            Console.WriteLine($"Teacher ID: {TeacherID}");
            Console.WriteLine("Teaching Courses: " + string.Join(", ", TeachingCourses));
        }
    }

}
