using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LearnString
{
    public class Demo
    {
        // example
        string str = " Hello world ";
        
       
        public void StringMethod()
        {
            // cắt đầu cắt đuôi nếu có space
            Console.WriteLine("Trim " + str.Trim()); // Hello ko có space

            Console.WriteLine("first index of o is: "+str.IndexOf("o")); //5
            Console.WriteLine("last index of o is: "+str.LastIndexOf("o")); //8

            // thêm 1 chuỗi vào cuỗi StringBuilder
            StringBuilder sd = new StringBuilder("hello ");
            sd.Append("Dương");
            Console.WriteLine(sd);
            sd.Append(" Khởi Minh");
            Console.WriteLine(sd);

            //insert(index cần chèn, "str sẽ chèn")

            sd.Insert(sd.Length, " đẹp trai");// hello Dương Khởi Minh đẹp trai
            Console.WriteLine(sd);

            //remove(index start, số ký tự sẽ xoá)
            sd.Remove(5, 5); // hello Khởi Minh đẹp trai
            Console.WriteLine(sd);

            //replace("str cần thay", "str sẽ thay");
            sd.Replace("trai", "boy"); // hello Khởi Minh đẹp boy
            Console.WriteLine(sd);
        }

        /*Date Time*/

       

    }
}
