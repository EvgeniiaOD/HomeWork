﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

if (CheckIfNatural(number))
{
Console.Write ($"N = {number} -> ");
NaturalNumbers(number);
}
else
{
    Console.Write ("Вы ввели неверное число!");
}


void NaturalNumbers(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNumbers(num - 1);
}
bool CheckIfNatural (int num)
{
if (num>0) return true;
return false;
}