// See https://aka.ms/new-console-template for more information
using LearnListLinQ;

/*Console.WriteLine("Hello, World!");*/

/*var demo = new Demo();
//demo.EasyList();
demo.Dictionary();
*/
var learn = new LearnFunc();
//learn.InputScore(); 
/*learn.ValidateScoreWithCondition("math", s => s >= 0 && s <= 10);

learn.ValidateScoreWithCondition("english", score => score >= 0 && score <= 1000);*/


/*var listNumbers = new List<int>() { 10, 45, 3, 9, 20, 6, 8, 11 };

Func<int, bool> check1 = s => s % 5 == 0;

var newListNumbers1 = learn.CreateList(listNumbers, check1);

// tham số chuyền vào =1 list, điều kiện các element trong list thoả mãn
var newListNumbers2 = learn.CreateList(listNumbers, s => s % 2 != 0);
var newListNumbers3 = learn.CreateList(listNumbers, s => s % 2 == 0);*/


var value = "ronaldo";
var learnExtension = new LearnExtension();
learnExtension.Print(value);

value.Print();

Console.ReadKey();

