// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

bool CheckIfNotNegative(int numN, int numM)
{
    if (numN <= 0 | numM <= 0) return false;
    return true;
}
int Accerman(int numN, int numM)
{
    if (numN == 0)
        return numM + 1;
    else
    if ((numN != 0) && (numM == 0))
        return Accerman(numN - 1, 1);
    else
        return Accerman(numN - 1, Accerman(numN, numM - 1));
}

int numberN = 3;
int numberM = 2;

if (CheckIfNotNegative(numberN, numberM)) Console.WriteLine (Accerman(numberN, numberM));
else Console.WriteLine("Нужны неотрицательные числа!");


