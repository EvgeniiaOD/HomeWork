// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1



Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
// {
//     int secondDigit = number / 10;
//     int firstDigit = number / 100;
//     int newNumber = firstDigit * 10 - secondDigit;
//     newNumber = -newNumber;
//     Console.WriteLine($"средняя цифра числа -> {newNumber}");
// }

// или через метод:
{
    int SecondDigit(int number)
    {
        int secondDigit = number / 10;
        int firstDigit = number / 100;
        int midDigit = firstDigit * 10 - secondDigit;
        midDigit = -midDigit;
        return midDigit;
    }
    int newNumber = SecondDigit(number);
    Console.WriteLine($"вторая цифра числа -> {newNumber}");
}

else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}