// 11. =========Дано число из отрезка [10, 99]. Показать наибольшую цифру числа=======
void Search()
{
    int a = new Random().Next(10, 99);
    Console.WriteLine(a);
    int x = a / 10; // Вычленение первой цифры числа
    int y = a % 10; // Вычленение второй цифры числа 
    if (x > y) Console.WriteLine($"Число {x}");
}

Search();

