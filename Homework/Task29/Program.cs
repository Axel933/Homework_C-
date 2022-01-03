//В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] FillArray()
{
    double[] array = new double[5];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble();
        Console.WriteLine(array[i]);
    }
    return array;
}

double FindMaxValue(double[] a) // Поиск максимального значения 
{
    double maxValue = a[0];
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] > maxValue) maxValue = a[i];
    }
    return maxValue;
}

double FindMinValue(double[] a) // Поиск минимального значения 
{
    double minValue = a[0];
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] < minValue) minValue = a[i];
    }
    return minValue;
}

double SubMaxMinValue(double maxValue, double minValue)
{
    return maxValue - minValue;
}

double[] massive = FillArray();
Console.WriteLine();

Console.WriteLine(SubMaxMinValue(FindMaxValue(massive), FindMinValue(massive)));