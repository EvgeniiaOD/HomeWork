﻿// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
Console.Write("Введите число: "); //предлагаем пользователю ввести число
int number = Convert.ToInt32(Console.ReadLine()); //назначаем полученный текст числом
if (number < 0)
{
    number = -number;
    }; // проверяем , положительное ли число. и если нет - меняем на положительное
if (number >= 100 && number <= 999) 
{;
Console.WriteLine(number % 10) ;
} //проверяем, трехзначное ли число введено, то есть если оно от 100 до 999 включительно
else Console.WriteLine("Вы ввели не трёхзначное число"); //если условие выше не выполнено, говорим, что введено некорректное число