//  24. Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] Array()
{
    int[] array = new int[5];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 5);
        Console.WriteLine(array[i]);
    }
    return array;
}

int FindSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2) sum = sum + array[i];
    return sum;
}



int[] array = Array();
int sum = FindSum(array);
Console.WriteLine();
Console.WriteLine($"Сумма нечетных элементов {sum}");


