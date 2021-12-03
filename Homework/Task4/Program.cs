//Вывод индекса минимального элемента массива 

//                0  1  2  3   4  5   - индексы массива
int[] massive = { 1, 2, 2, -4, 1, 6 };
int Mass(int[] mass)
{
    int j = 0;
    int min = massive[0];
    for (int k = 0; k < massive.Length; k++) // пробежка по всей длине массива
    {
        if (massive[k] < min) // поиск минимума
        {
            min = massive[k];
            j = k;  // Создаем ячейку, в которую кладём индекс минимального элемента 
        }
    }
    return j;
}
int result = Mass(massive);
Console.WriteLine(result);
