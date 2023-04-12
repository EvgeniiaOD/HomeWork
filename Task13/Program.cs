// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Задайте число:");
int number = Convert.ToInt32 (Console.ReadLine());

if (number>=100)
{
   Console.WriteLine("третья цифра есть");
}
else
{
    Console.WriteLine("третьей цифры нет");
}