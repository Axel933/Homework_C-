//Программа проверяет слово на палиндромом.
 bool func(string word)
 {
    int L = word.Length;
    for (int i = 0; i < word.Length; i++)
    {
        if (word[i] != word[word.Length - i - 1]) return false;

    }
    return true;
}
string word = "cомок";
func(word);

Console.WriteLine(func(word));


