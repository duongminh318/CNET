using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP2.Ex1
{
    public class LearningManagementSystem
    {
        private List<Student> students = new List<Student>();
        private List<Teacher> teachers = new List<Teacher>();
        private List<Course> courses = new List<Course>();

        // Hàm thêm sinh viên
        public void AddStudent()
        {
            Console.Write("Enter Student ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Student student = new Student(id, firstName, lastName, age);
            students.Add(student);

            Console.WriteLine("Student added successfully!");
        }

        // Hàm thêm giáo viên
        public void AddTeacher()
        {
            Console.Write("Enter Teacher ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Teacher teacher = new Teacher(id, firstName, lastName, age);
            teachers.Add(teacher);

            Console.WriteLine("Teacher added successfully!");
        }

        // Hàm tạo khóa học
        public void CreateCourse()
        {
            if (teachers.Count == 0)
            {
                Console.WriteLine("No teachers available. Please add a teacher first.");
                return;
            }

            Console.Write("Enter Course Name: ");
            string courseName = Console.ReadLine();

            Console.WriteLine("Available Teachers:");
            for (int i = 0; i < teachers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {teachers[i].FirstName} {teachers[i].LastName}");
            }

            Console.Write("Select a teacher by number: ");
            int teacherIndex = int.Parse(Console.ReadLine()) - 1;

            if (teacherIndex < 0 || teacherIndex >= teachers.Count)
            {
                Console.WriteLine("Invalid teacher selection.");
                return;
            }

            Teacher selectedTeacher = teachers[teacherIndex];
            Course course = new Course(courseName, selectedTeacher);
            courses.Add(course);

            Console.WriteLine("Course created successfully!");
        }

        // Hàm đăng ký sinh viên vào khóa học
        public void EnrollStudentToCourse()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students available. Please add a student first.");
                return;
            }

            if (courses.Count == 0)
            {
                Console.WriteLine("No courses available. Please create a course first.");
                return;
            }

            Console.WriteLine("Available Students:");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {students[i].FirstName} {students[i].LastName}");
            }

            Console.Write("Select a student by number: ");
            int studentIndex = int.Parse(Console.ReadLine()) - 1;

            if (studentIndex < 0 || studentIndex >= students.Count)
            {
                Console.WriteLine("Invalid student selection.");
                return;
            }

            Console.WriteLine("Available Courses:");
            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {courses[i].CourseName}");
            }

            Console.Write("Select a course by number: ");
            int courseIndex = int.Parse(Console.ReadLine()) - 1;

            if (courseIndex < 0 || courseIndex >= courses.Count)
            {
                Console.WriteLine("Invalid course selection.");
                return;
            }

            Course selectedCourse = courses[courseIndex];
            Student selectedStudent = students[studentIndex];
            selectedCourse.EnrollStudent(selectedStudent);

            Console.WriteLine("Student enrolled in course successfully!");
        }

        // Hàm hiển thị thông tin của khóa học
        public void DisplayCourseInfo()
        {
            if (courses.Count == 0)
            {
                Console.WriteLine("No courses available.");
                return;
            }

            Console.WriteLine("Available Courses:");
            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {courses[i].CourseName}");
            }

            Console.Write("Select a course by number to display info: ");
            int courseIndex = int.Parse(Console.ReadLine()) - 1;

            if (courseIndex < 0 || courseIndex >= courses.Count)
            {
                Console.WriteLine("Invalid course selection.");
                return;
            }

            courses[courseIndex].DisplayCourseInfo();
        }
    }

}
