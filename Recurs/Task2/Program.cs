//Показать натуральные числа от N до 1, N задано

string ShowNumbers(int n)
{
    if ( n==1) return $" {n} ";
    else return $" {n + ShowNumbers(n-1)}";
}

Console.WriteLine(ShowNumbers(5));