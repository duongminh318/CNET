using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnArray
{
	public class demo
	{
		/*viết chương trình cho phép định ra chiều dài mảng,
		 * sau đó nhập phần tử vào mảng số nguyên, sau đó tính giá 
		 * trị trung bình cac phần tử trong mảng.
		 */

		//IN CLASS
		public void InputArray()
		{
			Console.WriteLine("input the array length");
			var length = int.Parse(Console.ReadLine());
			int[] numbers = new int[length];
			int sum = 0;
			for (int i = 0; i < length; i++)
			{
				Console.WriteLine($"input the element {i} of array");
				numbers[i] = int.Parse(Console.ReadLine());
				sum += numbers[i];
			}
			Console.WriteLine($"THE AVG IS {(double)sum / length}");

		}

		//IN HOME

		/*	public void InputArray()
			{
				// Nhập chiều dài mảng
				int arrayLength = GetArrayLength();

				// Khởi tạo mảng số nguyên với chiều dài đã nhập
				int[] numbers = new int[arrayLength];

				// Nhập các phần tử vào mảng
				for (int i = 0; i < arrayLength; i++)
				{
					numbers[i] = GetArrayElement(i);
				}

				// Tính giá trị trung bình các phần tử trong mảng
				double average = CalculateAverage(numbers);

				// In ra giá trị trung bình
				Console.WriteLine($"The average value of the array elements is: {average:F2}");
			}

			public int GetArrayLength()
			{
				int length;
				while (true)
				{
					Console.Write("Enter the length of the array: ");
					if (int.TryParse(Console.ReadLine(), out length) && length > 0)
					{
						return length;
					}
					else
					{
						Console.WriteLine("Invalid length. Please enter a positive integer.");
					}
				}
			}

			public int GetArrayElement(int index)
			{
				int element;
				while (true)
				{
					Console.Write($"Enter element at index {index}: ");
					if (int.TryParse(Console.ReadLine(), out element))
					{
						return element;
					}
					else
					{
						Console.WriteLine("Invalid input. Please enter an integer.");
					}
				}
			}

			static double CalculateAverage(int[] numbers)
			{
				int sum = 0;
				for (int i = 0; i < numbers.Length; i++)
				{
					sum += numbers[i];
				}
				return (double)sum / numbers.Length;
			}*/

		public void PrintOddNumbers()
		{
			int[] numbers = { 1, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, };
			foreach(var number in numbers)
			{
				if (number % 2 != 0)
				{
                    Console.WriteLine(number);
                }
			}
		}

	}
}
