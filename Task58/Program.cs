// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            Console.Write($"{matr[i, j],2} ");
        }
        Console.WriteLine();
    }
}
bool CheckIfCanMultiply(int[,] matrA, int[,] matrB)
{
    return matrA.GetLength(1) == matrB.GetLength(0) ? true : false;
    // {
    // Console.WriteLine("Такие матрицы перемножить нельзя");
    // return true;
    // }
    // Console.WriteLine("Такие матрицы перемножить можно");
    // else return false;
}
int[,] MultiplyMatrix(int[,] matrA, int[,] matrB)
{
    int[,] matrC = new int[matrA.GetLength(0), matrB.GetLength(1)];
    for (int i = matrB.GetLength(0)-1; i >= 0; i--)
    {
        int num = 0;
        for (int j = matrA.GetLength(1)-1; j >= 0; j--)
        {
            num = matrA[i-1, j ] * matrB[i-1, j ] + matrA[i , j ] * matrB[i , j ];
        }
        matrC[matrA.GetLength(0), matrB.GetLength(1)] = num;
    }
    // for (int i = 0; i < matrC.GetLength(0); i++)
    // {
    //     for (int j = 0; j < matrC.GetLength(1); j++)
    //     {
    //         int num = matrA[i, j] * matrB[i, j] + matrA[i, j + 1] * matrB[i + 1, j];
    //         matrC[i, j] = num;
    //     }
    // }
    // int num = matrA[i, j] * matrB[i, j] + matrA[i, j + 1] * matrB[i + 1, j];
    // matrC[i, j] = num;
    return matrC;
}

// int[,] FillUpNewMatrix(int[,] matrC, int[,] matrA, int[,] matrB)
// {
//     // for (int i = 0; i < matrC.GetLength(0); i++)
//     // {
//     //     for (int j = 0; j < matrC.GetLength(1); j++)
//     //     {
//     matrC[i, j] = matrA[i, j] * matrB[i, j] + matrA[i, j + 1] * matrB[i + 1, j];
//     matrC[i, j + 1] = matrA[i, j] * matrB[i + 1, j] + matrA[i, j + 1] * matrB[i + 1, j + 1];
//     matrC[i + 1, j] = matrA[i, j + 1] * matrB[i, j] + matrA[i + 1, j + 1] * matrB[i + 1, j];
//     matrC[i + 1, j + 1] = matrA[i, j + 1] * matrB[i, j + 1] + matrA[i + 1, j + 1] * matrB[i + 1, j + 1];
//     //     }
//     // }
//     return matrC;
// }


int[,] matrixA = CreateMatrixRndInt(2, 2, 0, 10);
Console.WriteLine("Первая сходная матрица:");
PrintMatrix(matrixA);
Console.WriteLine();
int[,] matrixB = CreateMatrixRndInt(2, 2, 0, 10);
Console.WriteLine("Вторая сходная матрица:");
PrintMatrix(matrixB);
Console.WriteLine();

if (CheckIfCanMultiply(matrixA, matrixB))
{
    // int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    // for (int i = matrixB.GetLength(0); i >= 0; i--)
    // {
    //     int num = 0;
    //     for (int j = matrixA.GetLength(1); j >= 0; j--)
    //     {
    //         num = matrixA[i, j + 1] * matrixB[i, j + 1] + matrixA[i + 1, j + 1] * matrixB[i + 1, j + 1];
    //     }
    //     matrixC[matrixA.GetLength(0), matrixB.GetLength(1)] = num;
    // }


    Console.WriteLine("Результирующая матрица будет:");
    int[,] matrixC = MultiplyMatrix(matrixA, matrixB);
    // matrixC[matrixA.GetLength(1), matrixB.GetLength(0)] = matrixA[i, j] * matrixB[i, j] + matrixA[i, j + 1] * matrixB[i + 1, j];
    // matrixC[i, j + 1] = matrixA[i, j] * matrixB[i + 1, j] + matrixA[i, j + 1] * matrixB[i + 1, j + 1];
    // matrixC[i + 1, j] = matrixA[i, j + 1] * matrixB[i, j] + matrixA[i + 1, j + 1] * matrixB[i + 1, j];
    // matrixC[i + 1, j + 1] = matrixA[i, j + 1] * matrixB[i, j + 1] + matrixA[i + 1, j + 1] * matrixB[i + 1, j + 1];
    PrintMatrix(matrixC);
}
else
{
    Console.WriteLine("Такие матрицы перемножить нельзя");
}

// Console.WriteLine("Результирующая матрица будет:");
// int[,] matrixC = MultiplyMatrix(matrixA, matrixB);
// PrintMatrix(matrixC);