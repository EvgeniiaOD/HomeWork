// 14.Напишите программу, которая принимает на 
// вход число и проверяет, кратно ли оно 
// одновременно 7 и 23. 
// 14 -> нет 
// 46 -> нет 
// 161 -> да 

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = MultipleTwoDigits(number, 5, 10);
Console.WriteLine(result ? "да" : "нет");

bool MultipleTwoDigits(int num, int num1, int num2)
{
    return num % num1 == 0 && num % num2 == 0;
}

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = IsSquare(number1, number2);
Console.WriteLine(result ? "да" : "нет");
bool IsSquare(int num1, int num2)
{
    return (num1 == num2 * num2) || (num2 == num1 * num1);
}
