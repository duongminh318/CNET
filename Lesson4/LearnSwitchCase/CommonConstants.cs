using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSwitchCase
{
    public static class CommonConstants
    {
        public const string UnAuthoried = "unauthorized";
        public const string NotFound = "Not found";
        public const string OK = "OK";
        public const string BadRequest = "BadRequest";
        public const string Undefined = "Undefined";
        public const double PI = 3.14;

        //Chứa thông điệp lỗi định dạng.
        public static class ErrorMessages
        {
            public const string OutOfRangeMessage = "Value {0} is out of {1} - {2}";
            public const string YearNotCorrect = "Value {0} Not Correct";
            public const string ValueIsNotValid = "Value {0} is not valid";
        }



    }
}
