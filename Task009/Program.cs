﻿Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 10000 || n > 99999)
{
    Console.Write("Вы ошиблись!\nВведите пятизначное число:");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n / 10000 == n % 10 && n / 1000 % 10 == n % 100 / 10)
    Console.Write("Число палиндром");
    else
    Console.Write("Число не палиндром");
    // Console.WriteLine(n % 100);