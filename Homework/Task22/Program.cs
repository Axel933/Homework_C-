//20.Написать программу вычисления произведения чисел от 1 до N
int Proz()
{
    Console.WriteLine("Введите n");
    int n = int.Parse(Console.ReadLine());
    int sum = 1;
    for (int i = 1; i <= n; i++)
    {
        sum = sum * i;
    }
    return sum;
}

Console.WriteLine(Proz());



