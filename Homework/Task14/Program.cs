//13. Найти максимальное из трех чисел
int Findmax(int arg1, int arg2, int arg3)
{
    int max = arg1;
    if (arg2 > max) max = arg2;
    if (arg3 > max) max = arg3;
    return max;
}

int a = new Random().Next(1, 90);
int b = new Random().Next(1, 90);
int c = new Random().Next(1, 90);
int result = Findmax(a, b, c);
Console.WriteLine($"Среди числе {a},{b},{c} самое максимальное - {result}");


