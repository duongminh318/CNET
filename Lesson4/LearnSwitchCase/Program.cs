using LearnSwitchCase;

var dm1 = new Demo();
//dm1.ShowMessage(200);
dm1.RunGetDaysInMonth();
//dm1.RunGetDaysInMonthEnum();

// enum(key(int), value(string))
var values =(int)Month.January; // int
var values2 =Month.January; // string

Console.ReadKey();