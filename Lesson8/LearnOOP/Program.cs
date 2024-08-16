using LearnOOP;
using LearnOOP.Products;
using System.Reflection;




/*var bob = new Student2();
bob.Id = 2;
bob.Name = "Bob";
bob.Age = 14;
bob.Address = "cg";



var Ronaldo = new Student2()
{
    Id = 3,
    Name = "ronaldo",
    Age = 15,
    Address = "xp"
};*/


// Gọi constructor với 4 tham số
Student2 student2 = new Student2(1, "John Doe", 13, "123 Main St");
student2.DisplayInfo();


// Gọi constructor với 3 tham số
//Student2 student3 = new Student2(2, "Jane Smith", 22);


// gọi hàm produc5
var manager = new ProductManager();
manager.Init();


Console.ReadKey();