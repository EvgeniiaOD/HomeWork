// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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
void PrintArray(int[] arr)
{
   for (int i = 0; i < arr.Length; i++)
   {
      if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
      else Console.Write($"{arr[i]}");
   }
}
int[] MatrixToArray(int[,] matrix)
{
   int size = matrix.Length;
   int[] array = new int[size];
   array[0] = matrix[0, 0];
   int count = 0;
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         array[count++] = matrix[i, j];
      }
   }
   return array;
}
void FindNumbers(int[] array)
{
   int number = array[0];
   int count = 1;
   for (int i = 1; i < array.Length; i++)
   {
      if (array[i]==number) count++;
      else 
      {
         Console.WriteLine($"{number} встречается {count} раз");
         number = array[i];
         count = 1;
      }
   }
   Console.WriteLine($"{number} встречается {count} раз");
}


int[,] matrix = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[] array=MatrixToArray(matrix);
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
Array.Sort(array);
PrintArray(array);
Console.WriteLine();
FindNumbers(array);