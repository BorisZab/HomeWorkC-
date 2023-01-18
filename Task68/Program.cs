int anker(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return anker(m - 1, 1);
    else 
        return anker(m - 1, anker(m, n - 1));
}
Console.Clear();
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(anker(m, n));