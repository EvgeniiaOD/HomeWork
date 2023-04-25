// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите целое положительное число :");
int number = Convert.ToInt32(Console.ReadLine());

if (number >0)
{
int binResult = DecToBin(number);
Console.WriteLine(binResult);
}
int DecToBin(int num)
{
    int count = 1;
    int result = 0;
    while (num > 0)
    {
        result += num % 2 * count;
        num /= 2;
        count = count * 10;
    }
    return result;
}


// Console.Write("Введите целое положительное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number > 0)
// {
//     int resultBin = DecToBin(number);
//     Console.WriteLine(resultBin);
// }
// else Console.WriteLine("вы ввели неверное число");

// int DecToBin(int num)
// {
//     int count = 1;
//     int result = 0;
//     while (num > 0)
//     {
//         result += num % 2 * count;
//         num /= 2;
//         count = count * 10;
//     }
//     return result;
// }