//Показать натуральные числа от M до N, N и M заданы

string ShowNatNumbers(int m, int n)
{
    
    if(m<n) return $" { m + ShowNatNumbers(m+1,n) }";
    else return $" {n}";
    
}
Console.WriteLine(ShowNatNumbers(3,10));