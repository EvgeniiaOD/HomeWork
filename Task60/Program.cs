// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

// bool RepetitiveNumberCheck(int existElement, int num) // ДА если такого числа нет !
// {
//     if (num == existElement) return false;
//     return true;
// }
bool RepetitiveNumberCheck(int[,,] matr, int num) // ДА если такого числа нет !
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                if (matr[i, j, k] == num) return false;
            }
        }
    }
    return true;
}



int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max) // заполняется нулями
{
    int[,,] matr = new int[rows, columns, depth];
    // Random rnd = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = 0;
                // int a = 0;
                // if (RepetitiveNumberCheck(matr[i, j, k], matr))
                // a= FillRnd(matr, min, max);
                // else (RepetitiveNumberCheck(matr[i, j, k], matr));
            }
        }
    }
    return matr;
}
int FillRnd(int[,,] matr, int min, int max)
{
    Random rnd = new Random();
    int num = rnd.Next(min, max + 1);
    return num;
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

int[,,] matrix = CreateMatrixRndInt(2, 2, 2, 0, 9); // пока заполнена нулями
Console.Write("Исходная матрица:"); // пока заполнена нулями
PrintMatrix(matrix); // пока заполнена нулями


int[,,] TestMAtrixFill(int[,,] matrix)
{
    int count = 0;
    while (count < matrix.Length)
    {
        int a = FillRnd(matrix, 0, 10);// получили рандомное число из указанного отрезка
                                       // while (RepetitiveNumberCheck(matrix[i, j, k], a)) // пока такого числа нет
                                       // {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    if (RepetitiveNumberCheck(matrix[i, j, k], a))
                        matrix[i, j, k] = a;
                    else count++;

                    // int a = FillRnd(matrix, 0, 10); // получили рандомное число из указанного отрезка
                    // while (RepetitiveNumberCheck(matrix, a))
                    // {
                    //     a = FillRnd(matrix, 0, 10);
                    //     RepetitiveNumberCheck(matrix, a);
                    // }
                    // matrix[i, j, k] = a;

                    // a =FillRnd(matrix, 0,10);
                    //     RepetitiveNumberCheck(matrix, a);


                    // int a = 0;
                    // if (RepetitiveNumberCheck(matr[i, j, k], matr))
                    // a= FillRnd(matr, min, max);
                    // else (RepetitiveNumberCheck(matr[i, j, k], matr));
                }
            }
        }
    }
    return matrix;
}


PrintMatrix(TestMAtrixFill(matrix)); // заполнили рандомными числами 


// if (ValidateMatrixSize(matrix))
// {
//     Console.WriteLine("Задан массив: ");
//     PrintMatrix(matrix);
// }
// else
// {
//     Console.WriteLine("Массив такого размера не заполнить неповторяющимися числами!");
// }



