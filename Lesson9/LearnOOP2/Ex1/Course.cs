using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP2.Ex1
{
    public class Course
    {
        public string CourseName { get; set; }               // Tên khóa học
        public Teacher CourseTeacher { get; set; }           // Giáo viên phụ trách
        public List<Student> EnrolledStudents { get; set; }  // Danh sách sinh viên đã đăng ký
        
        // tạo mới 1 course
        public Course(string courseName, Teacher courseTeacher)
        {
            CourseName = courseName;
            CourseTeacher = courseTeacher;
            EnrolledStudents = new List<Student>();
        }

        // Phương thức thêm sinh viên vào khóa học và cập nhật danh sách khóa học của sinh viên
        public void EnrollStudent(Student student)
        {
            EnrolledStudents.Add(student);  // add sinh viên vào course này
            student.EnrollCourse(this); // Cập nhật danh sách khóa học của sinh viên
        }

        // Phương thức hiển thị thông tin của khóa học
        public void DisplayCourseInfo()
        {
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine("Teacher: ");
            CourseTeacher.DisplayTeacherInfo();  // Hiển thị thông tin giáo viên phụ trách
            Console.WriteLine("Enrolled Students: ");
            foreach (var student in EnrolledStudents)
            {
                student.DisplayStudentInfo();  // Hiển thị thông tin của từng sinh viên đã đăng ký
            }
        }
    }

}
