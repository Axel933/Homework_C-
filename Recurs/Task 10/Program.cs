//В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
//Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита

int k = 1; // Счётчик для кол-ва слов

void ShowWords(string text, char[] letter, int lenght = 0) // text - набор буквы алфавиа
                                                           //letter - кол-во букв в слове, lenght - длина получаемых слов
{
    if (lenght == letter.Length)
    {
        Console.WriteLine($"{k++} {new String(letter)}");
        return;
    }
    for (int i = 0; i < text.Length; i++)
    {
        letter[lenght] = text[i];
        ShowWords(text, letter, lenght + 1);
    }
}

ShowWords("аисв", new char[2]);

