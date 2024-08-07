using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDateTime
{
    public class Demo
    {
        public void DateTimeMethod()
        {
            // now
            Console.WriteLine(DateTime.Now); // ngày giờ hiện tại
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(new DateTime(2023,5,15)); // truyền vào
            Console.WriteLine(new DateTime(2023, 5, 15,10,30,0)); // giờ phút giây

            //cộng thêm ngày .AddDays(số ngày muốn cộng)
            Console.WriteLine(DateTime.Now.AddDays(7)); //1/7 --> 8/7

            // khoảng cách thời gian
            DateTime earlierDate = new DateTime(2024, 1, 1);
            DateTime laterDate = new DateTime(2024, 1, 10);
            //từ ngày này tới ngày kia -> bao nhiêu ngày
            Console.WriteLine(laterDate.Subtract(earlierDate));//0

            // format từ DateTime --> Tostring
            DateTime date = DateTime.Now;
            string formattedDate = date.ToString("yyyy/MM-dd HH:mm:ss");
            Console.WriteLine(formattedDate);

        }
    }
}
