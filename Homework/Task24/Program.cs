﻿// 22. Двумерные массивы

int[,] array = new int[3, 3];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 5);
        Console.Write($"{array[i, j]}  ");
    }
    Console.WriteLine();
}


