// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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
// int SumMain(int[,] matrix)
// {
//    int sum = 0;
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       int j = i;
//       sum += matrix[i, j];
//    }
//    return sum;
// }
// // еще вариант:

// int EvenElements(int[,] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i ++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j ++)
//         {
//             if (i == j)
//             sum += matrix[i,j]; 
//         }
//     }
//     return sum;

// }

// оптимальный вариант: 

int SumMain(int[,] matrix)
{
   int sum = 0;
   int a = matrix.GetLength(0);
   if(a>matrix.GetLength(1)) a = matrix.GetLength(1);
   for (int i = 0; i < a; i++)
   {
      sum += matrix[i,i];
   }
   return sum;
}
int[,] matrix = CreateMatrixRndInt(4, 3, -10, 10);
PrintMatrix(matrix);
Console.WriteLine();
int sumMain = SumMain(matrix);
Console.WriteLine(sumMain);

// int[,] matrix = CreateMatrixRndInt(3, 4, -10, 10);
// PrintMatrix(matrix);
// Console.WriteLine();
// int sumMain = SumMain(matrix);
// Console.WriteLine(sumMain);

//  еще вариант: 

// int SumDiag(int[,] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
//     {
//         sum += matrix[i,i];
//     }
//     return sum;
// }
