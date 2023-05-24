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
            Console.Write($"{matr[i, j],3} ");
        }
        Console.WriteLine();
    }
}
bool CheckIfCanMultiply(int[,] matrA, int[,] matrB)
{
    return matrA.GetLength(1) == matrB.GetLength(0) ? true : false;
}
int[,] MultiplyMatrix(int[,] matrA, int[,] matrB)
{
    int[,] matrC = new int[matrA.GetLength(0), matrB.GetLength(1)];
    int i = 0;
    for (int m = 0; m < matrC.GetLength(0); m++)
    {
        int c = 0;
        for (int n = 0; n < matrC.GetLength(1); n++)
        {
            int sum = 0;
            int j = 0;
            int r = 0;
            while (j < matrA.GetLength(1) & r < matrB.GetLength(0))
            {
                sum += matrA[i, j] * matrB[r, c];
                j++;
                r++;
            }
            matrC[m, n] = sum;
            c++;
        }
        i++;
    }
    return matrC;
}

int[,] matrixA = CreateMatrixRndInt(2, 2, 0, 5);
Console.WriteLine("Первая сходная матрица:");
PrintMatrix(matrixA);
Console.WriteLine();
int[,] matrixB = CreateMatrixRndInt(2, 2, 0, 5);
Console.WriteLine("Вторая сходная матрица:");
PrintMatrix(matrixB);
Console.WriteLine();
if (CheckIfCanMultiply(matrixA, matrixB))
{
    int[,] matrC = MultiplyMatrix(matrixA, matrixB);
    Console.WriteLine("Результирующая матрица будет:");
    PrintMatrix(matrC);
}
else
{
    Console.WriteLine("Такие матрицы перемножить нельзя");
}