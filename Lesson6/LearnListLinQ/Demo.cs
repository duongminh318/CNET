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




		// IN MY

		public void Dictionary()
		{
			var isContinue = true;
			while (isContinue) {

				// Danh sách các từ tiếng Việt
				List<string> vietnameseWords = new List<string> { "bàn", "ghế", "sách" };

				// Danh sách các từ tiếng Anh tương ứng
				List<string> englishWords = new List<string> { "table", "chair", "book" };

				// Nhập một từ tiếng Anh từ người dùng
				Console.Write("Enter an English word:: ");
				string englishWord = Console.ReadLine().Trim().ToLower();

				// Tìm từ tiếng Việt tương ứng
				int index = englishWords.IndexOf(englishWord); // nếu thấy sẽ trả về index
				if (index != -1)    //ko thấy sẽ = -1
				{
					Console.WriteLine($"The Vietnamese meaning of  '{englishWord}' IS: {vietnameseWords[index]}");
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
