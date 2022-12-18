// Console.Clear();
// Console.WriteLine("Введите значение b1:");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите значение k1:");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите значение b2:");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите значение k2:");
// double k2 = Convert.ToDouble(Console.ReadLine());
// // double y = k1*x+b1 = k2-x+b2, x= (y-b1)/k1=(y-b2)/k2;
// for (double x = -100; x <= 100; x++)
// {
//     for (double y = -100; y <= 100; y++)
//     {
//         if (y == k1 * x + b1 && y == k2 * x + b2)
//             Console.WriteLine($"X = {x}, Y = {y}");
//     }
// }
// // double x= (y-b1)/k1=(y-b2)/k2;
// // Console.WriteLine(y,x);
class Program
{
static void Main()
{
double x, y, b1, k1, b2, k2;
Console.WriteLine("Введите b1");
b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1");
k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2");
b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2");
k2 = Convert.ToDouble(Console.ReadLine());
x = (y - b1) / k1;
y = k1 * x + b1;
Console.WriteLine("1)Игрек равен. " + +y);
Console.WriteLine("2)Икс равен. " + +x);
Console.Read();
}
}