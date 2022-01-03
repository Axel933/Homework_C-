//Показать двумерный массив размером m×n заполненный целыми числами

int[,] FillArray(int m, int n) //Заполнение массива
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
    for (int m = 0; m < a.GetLength(0); m++)
    {
        for (int n = 0; n < a.GetLength(1); n++)
        {
            Console.Write($"{a[m, n]} ");
        }
        Console.WriteLine();
    }
}

int[,] result = FillArray(5, 5);
PrintArray(result);