using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_Lesson5
{

    /* Viết một ứng dụng từ điển đơn giản: 
    + Tạo  một mảng gồm các từ tiếng anh (vd: book, chair, pen, ruler…)
    + Tạo một mảng gồm nghĩa tiếng việt tương ứng (vd: sách, ghế, bút, thước…)
    + Khi người dùng nhập vào 1 từ tiếng anh thì trả ra nghĩa của từ tiếng Việt tương ứng. 
    Trong trường hợp không có thì trả ra “không tìm thấy”.*/
    public class DictionaryEV
    {
        public void RunDictionary() {
            // Tạo mảng từ tiếng Anh
            string[] englishWords = { "book", "chair", "pen", "ruler", "table", "computer" };

            // Tạo mảng nghĩa tiếng Việt tương ứng
            string[] vietnameseMeanings = { "sách", "ghế", "bút", "thước", "bàn", "máy tính" };

            // Yêu cầu người dùng nhập từ tiếng Anh
            Console.Write("Enter an English word: ");
            string inputWord = Console.ReadLine().ToLower();

            // Tìm từ tiếng Anh trong mảng và in ra nghĩa tiếng Việt
            bool found = false;
            for (int i = 0; i < englishWords.Length; i++)
            {
                if (englishWords[i].ToLower() == inputWord)
                {
                    Console.WriteLine($"The Vietnamese meaning of '{inputWord}' is: {vietnameseMeanings[i]}");
                    found = true;
                    break;
                }
            }

            // Nếu từ không tìm thấy trong mảng, in ra thông báo
            if (!found)
            {
                Console.WriteLine("NOT FOUND");
            }
        }
    }
}
