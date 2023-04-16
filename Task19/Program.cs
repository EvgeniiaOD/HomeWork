// Задача 19
// Напишите программу, которая 1. принимает на вход пятизначное число и 2.проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

bool FiveDigitsCheck(int num)
{
    if (num > 9999 && num <= 99999) return true;
    return false;
}
bool PolindromCheck(int num)
{
    int firstDigit = num / 10000;
    int secondDigit = num / 1000 % 10;
    int fourtDigit = num / 10 % 10;
    int fifthDigit = num % 10;
    if (firstDigit == fifthDigit && secondDigit == fourtDigit) return true;
    return false;
}

bool check = FiveDigitsCheck(number);
bool polindrom = PolindromCheck(number);
bool result = check ? polindrom : false;
Console.WriteLine(result ? "да" : "нет");


