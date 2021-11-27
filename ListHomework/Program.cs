// // Вывести квадрат числа
// // 1 cпособ 
// int Sqrt(int x)
// {
//     return x*x;
// }

// int result=Sqrt(5);
// Console.WriteLine(result);

// // 2 cпособ 
// void Sqrt(int a)
// {
//     int S;
//     S=a*a;
//     Console.WriteLine(S);
// }

// Sqrt(5);

//2. По двум заданным числам проверять является ли первое квадратом второго 

// void method1 (int a,int y)
// {
//     if(a==y*y) Console.WriteLine($"Число {a} является квадратом числа {y}");
//     else Console.WriteLine($"Число {a} не является квадратом числа {y}");
// }

// method1(5,2);

//3. Даны два числа. Показать большее и меньшее число

// void Method(int a, int b)
// {
//     if(a>b) Console.WriteLine($"Число {a} - большее, число {b} - меньшее");
//     else Console.WriteLine($"Число {b} - большее, число {a} - меньшее");
// }
// Method(8,3);
// Method(7,10);

//4. По заданному номеру дня недели вывести его название
// 1 способ
// void Day(int a)
// {
//     if (a==1) Console.WriteLine("Monday");
//     if (a==2) Console.WriteLine("tuesday");
//     if (a==3) Console.WriteLine("wednesday");
//     if (a==4) Console.WriteLine("thursday");
//     if (a==5) Console.WriteLine("friday");
//     if (a==6) Console.WriteLine("saturday");
//     if (a==7) Console.WriteLine("Sunday");
// }
// Day(4);

//  2 способ 
// void Day(int a)
// {
//     string[] Array={"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
//     Console.WriteLine(Array[a-1]);
// }
// Day(7);

//5. Удалить вторую цифру трёхзначного числа
//  void DeleteNumber(int number)
// {
//     int a = number / 100;
//      int b = number % 10;
//     int c = a * 10 + b;
//     Console.WriteLine(c);
// }

//  DeleteSecNumber(563);

//6. Показать последнюю цифру трёхзначного числа
// void LastNumber(int number)
// {
//     int result = number % 10;
//     Console.WriteLine(result);
// }

// LastNumber(356);

//7. Показать вторую цифру трёхзначного числа
// void SecondNumber(int number)
// {
//     int result = number/10;
//     result = result%10;
//     Console.WriteLine(result);
// }

// SecondNumber(345);

//8. Выяснить является ли число чётным 
// void Even(int number)
// {
//     if (number % 2 == 0) Console.WriteLine($"Число {number} - чётное");
//     else Console.WriteLine($"Число {number} - нечётное");
// }
// Even(244);
// Even(335);

//9. Показать числа от -N до N    
// void Numbers(int N)
// {
//   for(int i=-N; i<=N; i++)
//   {
//     Console.WriteLine(i);
//   }
// }
// Numbers(3);

// }
// Numbers(array);

//10. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// void Number(int x)
// {
//     int a = 240;
//     if (x % a == 0) Console.WriteLine($"Число {x} кратно задонному числу");
//     else
//     {
//         Console.WriteLine($"Число {x} не кратно задонному числу");
//         Console.WriteLine($"Остаток: {x%a}");
//     }
// }
// Number(481);
// Number(480);

// 11. =========Дано число из отрезка [10, 99]. Показать наибольшую цифру числа=======
// void Search()
// {
//     int a = new Random().Next(10, 99);
//     Console.WriteLine(a);
//     int x=a/10;
//     int y=a%10;
//     if(x>y) Console.WriteLine($"Число {x}");
// }

// Search();

//12. Написать программу вычисления значения функции y=f(a)
// double F(double a)
// {
//     return Math.Sin(a);
// }
// double sin=F(3.14);
// Console.WriteLine(sin);

//13. Найти максимальное из трех чисел
// int Findmax(int arg1, int arg2, int arg3)
// {
//     int max = arg1;
//     if (arg2 > max) max = arg2;
//     if (arg3 > max) max = arg3;
//     return max;
// }

// int a=new Random().Next(1,90);
// int b=new Random().Next(1,90);
// int c=new Random().Next(1,90);
// int result=Findmax(a,b,c);
// Console.WriteLine($"Среди числе {a},{b},{c} самое максимальное - {result}");

//14. Дано число обозначающее день недели. Выяснить является номер дня недели выходным днём
// bool FindWeek(int a)
// {
//     if(a==6 || a==7) return true;
//     else return false;
// }
// Console.WriteLine(FindWeek(6));

//15. Найти сумму чисел от 1 до А

// int a = 2;
// int SumNumbersFrom1(int arg)
// {
//   int result = 3;
//   for(int i = 1; i <= arg; i++) result = result + i;
//    return result;
// }
// int ans = SumNumbersFrom1(a);
//  Console.WriteLine(ans);


