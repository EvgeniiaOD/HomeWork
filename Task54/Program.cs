// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

//       0 1 2 3          0 1 2 3 

// 0     7 4 2 1      0   1 4 7 2     4 7 2 
// 1     9 5 3 2      1   5 9 2 3
// 2     8 4 4 2      2   8 4 2 4

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
// void Swap(int coorI, int coorJ)
// {
//     int temp = 0;
//     {
//         temp = coorI;
//         coorI = coorJ;
//         coorJ = temp;
//     }
// }
int[,] SortByRow(int[,] matr)
{
    int[,] newMatr = new int[matr.GetLength(0), matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {                            // 4
        for (int j = 1; j < matr.GetLength(1); j++)
        {
            int count = 0;
            while (count < matr.GetLength(1))
            {

                if (matr[i, j - 1] < matr[i, j])
                {
                    int temp = matr[i, j - 1];
                    matr[i, j - 1] = matr[i, j];
                    matr[i, j] = temp;
                }
                count++;



                // int temp = matr[i, j - 1];
                // matr[i, j - 1] = matr[i, j];
                // matr[i, j] = temp;
                // j++;
            }
            // int max = matr[0, 0];
            // if (matr[i, j] < matr[i, j + 1])
            // if (max < matr[i, j + 1] & matr[i, j] < matr[i, j + 1])
            // {
            //     int temp = matr[i, j];
            //     matr[i, j] = matr[i, j + 1];
            //     matr[i, j + 1] = temp;
            //     // Swap(matrix[i, j], matrix[i, j + 1]);
            //     // newMatrix[i, j] = matrix[i, j];
            // }
            // j++;
        }
    }
    // return newMatrix;
    return matr;
}

int[,] matrix = CreateMatrixRndInt(4, 3, 0, 20);
PrintMatrix(matrix);
Console.WriteLine();
int[,] newMatrix = SortByRow(matrix);
// int[,] newMatrix = SortByRow(matrix);
// PrintMatrix(newMatrix);
PrintMatrix(newMatrix);