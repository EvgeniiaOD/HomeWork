// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

void NumberToCube(int num)
{
    int count = 1; while (count <= num)
    {
        Console.WriteLine($"{count,4} | {count * count * count,4}");
        count++;
    }
}

NumberToCube(number);
