using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDictionary
{
    public class Demo
    {
        public void Easy()
        {
            Dictionary<string,int> studentAges= new Dictionary<string,int>
            {
                { "lan", 10},
                { "nam", 11},
                { "tuan", 12},
            };
            studentAges.Add("messi", 12);

            // output
            var lanAge = studentAges["lan"];
            Console.WriteLine(lanAge);

            // duyệt các element
            foreach(var item in studentAges)
            {
                Console.WriteLine($"key {item.Key}, value: {item.Value}");
            }
        }
    }
}
