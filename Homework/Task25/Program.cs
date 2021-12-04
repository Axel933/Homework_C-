//  23. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] Array()
{
    double[] array = new double[5];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble();
        Console.WriteLine(array[i]);
    }
    return array;
}

double FindMax(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    Console.WriteLine($"Наибольший элемент массива: {max}");
    return max;
}

double FindMin(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    Console.WriteLine($"Наименьший элемент массива: {min}");
    return min;
}

double Difference(double max, double min)
{
    return max - min;
}

double[] array = Array();
double max = FindMax(array);
double min = FindMin(array);
double Diff = Difference(max, min);
Console.WriteLine($"Разность максимального и минимального элемента {Diff}");


