//16. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool Func(bool x, bool y) 
{
    return (!(x && y) == !x || !y);
}


bool To(int a)
{
    return a == 0;
}
bool res = true;
bool Check()
{
    for (int i = 0; i <= 1; i++)
    {
        for (int j = 0; j <= 1; j++)
        {
            res = Func(To(i), To(j));
        }
    }
    return res;
}

Console.WriteLine(res);


