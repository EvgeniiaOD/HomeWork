﻿// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8


int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");
int firstDigit = number / 10;
int secondDigit = number % 10; // остаток от деления на 10 - это последняя цифра числа
if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
else
{
    Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");
}


int maxDigit2 = firstDigit > secondDigit ? firstDigit : secondDigit; //другой вариант записи условия if else, где ?=тогда, :=иначе.
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit2}");


// или можно записать через метод. Только ничего не понятно!:
int maxDigit = MaxDigit(number);
int MaxDigit(int num) // num = number
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return maxDigit;
}
