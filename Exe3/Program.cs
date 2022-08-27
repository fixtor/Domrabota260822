int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
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

void FindAverage(int[,] newArray)
{
    double tempAverage = 0;

    //int[] array = new int[j];

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        int columnCountJ = 0; // TODO посмотреть когда обнулится значение этих переменных
        int columnCountI = 0;

        {
            Console.Write($"mas = {newArray[i, columnCountJ]}");
            Console.Write($"columncount {columnCountJ}, ");
            Console.WriteLine($"av = {tempAverage}");
            tempAverage = (newArray[i, columnCountJ] + tempAverage);
            //tempAverage = tempAverage / newArray.GetLength(0);
            Console.WriteLine($"newAv = {tempAverage}");
        }

        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            //columnCountJ ++;
            //Console.Write($"columnI = {columnCountI}");
            //Console.WriteLine($" arr = {newArray[columnCountI, columnCountJ]}");

        }
    }
}

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);

PrintArray(array);
FindAverage(array);
// if (i == columnCountJ)
//         {
//             Console.WriteLine($"Columncount = {i}");
//             tempAverage += newArray[i, j];
//             Console.WriteLine($"i = {i}, j = {j}, newArray = {newArray[i, j]}");
//             Console.WriteLine(tempAverage / j);

//         }