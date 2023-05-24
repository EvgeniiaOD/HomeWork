// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

// int RepetitiveNumberCheck(int num, int[,,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             for (int k = 0; k < matr.GetLength(2); k++)
//             {
//                 if (num != matr[i, j, k]) return num ; 
//                 else RepetitiveNumberCheck (num, matr);          
//             }
//         }
//     }
//     return num;
// }
int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matr = new int[rows, columns, depth];
    Random rnd = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                int temp = rnd.Next(min, max + 1);
                matr[i, j, k] = RepetitiveNumberCheck(temp,matr);
            }
        }
    }
    return matr;
}
void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k],5} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
bool ValidateMatrixSize(int[,,] matr)
{
    if (matr.Length > matr.GetLength(0) * matr.GetLength(1) * matr.GetLength(2)) return false;
    return true;
}

int[,,] matrix = CreateMatrixRndInt(2, 2, 2, 0, 8);
if (ValidateMatrixSize(matrix))
{
    Console.WriteLine("Задан массив: ");
    PrintMatrix(matrix);
}
else
{
    Console.WriteLine("Массив такого размера не заполнить неповторяющимися числами!");
}
