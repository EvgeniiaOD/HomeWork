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
    if (matrA.GetLength(1) != matrB.GetLength(0))
    {
        Console.WriteLine("Такие матрицы перемножить нельзя");
        return false;
    }
    Console.WriteLine("Такие матрицы перемножить можно");
    return true;
}
int[,] MultiplyMatrix(int[,] matrA, int[,] matrB)
{
    int[,] matrC = new int[matrA.GetLength(0), matrB.GetLength(1)];
    
    int num = matrA[i, j] * matrB[i, j] + matrA[i, j + 1] * matrB[i + 1, j];
    matrC[i, j] = num;

    return matrC;
}




int[,] matrixA = CreateMatrixRndInt(2, 2, 0, 10);
Console.WriteLine("Первая сходная матрица:");
PrintMatrix(matrixA);
Console.WriteLine();
int[,] matrixB = CreateMatrixRndInt(2, 2, 0, 10);
Console.WriteLine("Вторая сходная матрица:");
PrintMatrix(matrixB);
Console.WriteLine();
CheckIfCanMultiply(matrixA, matrixB);
Console.WriteLine();
Console.WriteLine("Результирующая матрица будет:");
int[,] matrixC = MultiplyMatrix(matrixA, matrixB);
PrintMatrix(matrixC);