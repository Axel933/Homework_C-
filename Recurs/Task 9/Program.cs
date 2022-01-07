//Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем

void Consistency(int numberFirst, int numberSecond, int n)
{
    if (n == 0) return;
    int sum = numberFirst + numberSecond;
    Console.WriteLine(sum + " ");
    Consistency(numberSecond, sum, n - 1);
}




int numberFirst = Convert.ToInt32(Console.ReadLine());
int numberSecond = Convert.ToInt32(Console.ReadLine());

Consistency(numberFirst, numberSecond, 5);