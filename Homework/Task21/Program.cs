//19. Подсчитать сумму цифр в числе

int Sum()
{
    Console.WriteLine("Введите число ");
    int n = int.Parse(Console.ReadLine());
    int[] a = new int[n];
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент");
        a[i] = int.Parse(Console.ReadLine());
    }
    for (int i = 0; i < n; i++)
    {
        sum = sum + a[i];
    }
    return sum;
}
int a = Sum();
Console.WriteLine($"Сумма цифр чилса {a}");

