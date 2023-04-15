// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели");
int number = Convert.ToInt32(Console.ReadLine());
number=-number;
bool NumberCheck(int number)
{
    if (number < 1 || number >= 8)
    {
        Console.WriteLine("такого дня нет");
        return false;
    }
    return true;

}
bool WeekDayCheck(int number)
{
    if (number > 0 && number <6)
    {   
        return false;  
    }
    return true;
}

if (NumberCheck(number))
{
    Console.WriteLine(WeekDayCheck(number)?"да":"нет");
}
