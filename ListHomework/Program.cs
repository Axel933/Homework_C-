//25
// Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue].
// Создать на его основе масив B, отбрасывая те, которые нарушают порядок
// возрастания
// элементы, больше 8
// знакочередования

// void PrintArray(int[] a) //Метод для печати массива
// {
//     int index = 0;
//     int n = a.Length;

//     while (index < n)
//     {
//         Console.WriteLine(a[index]); //Пока index<n выводи элементы массива
//         index++;
//     }
// }

// void FillArray(int[] B)
// {
//     int i = 0;
//     int N = B.Length;
//     while (i < N)
//     {
//         B[i] = new Random().Next(5, 10);
//         i++;

//     }
// }

// int[] A = new int[5];
// FillArray(A);

// int count = 0;
// int Length = A.Length;
// int sum = 0;
// int i = 0;

// while (count < Length)
// {

//     sum = sum + A[count];
//     count++;
// }

// int SrA = sum / Length;
// PrintArray(A);
// Console.WriteLine();

// Console.WriteLine($"Cреднее арифметическое:{SrA}");

// Console.WriteLine("Построим новый массив");

// int[] B = new int[5];
// int L = B.Length;
// int In = 0;

// while(count<L)
// {
//     if(A[count]<SrA)
//     {
//         B[In]=A[count];
//         In++;
//         count++;
//     }
//     else
//     {

//     }
// }

// PrintArray(B)

//26
// //является ли введённое с клавиатуры число совершенным. 
// //Cовершенные числа - те числа у которых сумма делителей равна самому числу ( 6 = 1 + 2 + 3)

// Console.WriteLine("Введите число а");
// int a = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// for (int i = 1; i < a; i++)
// {
//     if (a % i == 0)
//     {
//         sum = sum + i;
//     }
// }
// if (sum == a)
// {
//     Console.WriteLine("Число соверешенное");
// }
// else
// {
//     Console.WriteLine("Число несоверешенное");
// }

// Console.WriteLine(sum);



//    66. Показать натуральные числа от 1 до N, N задано
string ShowNaturalNumbers(int n)
{
    if (n <= 1) return "1";
    else return $"{ShowNaturalNumbers(n - 1)} {n - 1}";
}
Console.WriteLine(ShowNaturalNumbers(6));