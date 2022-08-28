int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            result[i, j] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
            Console.Write($"{inArray[i, j]} ");
        Console.WriteLine();
    }
}

void FindAverage(int[,] newArray, int column)
{
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < newArray.GetLength(0); i++)
            average = average + newArray[i, j];
        average = average / column;
        Console.WriteLine($"Среднее столбца {j} = {average}");
    }
}

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);

PrintArray(array);
FindAverage(array, columns);
