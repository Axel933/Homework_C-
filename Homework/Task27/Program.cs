// Задача по вводу числа с помощью рекурсии 
int input()
{
    int Number = 0;
    if ((int.TryParse((Console.ReadLine()), out int num) && num > 0))
        Number = num;
    else input();
    return Number;
}

int result = input();
Console.WriteLine(result);