//16. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
//  bool Func(bool x, bool y)
//  {
//       return (!(x && y) == !x || !y);
//  }


//  bool To(int a)
// {
//    return a==0;
// }
// bool res=true;
// bool Check()
// {
//   for( int i=0; i<=1; i++)
//   {
//     for( int j=0; j<=1; j++)
//     {
//       res=Func(To(i),To(j));
//     }
//   }
//   return res;
// }

// Console.WriteLine(res);

//20. Ввести номер четверти, показать диапазоны для возможных координат
// String F()
// {
//     Console.WriteLine("Введите номер четверти");
//     string a = Console.ReadLine();
//     int arg = Convert.ToInt32(a);
//     if (arg == 1) return ("x>0,y>0");
//     if (arg == 2) return ("x<0,y>0");
//     if (arg == 3) return ("x<0,y<0");
//     if (arg == 4) return ("x>0,y<0");
//     else return ("Введите номер четверти от 1 до 4");
// }

// Console.WriteLine(F());

// 21. Программа проверяет пятизначное число на палиндромом.
// bool Func21(int n)
//  {
//      if(n / 10000 == n % 10 && n / 1000 % 10 == n / 10 % 10) return true;
//      else return false;
//  }

//  Console.WriteLine(Func21(22321));
// 22. Программа проверяет слово на палиндромом.
// bool func(string word)
// {
//     int L = word.Length;
//     for (int i = 0; i < word.Length; i++)
//     {
//         if (word[i] != word[word.Length-i-1]) return false;

//     }
//     return true;
// }
// string word="cомок";
// func(word);

// Console.WriteLine(func(word));

//23. Подсчитать сумму цифр в числе

// int Sum()
// {
//     Console.WriteLine("Введите число ");
//     int n = int.Parse(Console.ReadLine());
//     int[] a = new int[n];
//     int sum=0;
//     for(int i = 0;i<n;i++)
//             {
//                 Console.WriteLine($"Введите {i + 1}-й элемент");
//                 a[i] = int.Parse(Console.ReadLine());
//             }
//     for (int i = 0; i < n; i++)
//     {
//         sum = sum + a[i];
//     }
//     return sum;
// }

// int a = Sum();
// Console.WriteLine($"Сумма цифр чилса {a}");

//24.Написать программу вычисления произведения чисел от 1 до N
// int Proz()
// {
//     Console.WriteLine("Введите n");
//     int n = int.Parse(Console.ReadLine());
//     int sum = 1;
//     for (int i = 1; i <= n; i++)
//     {
//         sum = sum * i;
//     }
//     return sum;
// }

// Console.WriteLine(Proz());

//25.Показать кубы чисел, заканчивающихся на четную цифру
// int Cub()
// {
//      int F=1;
//     Console.WriteLine("Введите число");
//     int arg = int.Parse(Console.ReadLine());
//     if (arg % 10 == 1)
//     {

//     }
//     return F=arg*arg*arg;

// }

// int result=Cub();
// Console.WriteLine(result);

//  Двумерные массивы

// int[,] array = new int[3,3];
// for( int i=0; i<array.GetLength(0); i++)
// {
//     for( int j=0; j<array.GetLength(1); j++)
//     {
//         array[i,j]=new Random().Next(0,5);
//         Console.Write($"{array[i, j]}  ");
//     }
//     Console.WriteLine();
// }

//  40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// double[] Array()
// {
//     double[] array = new double[5];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().NextDouble();
//         Console.WriteLine(array[i]);
//     }
//     return array;
// }

// double FindMax(double[] arr)
// {
//     double max = arr[0];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > max) max = arr[i];
//     }
//     Console.WriteLine($"Наибольший элемент массива: {max}");
//     return max;
// }

// double FindMin(double[] arr)
// {
//     double min = arr[0];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i]<min) min=arr[i];
//     }
//     Console.WriteLine($"Наименьший элемент массива: {min}");
//     return min;
// }

// double Difference(double max,double min)
// {
//     return max-min;
// }

// double[] array = Array();
// double max = FindMax(array);
// double min = FindMin(array);
// double Diff=Difference(max,min);
// Console.WriteLine($"Разность максимального и минимального элемента {Diff}");

//  38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

// int[] Array()
// {
//     int[] array = new int[5];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 5);
//         Console.WriteLine(array[i]);
//     }
//     return array;
// }

// int FindSum(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i +=2) sum = sum + array[i];
//     return sum ;
// }



// int[] array = Array();
// int sum = FindSum(array);
// Console.WriteLine();
// Console.WriteLine($"Сумма нечетных элементов {sum}");


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
