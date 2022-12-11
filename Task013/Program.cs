Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (a > 1)
{
    sum = a % 10 + sum;
    a = a / 10;
}
Console.WriteLine(sum);