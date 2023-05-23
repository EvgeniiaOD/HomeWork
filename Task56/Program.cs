// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matr = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matr;
}
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],5} ");
        }
        Console.WriteLine();
    }
}
bool CheckIfSquare(int[,] matr) 
{
    if (matr.GetLength(0) == matr.GetLength(1)) return true;
    else
        return false;
}
int[] FindSumByRows(int[,] matr)
{
    int[] array = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }
        array[i] = sum;
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
}
int FindRowNumber(int[] array)
{
    int minNum = array[0];
    int rowNum = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (minNum > array[i])
        {
            minNum = array[i];
            rowNum = i + 1;
        }
    }
    return rowNum;
}


int[,] matrix = CreateMatrixRndInt(4, 4, 0, 20);
if (CheckIfSquare(matrix))
{
    Console.WriteLine("Задан массив: ");
    PrintMatrix(matrix);
    Console.WriteLine();
    int[] sumByRows = FindSumByRows(matrix);
    Console.WriteLine("Сумма каждой строки равна:");
    PrintArray(sumByRows);
    Console.WriteLine();
    Console.WriteLine();
    int smallestNumberRow = FindRowNumber(sumByRows);
    Console.WriteLine($"Номер строки с наименьшей суммой элементов -> {smallestNumberRow} строка");
}
else
{
Console.WriteLine("Массив не является прямоугольным");
}