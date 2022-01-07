//Найти сумму цифр числа

int Sum(int n)
{
    if (n == 0) return n;
    return n % 10 + Sum(n / 10);
}

Console.WriteLine(Sum(33));
