//Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write($"{a[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] AverageColumn(int[,] a)
{
    double[] sum = new double[a.GetLength(1)];
    for (int i = 0; i < a.GetLength(1); i++)
    {
        for (int j = 0; j < a.GetLength(0); j++) sum[i] = sum[i] + a[j,i];
        sum[i] /= a.GetLength(0);
    }
    return sum;
}



int[,] array = FillArray(4, 5);
PrintArray(array);

Console.WriteLine(String.Join( " | ",AverageColumn(array)));
