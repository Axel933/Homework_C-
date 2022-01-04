//В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
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

int[,] Position(int[,] array)
{
    Console.WriteLine("Введите число");
    int count = 0;
    int number = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (number == array[i, j]) Console.WriteLine($"Позиция элемента: строка - {i} , столбец - {j}");
            else count++;
        }
    }
    if (count == (array.GetLength(0) * array.GetLength(1))) Console.WriteLine("Заданный элемент не обнаружен");
    return array;

}


int[,] array = FillArray(3, 3);
PrintArray(array);
Position(array);
