Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
Console.WriteLine("третьей цифры нет");
while ( n > 999)
    { n= n / 10;
    }
Console.WriteLine($"Третье число {n%10}");