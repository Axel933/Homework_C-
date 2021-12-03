//4. По заданному номеру дня недели вывести его название
// 1 способ
void Day(int a)
{
    if (a == 1) Console.WriteLine("Monday");
    if (a == 2) Console.WriteLine("tuesday");
    if (a == 3) Console.WriteLine("wednesday");
    if (a == 4) Console.WriteLine("thursday");
    if (a == 5) Console.WriteLine("friday");
    if (a == 6) Console.WriteLine("saturday");
    if (a == 7) Console.WriteLine("Sunday");
}
Day(4);

//  2 способ 
// void Day(int a)
// {
//     string[] Array = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
//     Console.WriteLine(Array[a - 1]);
// }
// Day(7);