// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine ("Введите число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите, в какую степень его возвести:");
int numberB = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int numA, int numB)
{
    int exponent = 1;
    for (int i = 0; i < numB; i++)
    {
            exponent *= numA;      
    }
    return exponent;
}

Console.WriteLine($"если число {numberA} возвести в степень {numberB}, то получится {Exponentiation(numberA,numberB)}");