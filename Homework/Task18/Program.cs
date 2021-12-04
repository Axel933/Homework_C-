//17. Ввести номер четверти, показать диапазоны для возможных координат
String F()
{
    Console.WriteLine("Введите номер четверти");
    string a = Console.ReadLine();
    int arg = Convert.ToInt32(a);
    if (arg == 1) return ("x>0,y>0");
    if (arg == 2) return ("x<0,y>0");
    if (arg == 3) return ("x<0,y<0");
    if (arg == 4) return ("x>0,y<0");
    else return ("Введите номер четверти от 1 до 4");
}

Console.WriteLine(F());

