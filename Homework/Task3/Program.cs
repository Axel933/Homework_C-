//3. Даны два числа. Показать большее и меньшее число

void Method(int a, int b)
{
    if (a > b) Console.WriteLine($"Число {a} - большее, число {b} - меньшее");
    else Console.WriteLine($"Число {b} - большее, число {a} - меньшее");
}
Method(8, 3);
Method(7, 10);
