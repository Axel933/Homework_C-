//14. Дано число обозначающее день недели. Выяснить является номер дня недели выходным днём
bool FindWeek(int a)
{
    if (a == 6 || a == 7) return true;
    else return false;
}
Console.WriteLine(FindWeek(6));


