//Найти сумму элементов от M до N, N и M заданы

int Sum(int m, int n)
{
    if (m == n) return m;
    else return m + Sum(m + 1, n);
}


Console.WriteLine(Sum(1, 4));