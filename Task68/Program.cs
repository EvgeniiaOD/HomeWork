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

bool CheckIfNotNegative(int numM, int numN)
{
    if (numN <= 0 | numM <= 0) return false;
    return true;
}
int Accerman(int numM, int numN)
{
    if (numM == 0)
        return numN + 1;
    else
    if ((numM != 0) && (numN == 0))
        return Accerman(numM - 1, 1);
    else
        return Accerman(numM - 1, Accerman(numM, numN - 1));
}

int numberM = 3;
int numberN = 2;

if (CheckIfNotNegative(numberM, numberN)) Console.WriteLine ($"m={numberM}, n={numberN} => A(m,n) = {Accerman(numberM, numberN)}");
else Console.WriteLine("Нужны неотрицательные числа!");
