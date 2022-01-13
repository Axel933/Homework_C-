//Написать программу, которая обменивает элементы первой строки и последней строки
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


int[,] ChangeArray(int[,] array)
{
    int[] middleArray = new int[array.GetLength(0)]; //массив, в который будет положна первая строка
    for (int j = 0; j < array.GetLength(1); j++)
    {
        middleArray[j] = array[0, j];
        array[0, j] = array[array.GetLength(1) - 1, j];
        array[array.GetLength(1) - 1, j] = middleArray[j];
    }
    return array;
}



int[,] array = FillArray(5, 5);
PrintArray(array);
Console.WriteLine();
int[,] result = ChangeArray(array);
PrintArray(result);