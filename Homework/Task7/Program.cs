//7. Показать вторую цифру трёхзначного числа
void SecondNumber(int number)
{
    int result = number / 10;
    result = result % 10;
    Console.WriteLine(result);
}
SecondNumber(345);

