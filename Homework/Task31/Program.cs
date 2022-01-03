//Задать двумерный массив следующим правилом: Aₘₙ = m+n

int[,] FillArray(int m, int n)
{
    int[,] array = new int[5, 5];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
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

int[,] array=FillArray(5,5);
PrintArray(array);
