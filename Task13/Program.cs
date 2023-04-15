// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Задайте число:");
int number = Convert.ToInt32(Console.ReadLine());

// не через метод: 
if (number<100)
{
    Console.WriteLine("третьей цифры нет");    
}
else
{
    while (number>999)
{
    number=number/10;
}
Console.WriteLine(number%10);
}

// через метод: 
bool CheckNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("третьей цифры нет");
        return false;
    }
    return true;
}

int ThirdDigit(int number)
{
    while (number > 999)
    {
        number = number / 10;
    }
    return number % 10;
}

if (CheckNumber(number))
{
    Console.WriteLine (ThirdDigit(number));
}
