//Игра "Угадай число"

int CreatNumber() //Генерация числа от 1 до 100
{
    int Number = new Random().Next(1, 101);

    if (Number > 1 && Number < 101) Console.WriteLine($"Число сгенерировано в интервале [1,100] {Number}"); // {Number} Убрать в финальной версии
    else
        Console.WriteLine("Ошибка в генерация числа");
    return Number;
}


int RequestNumber() //Запрос числа от игрока из диапазона [1,100] + Проверка
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
void Rules()
{
    Console.WriteLine("Добро пожаловать в игру Угадай число");
    Console.WriteLine("Цель игры:Угадать число от 1 до 100 с использованеим 5 попыток");
    Console.WriteLine("Удачи!");
}

bool GameMove(int CreatNumber, int attempts)
{
    int PlayerNumber = RequestNumber();

    if (CreatNumber == PlayerNumber)
    {
        Console.WriteLine("Поздравляем, вы отгадали число");
        return true;
    }
    else
    {
        attempts = attempts - 1;
        if (attempts > 0)
        {
            if (PlayerNumber > CreatNumber)
            {
                Console.WriteLine($"Указанное число больше загаданного. Осталось {attempts} попыток");
            }
            else
            {
                Console.WriteLine($"Указанное число меньше загаданного. Осталось {attempts} попыток");
            }
            Console.WriteLine($"У вас осталось {attempts} попыток");
            return false;
        }
        else
        {
            Console.WriteLine("Попытки закончились");
            return false;
        }
    }
}

Rules();
int a = CreatNumber();
int b = RequestNumber();
int attempts = 5;

bool result=GameMove(a,5);

