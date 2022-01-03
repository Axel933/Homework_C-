//В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
int[,] FillArray(int m, int n)
{
    int[,] array = new int[5, 5];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}



int[,] ChangeArray(int[,] a)
{
    for (int m = 0; m < a.GetLength(0); m++)
    {
        for (int n = 0; n < a.GetLength(1); n++)
        {
            if (m % 2 == 0 && n % 2 == 0 && m != 0 && n != 0) a[m, n] = a[m, n] * a[m, n];
        }
    }
    return a;
}

int[,] array = FillArray(5, 5);
PrintArray(array);
Console.WriteLine();
int[,] reverseArray = ChangeArray(array);
PrintArray(reverseArray);