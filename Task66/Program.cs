// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите целое положительное число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNaturalNumbers(int numM, int numN) // если М меньше N
{
    if (numM == numN) return numN;
    return numM + SumNaturalNumbers(numM + 1, numN);
}
int SumNaturalNumbers2(int numM, int numN) // если M больше N
{
    if (numM == numN) return numN; // 8
    return numM + SumNaturalNumbers2(numM - 1, numN);
}

if (numberM < numberN) Console.WriteLine(SumNaturalNumbers(numberM, numberN));
else Console.WriteLine(SumNaturalNumbers2(numberM, numberN));