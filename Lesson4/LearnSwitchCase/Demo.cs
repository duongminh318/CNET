﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSwitchCase
{
    public class Demo
    {
        /*
         * trả ra mesage tương ứng với lỗi
         * sử dụng switch case cho tường trường hợp
         * sử dụng enum để lưu list các lỗi định nghĩa trước
         */
        public string ShowMessage(int statusCode)
        {
            var message = string.Empty;
            switch (statusCode)
            {
                case 401:
                    message = CommonConstants.UnAuthoried;
                    break;
                case 200:
                    message = CommonConstants.OK;
                    break;
                case 404:
                    message = CommonConstants.NotFound;
                    break;
                case 400:
                    message = CommonConstants.BadRequest;
                    break;
                default:
                    message = CommonConstants.Undefined;
                    break;
            }
            return message;
        }


        /*// Viết hàm nhận vào Month(int) và Year(int) và 
         * trả ra số ngày trong tháng (có xét đến năm nhuận)*/
        // Hàm GetDaysInMonth để tính số ngày trong tháng (như đã viết trước đó)
        public int GetDaysInMonth(int month, int year)
        {
            if (month < 1 || month > 12)
            {
                //throw new ArgumentOutOfRangeException("month", "Month must be between 1 and 12.");
                throw new ArgumentOutOfRangeException(string.Format(CommonConstants.ErrorMessages.OutOfRangeMessage, month, Month.January.ToString(), Month.December.ToString()));
            }

            // Kiểm tra xem năm có phải là năm nhuận hay không
            bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

            // Trả về số ngày trong tháng dựa trên tháng và năm
            switch (month)
            {
                case 1: // January                 
                case 3: // March
                case 5: // May
                case 7: // July
                case 8: // August
                case 10: // October
                case 12: // December
                    return 31;
                case 4: // April
                case 6: // June
                case 9: // September
                case 11: // November
                    return 30;
                case 2: // February
                    return isLeapYear ? 29 : 28;
                default:
                    throw new ArgumentOutOfRangeException("month", "Invalid month value.");
            }
        }

        public void RunGetDaysInMonth()
        {
            // Nhập liệu từ người dùng
            Console.WriteLine("Enter the month (1-12): ");
            int month;
            while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
            {
                // Console.WriteLine("Invalid input. Please enter a valid month (1-12): ");
                //sử dụng thông điệp lỗi khai báo trong list bên enum CommonConstants
                 Console.WriteLine( string.Format(CommonConstants.ErrorMessages.OutOfRangeMessage, month, Month.January.ToString(), Month.December.ToString()));
            }

            Console.WriteLine("Enter the year: ");
            int year;
            while (!int.TryParse(Console.ReadLine(), out year) || year < 1)
            {
                // Console.WriteLine("Invalid input. Please enter a valid year: ");
                Console.WriteLine(string.Format(CommonConstants.ErrorMessages.YearNotCorrect, year));
            }

            try
            {
                // Gọi hàm GetDaysInMonth để lấy số ngày trong tháng
                int days = GetDaysInMonth(month, year);
                Console.WriteLine($"Number of days in month {month} of year {year}: {days}");
               
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        //cách 2 sử dụng enum
        public int GetDaysInMonthEnum(Month month, int year)
        {
            //enum là 1 list nên phải duyệt qua từng phần tử
           /* if (Month < 1 || month > 12)
            {
                throw new ArgumentOutOfRangeException("month", "Month must be between 1 and 12.");
            }*/

            // Kiểm tra xem năm có phải là năm nhuận hay không
            bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

            // Trả về số ngày trong tháng dựa trên tháng và năm
            switch (month)
            {
                case Month.January:
                case Month.March:
                case Month.May:
                case Month.July:
                case Month.August:
                case Month.Octorber:
                case Month.December:
                    return 31;
                case Month.April:
                case Month.June:
                case Month.September:
                case Month.November:
                    return 30;
                case Month.February:
                    return isLeapYear ? 29 : 28;
                default:
                    throw new ArgumentOutOfRangeException("month", "Invalid month value.");
            }
        }

        public  void RunGetDaysInMonthEnum()
        {
            // Nhập liệu từ người dùng
            Console.WriteLine("Enter the month (1-12): ");
            int monthInput;
            while (!int.TryParse(Console.ReadLine(), out monthInput) || monthInput < 1 || monthInput > 12)
            {
                Console.WriteLine("Invalid input. Please enter a valid month (1-12): ");
            }
            //ép kiểu về enum Month cho giá trị người dùng mới nhập vào
            Month month = (Month)monthInput;

            Console.WriteLine("Enter the year: ");
            int year;
            while (!int.TryParse(Console.ReadLine(), out year) || year < 1)
            {
                Console.WriteLine("Invalid input. Please enter a valid year: ");
            }

            try
            {
                // Gọi hàm GetDaysInMonth để lấy số ngày trong tháng
                int days = GetDaysInMonthEnum(month, year);
                Console.WriteLine($"Number of days in {month} of year {year}: {days}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    
       

    }
}
