// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateTableRndDoub(int rows, int columns)
{
    double[,] table = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = Math.Round(rnd.Next(-100, 100) * 0.1, 1);
        }
    }
    return table;
}

void PrintTable(double[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write($"{table[i, j],5} ");
        }
        Console.WriteLine();
    }
}

double[,] matrix = CreateTableRndDoub(3, 4);

PrintTable(matrix);
