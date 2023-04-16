// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели");
int number = Convert.ToInt32(Console.ReadLine());
number = -number;
bool NumberCheck(int num)
{
    if (num < 1 || num >= 8)
    {
        Console.WriteLine("такого дня нет");
        return false;
    }
    return true;

}
bool WeekDayCheck(int num)
{
    if (num > 0 && num < 6)
    {
        return false;
    }
    return true;
}

if (NumberCheck(number))
{
    Console.WriteLine(WeekDayCheck(number) ? "да" : "нет");
}
