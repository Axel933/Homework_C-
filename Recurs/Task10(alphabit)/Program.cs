//В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
//Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита

int k = 1; //нумерация кол-ва слов

void ShowNumber(string text, char[] word, int length = 0) // text-алфавит
                                                          // word - полученное слово
                                                          // length - длина слов
{
    if (length == word.Length) // условие выхода из цикла(длина слова соответсвтует длине требуемого)
    {
        Console.WriteLine($"{k++} {new String(word)}");
        return;
    }
    for (int i = 0; i < text.Length; i++) //цикл по длине алфавита
    {
        word[length] = text[i];           // Кажому номеру присваиваем свою букву
        ShowNumber(text, word, length + 1);
    }
}
ShowNumber("аисв", new char[2]);


