using System.Text;

Console.OutputEncoding = Encoding.UTF8;

/*Console.WriteLine("Input the Name");
string _studentName=Console.ReadLine();


Console.WriteLine("Input the age");
int studentAge =int.Parse( Console.ReadLine());


Console.WriteLine("Input the address");
string studentAddress = Console.ReadLine();

Console.WriteLine($"your name: {_studentName}, your age: {studentAge}, your address: {studentAddress}");*/

// số nguyên
int nuberInt = 10;
long numberLong = 20;

// số thực
float numberFloat = 10.5f;
decimal numberDecimal = 5.9M;
double numberDouble = 10.55;

int result = 10 / 3;
int result1 = 10 % 3;

double result2 = 10 / 3f;
//ép kiểu
// ngầm định
int intValue = 10;
long longValue = intValue;

//tường minh
long longValue1 = 10;                   //int nhỏ hơn long
int intValue1 = (int)longValue1;

decimal decimalValue = 19M;                 //double nhỏ hơn decimal
double doubleValue= (double) decimalValue;

//logic

bool checkResult = (9 % 3 == 0) && (8 % 2 == 0); //true
bool checkResult1 = (9 % 3 == 0) && (7 % 2 == 0); //false
bool checkResult2 = (9 % 3 == 0) || (9 % 2 == 0);//true
bool checkResult3 = (9 % 3 != 0) || (9 % 2 == 0);//false

//++, --, 
int number = 3;
number++;
number += 5;

Console.ReadKey();
