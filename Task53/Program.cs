// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine();
    }
}
void SwapRows(int[,] matrix)
{
    int FirstRow = 0;
    int LastRow = matrix.GetLength(0) - 1;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[FirstRow, j];
        matrix[FirstRow, j] = matrix[LastRow, j];
        matrix[LastRow, j] = temp;
    }
}

int[,] matrix = CreateMatrixRndInt(4, 3, -10, 10);
PrintMatrix(matrix);
Console.WriteLine();
SwapRows(matrix);
PrintMatrix(matrix);


// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//    int[,] matrix = new int[rows, columns];
//    Random rnd = new Random();

//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          matrix[i, j] = rnd.Next(min, max + 1);
//       }
//    }
//    return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          Console.Write($"{matrix[i, j],5} ");
//       }
//       Console.WriteLine();
//    }
// }

// void SwapPosition(int[,] matrix)
// {
//    int lastPosition = matrix.GetLength(0) - 1;
//    int firstPosition = 0;
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//       int temp = matrix[firstPosition, j];
//       matrix[firstPosition, j] = matrix[lastPosition, j];
//       matrix[lastPosition, j] = temp;
//    }
// }

// // 6 1 2 3  2
// // 1 2 3 4  1
// // 2 3 4 5  6

// int[,] matrix = CreateMatrixRndInt(4, 3, -10, 10);
// PrintMatrix(matrix);
// Console.WriteLine();
// SwapPosition(matrix);
// PrintMatrix(matrix);