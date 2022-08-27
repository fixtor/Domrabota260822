// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int [,] array = new int [,] { {1,4,7,2}, {5,9,2,3}, {8,4,2,4} };

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
            Console.Write($"{inArray[i, j]} ");
        Console.WriteLine();
    }
}

void FindElementInArray(int[,] inArray, int rowPos, int columnPos)
{
    if (rowPos < inArray.GetLength(0) && columnPos < inArray.GetLength(1))
    {
        Console.Write($"Введенная вами позиция в массиве {rowPos} строка и {columnPos} столбец- {inArray[rowPos,columnPos]}");
        Console.WriteLine();
    }
    else
    {
        Console.Write("Числа с таким индексом в массиве нет!");
    }
}

Console.Write("Введите номер строки массива: ");
int positionInRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца массива: ");
int positionInColumns = Convert.ToInt32(Console.ReadLine());
PrintArray(array);
FindElementInArray(array, positionInRow, positionInColumns);