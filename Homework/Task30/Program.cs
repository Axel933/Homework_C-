//В двумерном массиве n×k заменить четные элементы на противоположные

int[,] FillArray(int n, int k)
{
    int[,] array = new int[n, k];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(0, 10);
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

int[,] ReverseArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 2 == 0)
            {
                array[i, j] = array[i,j] *-1;
            }
        }
    }
    return array;
}


int[,] array = FillArray(5, 5);
PrintArray(array);
int[,] result= ReverseArray(array);
Console.WriteLine();
PrintArray(result);
