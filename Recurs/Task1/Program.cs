//Показать натуральные числа от 1 до N, N задано

string ShowNumbers(int n)
{
    if (n == 1) return $"{n} ";
    return $"{ShowNumbers(n - 1) + n} "; // Вывод n и запуск метода, на вход которого подаётся число n-1
}

string result = ShowNumbers(5);
Console.WriteLine(result);