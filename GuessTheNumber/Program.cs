//Игра "Угадай число"

int CreatNumber() //Генерация числа от 1 до 100
{
    int Number = new Random().Next(1, 101); // Рандомная генерация числа 

    if (Number > 1 && Number < 101) Console.WriteLine($"Число сгенерировано в интервале [1,100] {Number}"); // {Number} Убрать в финальной версии
    else
        Console.WriteLine("Ошибка в генерация числа");
    return Number;
}


int RequestNumber() //Запрос числа от игрока из диапазона [1,100] + Проверка-
{
    int Number = 0;
    while (true)
    {
        Console.WriteLine("Введите целочисленное число");
        if (int.TryParse((Console.ReadLine()), out int rNumber)) ;
        if (rNumber > 0)
        {
            Number = rNumber;
            break;
        }
        else Console.WriteLine("Введёное вами число не является корректным, попробуйте ещё раз");

    }
    return Number;
}
void Rules()  // Правила игры
{
    Console.WriteLine("Добро пожаловать в игру Угадай число");
    Console.WriteLine("Цель игры:Угадать число от 1 до 100 с использованеим 5 попыток");
    Console.WriteLine("Удачи!");
}


bool MoveGame(int creatNumber, int attempts)
{
    int numberOfGamer = RequestNumber();
    if (creatNumber == numberOfGamer)
    {
        Console.WriteLine("Вы угадали число!");
        return true;

    }
    else
    {
        if (attempts > 0)
        {
            if (creatNumber < numberOfGamer)
            {
                Console.WriteLine($"Ваше число больше загаданного. Осталось попыток {attempts = attempts - 1}");
            }
            else
            {
                Console.WriteLine($"Ваше число меньше загаданного. Осталось попыток {attempts = attempts - 1}");

            }
        }
        if (attempts == 0) Console.WriteLine("Попыток больше нет");
    }
    return false;
}

Rules();
Console.WriteLine();
int attempts = 5;
int a = CreatNumber();
bool result = false;
while (attempts > 0 && result == false)
{
    result = MoveGame(a, attempts);
    attempts = attempts - 1;
    if (result == true) break;
}

