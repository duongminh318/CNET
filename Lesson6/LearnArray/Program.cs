// See https://aka.ms/new-console-template for more information
using LearnArray;

Console.WriteLine("Hello, World!");
int[] numbers= new int[5];      //kt cho biết mảng số lượng phần tử
								//int[] numbers1= new int[] { 1,2,3,4,5,6,7,8};  //khởi tạo mảng kèm giá trị
								//int[] numbers2= { 1,2,3,4,5,6,7,8};



numbers[0] = 10;
numbers[1] = 20;	
numbers[2] = 30;

var firstElement = numbers[0];
var lastElement= numbers[numbers.Length-1];


//ex
var demo= new demo();
//demo.InputArray();
demo.PrintOddNumbers();


Console.ReadLine();			