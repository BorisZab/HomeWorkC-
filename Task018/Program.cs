Console.Clear();
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int Findover0(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        count ++;
    }
    return count;
}
Console.WriteLine("Введите кол-во чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Findover0(array);
Console.WriteLine($"Чисел больше 0:  {Findover0(array)}");





