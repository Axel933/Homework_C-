//Написать программу возведения числа А в целую стень B

int Exponentiation(int a, int b)
{
    if (b == 1) return a;
    else return a * Exponentiation(a, b - 1);
}

Console.WriteLine(Exponentiation(2, 3));