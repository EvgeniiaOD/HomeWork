﻿// 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"
Console.WriteLine("Введите чило:"); //призыв пользователя совершить действие
int numberA = Convert.ToInt32(Console.ReadLine()); //говорим, что записываем число, а не строку
int numberB = -numberA; //задаем переменной начальное значение, согласно условию задачи 
while (numberB<=numberA) // пока выполняется условие, что начальное значение меньше или равно заданному пользователем числу
{
    Console.Write(numberB+" "); // консоль будет выводить числа, начиная с начального + ставить пробел после него
    numberB++; //счетчик, прибавляющий 1 к предыдущему значению??
}


