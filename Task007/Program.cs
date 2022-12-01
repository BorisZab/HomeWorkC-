Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
    Console.Write("Вы ошиблись!\nВведите день недели:");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 6 || n == 7)
Console.WriteLine("yes");
else
Console.WriteLine("no");