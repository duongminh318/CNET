using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LearnLoop
{
	public class LearnWhileDoWhile
	{
		//while : ko biết số lần lặp, nhập cho đến khi muốn dừng thì thôi
		// nhập học sinh => continute

		/*viết chương trình yêu cầu nhập tên, sau khi nhập xong thì in ra,
		và hỏi có muốn nhập tiếp không, ko=> dừng lại

		*/
		public void EsayWhile(int number)
		{
			int i = 0;
			while (i <= number)
			{
				if (i % 2 != 0)
				{
					Console.WriteLine(i);
				}

				i++;
			}
		}

		public void EasyInputStudent()
		{
			var isContinue = true;
			while (isContinue)
			{
				Console.WriteLine("Input the name: ");
				var name = Console.ReadLine();
				Console.WriteLine($"your name {name}");
				Console.WriteLine("Do you want to continute? (y/n)");

				isContinue = Console.ReadLine() == "y";

			}
			return;
		}

		public void EasyvalidateAge()
		{
			Console.WriteLine("input the Age");
			var check = int.TryParse(Console.ReadLine(), out var age) && age > 0; // false nếu nhập sai
			while (!check) // check ==false
			{
				Console.WriteLine("the age is not correct, reinput");
				check = int.TryParse(Console.ReadLine(), out age) && age > 0;
			}
			Console.WriteLine($"the age: {age}");
		}

		/*//name
		static string GetStudentName()
		{
			Console.Write("Enter student name: ");
			return Console.ReadLine();
		}
		//age
		public int GetStudentAge()
		{
			int age;
			while (true)
			{
				Console.Write("Enter student age (12-15): ");
				if (int.TryParse(Console.ReadLine(), out age) && age >= 12 && age <= 15)
				{
					return age;
				}
				else
				{
					Console.WriteLine("Invalid age. Please enter a valid age between 12 and 15.");
				}
			}		

		}

		//score
		static double GetStudentScore(string subject)
		{
			double score;
			while (true)
			{
				Console.Write($"Enter {subject} score (0.0-10.0): ");
				if (double.TryParse(Console.ReadLine(), out score) && score >= 0 && score <= 10)
				{
					return score;
				}
				else
				{
					Console.WriteLine("Invalid score. Please enter a valid score between 0.0 and 10.0.");
				}
			}
		}

			public void ContinuteInput()
		{
			bool continueInput = true;

			while (continueInput)
			{
				// Nhập thông tin sinh viên
				string name = GetStudentName();
				int age = GetStudentAge();
				double mathScore = GetStudentScore("Math");
				double literatureScore = GetStudentScore("Literature");
				double englishScore = GetStudentScore("English");

				// Tính điểm trung bình
				double averageScore = (mathScore + literatureScore + englishScore) / 3;

				// In ra thông tin sinh viên
				Console.WriteLine($"Student Info: Name = {name}, Age = {age}, Average Score = {averageScore:F2}");

				// Hỏi người dùng có muốn tiếp tục hay không
				Console.WriteLine("Do you want to enter another student's information? (y/n)");
				string response = Console.ReadLine().ToLower();
				continueInput = response == "y";
			}
		}*/


		// IN CLASS
		public void InputStudent()
		{
			bool continueInput = true;

			while (continueInput)
			{
				Console.WriteLine("input the name: ");
			var name = Console.ReadLine();
            Console.WriteLine("input the age:");
			var checkAge = int.TryParse(Console.ReadLine(), out var age) && age >= 12 && age <= 15;
			while (!checkAge)
			{
                Console.WriteLine("the age is not correct, reinput");
				checkAge= int.TryParse(Console.ReadLine(),out age) && age>0;
            }
			var math = ValidateScore("math");
			var literature = ValidateScore("literature");
			var english = ValidateScore("english");
            Console.WriteLine($"name: {name}, age: {age}, avg score {(math+literature+english)/3}");

				// Hỏi người dùng có muốn tiếp tục hay không
				Console.WriteLine("Do you want to enter another student's information? (y/n)");
				string response = Console.ReadLine().ToLower();
				continueInput = response == "y";
			}
		}

		public double ValidateScore(string scoreName)
		{
            Console.WriteLine($"input the {scoreName}");
			var checkScore= double.TryParse(Console.ReadLine(), out var score) && score > 0 && score<=10;
			while (!checkScore)
			{
				Console.WriteLine($"the {scoreName} is not correct, reinput");
				checkScore= double.TryParse(Console.ReadLine(),out score)&& score > 0 && score<=10;
			}
			return score;
        }

		//DO WHILE
		public void DoWhile()
		{
			int number = 5;
			do
			{
				Console.WriteLine(number);

			} while (number < 5);

		
		}
	}
}
