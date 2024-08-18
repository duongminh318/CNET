// See https://aka.ms/new-console-template for more information
using LearnOOP2.Students;

Console.WriteLine("Hello, World!");
// lớp học học sinh có 2 môn chính là văn,toán, mỗi bạn có thể học thêm 1 môn năng khiếu
var anna = new EngStudent(1, "anna", 7, 10);
Console.WriteLine(anna.GetInfo());
Console.ReadKey();