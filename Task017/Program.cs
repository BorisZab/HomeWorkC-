void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 10);
}

int FindMax(int[] array)
{
    int max = 0;
    int min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        if (array[i] < min)
            min = array[i];
    }
    return max;
    return min;
}
int FindMin(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] < min)
            min = array[i];
    }
    return min;
}

Console.Clear();
Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine("Разница между мактсмальным и минимальным: ");
Console.WriteLine(FindMax(array) - FindMin(array));

