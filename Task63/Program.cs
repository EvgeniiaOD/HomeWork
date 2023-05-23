// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number); // 5

void NaturalNumbers(int num) // 5
{
    if(num == 0) return;
    NaturalNumbers (num - 1);
    Console.Write($"{num} ");
}