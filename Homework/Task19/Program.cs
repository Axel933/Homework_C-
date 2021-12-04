// 18. Программа проверяет пятизначное число на палиндромом.
bool Func21(int n)
{
    if (n / 10000 == n % 10 && n / 1000 % 10 == n / 10 % 10) return true;
    else return false;
}


Console.WriteLine(Func21(22321));