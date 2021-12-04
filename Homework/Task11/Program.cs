//10. Выяснить, кратно ли число заданному, если нет, вывести остаток.
void Number(int x)
{
    int a = 240;
    if (x % a == 0) Console.WriteLine($"Число {x} кратно задонному числу");
    else
    {
        Console.WriteLine($"Число {x} не кратно задонному числу");
        Console.WriteLine($"Остаток: {x % a}");
    }
}
Number(481);
Number(480);

