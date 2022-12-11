Console.Clear();
Console.Write("Введите число a : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b : ");
int b = Convert.ToInt32(Console.ReadLine());
int i = 1;
int result = 1;
while (i <= b)
{
    result = result * a;
    i++;
}
Console.WriteLine(result);
