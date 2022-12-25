void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 30);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void FindPosition(int[,] matrix, int i, int j)
{
    if (i > matrix.GetLength(0) || j > matrix.GetLength(1))
    {
        Console.WriteLine($"Позиции {i} {j} -> такой позиции в массиве нет");
        return;
    }
    else
        Console.WriteLine($"{matrix[i, j]}");
        return;
}

Console.Clear();
Console.Write("Введите размер матрицы (строк столбецов): ");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
InputMatrix(matrix);
Console.Write($"Введите позицию элемента в массиве (строка столбец): ");
int[] coordnew = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
FindPosition(matrix, coordnew[0], coordnew[1]);