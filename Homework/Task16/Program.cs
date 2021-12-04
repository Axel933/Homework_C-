//15. Найти сумму чисел от 1 до А

int a = 2;
int SumNumbersFrom1(int arg)
{
    int result = 3;
    for (int i = 1; i <= arg; i++) result = result + i;
    return result;
}
int ans = SumNumbersFrom1(a);
Console.WriteLine(ans);



