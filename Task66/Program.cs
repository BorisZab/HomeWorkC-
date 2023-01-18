int sum(int n, int m)
{
    if (m <= n) 
        return n;
    return (sum(n , m-1)) + m;
}
Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(sum(n, m));