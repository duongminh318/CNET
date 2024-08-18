// See https://aka.ms/new-console-template for more information
using LearnOOP2.Ex1;
using LearnOOP2.Students;

Console.WriteLine("Hello, World!");
// lớp học học sinh có 2 môn chính là văn,toán, mỗi bạn có thể học thêm 1 môn năng khiếu
// Khởi tạo các đối tượng sinh viên từ các lớp EngStudent và HisStudent
var anna = new EngStudent(1, "anna", 7, 5, 6);
var sophia = new EngStudent(2, "sophia", 8, 10, 6);
var bob = new HisStudent(3, "bob", 5, 1, 6);
var tom = new HisStudent(4, "tom", 7, 8, 4);

// Tạo một danh sách chứa các đối tượng sinh viên từ các lớp khác nhau
var students = new List<IGetTotalScore>() { anna, sophia, bob, tom };

// Duyệt qua từng sinh viên trong danh sách
foreach (var student in students)
{
    // Gọi phương thức GetInfo() trên mỗi đối tượng sinh viên, phương thức được ghi đè sẽ được gọi
    //Console.WriteLine(student.GetInfo());

    // ép kiểu runtime --> HisStudent trong list baseStudent

    /* if (student is HisStudent his)
     {
       //  Console.WriteLine();
         // list his students
         Console.WriteLine($"Name: {his.Name}- History Score: {his.His}");
     }*/
    if (student is BaseStudent baseStudent)
    {
        //Console.WriteLine(baseStudent.GetInfo());
    }
    //  Console.WriteLine($"total score: {student.GetTotalScore()}");

    // ex1
    LearningManagementSystem lms = new LearningManagementSystem();

    while (true)
    {
        Console.WriteLine("\n===== Learning Management System =====");
        Console.WriteLine("1. Add Student");
        Console.WriteLine("2. Add Teacher");
        Console.WriteLine("3. Create Course");
        Console.WriteLine("4. Enroll Student to Course");
        Console.WriteLine("5. Display Course Info");
        Console.WriteLine("6. Exit");
        Console.Write("Please select an option: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                lms.AddStudent();
                break;
            case "2":
                lms.AddTeacher();
                break;
            case "3":
                lms.CreateCourse();
                break;
            case "4":
                lms.EnrollStudentToCourse();
                break;
            case "5":
                lms.DisplayCourseInfo();
                break;
            case "6":
                Console.WriteLine("Exiting program...");
                return;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                break;
        }
    }

}

Console.ReadKey();