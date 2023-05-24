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
    return matrC;
}
int[] MatrixToArrayByRows(int[,] matr)
{
    int size = matr.Length;
    int[] array = new int[size];
    array[0] = matr[0, 0];
    int count = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            array[count++] = matr[i, j];
        }
    }
    return array;
}
int[] MatrixToArrayByColumns(int[,] matr)
{
    int size = matr.Length;
    int[] array = new int[size];
    array[0] = matr[0, 0];
    int count = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            array[count++] = matr[i, j];
        }
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

int[,] Fill(int[,]matr, int [,]matrA, int[,]matrB)
{
   int[,] matrC = new int[matrA.GetLength(0), matrB.GetLength(1)];
int i =0; int j=0; int r=0; int c=0; int m=0; int n=0;
int sum = 0;
sum += matrA[i,j]*matrB[r,c]; j++; r++;
// ниже используем способ зполнения новой матрицы построчно новыми значениями :
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         matrix[i, j] = sum;
      }
   }
   return matrC;
}
// int[,] FillNewMatrix(int[,] matr, int[] arrA, int[] arrB)
// {
//     int k = 0;
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = arrA[k] * arrB[k];
//         }
//         k++;
//     }
//     return matr;
// }



int[,] matrixA = CreateMatrixRndInt(2, 2, 0, 10);
Console.WriteLine("Первая сходная матрица:");
PrintMatrix(matrixA);
Console.WriteLine();

int[,] matrixB = CreateMatrixRndInt(2, 2, 0, 10);
Console.WriteLine("Вторая сходная матрица:");
PrintMatrix(matrixB);
Console.WriteLine();

int[] arrayA = MatrixToArrayByRows(matrixA);
PrintArray(arrayA);
Console.WriteLine();
int[] arrayB = MatrixToArrayByColumns(matrixB);
PrintArray(arrayB);
Console.WriteLine();


if (CheckIfCanMultiply(matrixA, matrixB))
{
    int[,] matrC = MultiplyMatrix(matrixA, matrixB);
    PrintMatrix(matrC);
}
else
{
    Console.WriteLine("Такие матрицы перемножить нельзя");
};

// Console.WriteLine("Результирующая матрица будет:");
// int[,] matrixC = MultiplyMatrix(matrixA, matrixB);
// PrintMatrix(matrixC);