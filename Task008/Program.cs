Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int maxFirst = n, maxSecond = -1;
while (n != 0)
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n > maxFirst)
    {
        maxSecond = maxFirst;
        maxFirst = n;
    }
    else if (n > maxSecond)
        maxSecond = n;
}
Console.WriteLine(maxSecond);
