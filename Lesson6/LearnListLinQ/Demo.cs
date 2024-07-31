using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnListLinQ
{
	public class Demo
	{
		public void EasyList()
		{
			var numbers= new List<int>();  // = <datatype>
			numbers.Add(1);
			numbers.Add(2);
			numbers.Add(3);
			numbers.Add(4);
			numbers.Add(5);

			var firstElement = numbers[0];		//pt đầu tiên
			var LastElement= numbers[numbers.Count-1];  //pt cuối cùng
			numbers.Remove(firstElement);	// delete pt nào đó
		}

        /* viết 1 ứng dụng từ điển:
		 1 list các từ tiếng việt : bàn, ghế, sách..
		 1 list các từ tiếng anh: table,chair, book
		 nhập 1 từ tiếng anh => từ tiếng việt tương ứng, 
		nếu ko có thì trả ra là ko tìm thấy*/

        // IN CLASS
        public void Dictionary()
        {
            var isContinue = true;
            while (isContinue)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.InputEncoding = Encoding.UTF8;
                var engs = new List<string>() { "table", "chair", "book", "suitable" };
                var vns = new List<string>() { "bàn", "ghế", "sách", "phù hợp" };
                Console.WriteLine("Nhập từ cần tra");
                var word = Console.ReadLine();
                var result = LookUp(word, engs, vns);
                //var result = LookUp1(word, engs, vns);
                Console.WriteLine(result);
                Console.WriteLine("Bạn có muốn tiếp tục? (y/n)");
                // cờ = true --> tiếp tục, false --> break
                isContinue = Console.ReadLine().Equals("y", StringComparison.OrdinalIgnoreCase);
            }
        }

        // tìm kiếm
        private string LookUp(string word, List<string> engs, List<string> vns)
        {
            for (int i = 0; i < engs.Count; i++)
            {
                //if (word == engs[i])  //str.Equals(string2, so sánh string với str2)
                if (word.Equals(engs[i], StringComparison.OrdinalIgnoreCase)) 
                    //true --> str1 == str2
                {
                    return $"Kết quả là:{vns[i]}";
                }
            }
            return "Không tìm thấy";
        }

        private string LookUp1(string word, List<string> engs, List<string> vns)
        {
            var rerult = new List<string>(); // tạo mảng rỗng
            for (int i = 0; i < engs.Count; i++)// duyệt list
            {
                //if (word == engs[i]) //str1 có chứa str2 ko --> true/false
                if (engs[i].Contains(word, StringComparison.OrdinalIgnoreCase))
                // --> true --> str1 == str2 (StringComparison.OrdinalIgnoreCase:không phân biệt hoa thường)
                {
                    rerult.Add($"{engs[i]} : {vns[i]}"); // thêm vào rỗng 1 element
                                                 // tương ứng với 1 cặp eng :vn
                }
            }
            if (rerult.Count > 0) // true nếu tồn tại element trong list
            {
                string disPlayResult = "Kết quả là: ";
                foreach (var item in rerult)
                {
                    disPlayResult += item + ";"; // nối chuỗi
                }
                return disPlayResult;
            }
            else
            {
                return "Không tìm thấy";
            }
        }




        // IN MY

        public void Dictionary1()
		{
			var isContinue = true;
			while (isContinue) {

				// Danh sách các từ tiếng Việt
				List<string> vietnameseWords = new List<string> { "bàn", "ghế", "sách" };

				// Danh sách các từ tiếng Anh tương ứng
				List<string> englishWords = new List<string> { "table", "chair", "book" };

				// Nhập một từ tiếng Anh từ người dùng
				Console.Write("Enter an English word:: ");
				string strEnglishWord = Console.ReadLine().Trim().ToLower();

				// Tìm từ tiếng Việt tương ứng
				int index = englishWords.IndexOf(strEnglishWord); // nếu strEnglishWord thấy trong englishWords sẽ trả về index
                if (index != -1)    // ko thấy sẽ = -1
				{
					Console.WriteLine($"The Vietnamese meaning of  '{strEnglishWord}' IS: {vietnameseWords[index]}");
				}
				else
				{
					Console.WriteLine("NOT FOUND.");
				}
                Console.WriteLine("Can You Continue? (Y/N)");
				isContinue = Console.ReadLine() == "y";
            }

		
		}
	}
}
