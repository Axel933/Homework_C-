// Вывести квадрат числа
// 1 cпособ 
int Sqrt(int x)
{
    return x * x; // Возвращаем квадрат как произведение
}

int result = Sqrt(5);
Console.WriteLine(result);
// 2 cпособ 
void Sqrt(int a)
{
    int S;
    S = a * a;
    Console.WriteLine(S);
}

Sqrt(5);
