// See https://aka.ms/new-console-template for more information
using LearnListLinQ;

/*Console.WriteLine("Hello, World!");*/

/*var demo = new Demo();
//demo.EasyList();
demo.Dictionary();
*/

/* FUNCTION DELEGATE*/
var learn = new LearnFunc();
//learn.InputScore(); 
/*learn.ValidateScoreWithCondition("math", s => s >= 0 && s <= 10);

learn.ValidateScoreWithCondition("english", score => score >= 0 && score <= 1000);*/

// viết một hàm, nhận vào 1 list và trả ra 1 list mới với các trường hợp
// 1list mới gồm các số / hết cho 5
// 2list mới gồm các số lẻ
// 3list mới gồm các số chẵn

/*var listNumbers = new List<int>() { 10, 45, 3, 9, 20, 6, 8, 11 };

Func<int, bool> check1 = s => s % 5 == 0;

var newListNumbers1 = learn.CreateList(listNumbers, check1);

// tham số chuyền vào =1 list, điều kiện các element trong list thoả mãn
var newListNumbers2 = learn.CreateList(listNumbers, s => s % 2 != 0);
var newListNumbers3 = learn.CreateList(listNumbers, s => s % 2 == 0);*/

// extension fucntion
//var value = "ronaldo";
/*var learnExtension = new LearnExtension();
learnExtension.Print(value);*/
// static nên gọi trực tiếp không cần thông qua đối tượng
//value.Print(); //--> C2 -the value is ronaldo

/* ACTION*/

var learnAction= new LearnAction(); // khai báo đối tượng
/*Action<double> print = s =>  // viết thêm 1 hàm rồi chuyền vào (đồi số)
{
    Console.WriteLine("the score is : " + s);
};
learnAction.HandleStudentScore(print); //HandleStudentScore(đối số là 1 hàm)*/

var studentScores = new List<double>() { 5, 8, 9, 7.5, 0 };
Action<double> printList = s =>
{
    studentScores.Add(s);
    Console.WriteLine(" The list scores");
    foreach (var score in studentScores)
        Console.Write(score + "\t");
};
learnAction.HandleStudentScore(printList); // gọi Action phía trên để add

/*learnAction.HandleStudentScore(s =>
{
    studentScores.Add(s);
    Console.WriteLine(" The list scores");
    foreach (var score in studentScores)
        Console.Write(score + "\t");
});*/


var demoLinQ = new DemoLinQ();
//demoLinQ.PrintOddNumbers();
//demoLinQ.PrintOne();
//demoLinQ.PrintSelect1();

//demoLinQ.TakeSkip();
//demoLinQ.AllAny();
Console.ReadKey();

