// Задача 22: Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.


void TableSquare(int num)
{
    int count = 1; while (count <= num)
    {
        Console.WriteLine($"{count}  {count * count}");
        count += 1;
    }
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine()); TableSquare(number);

// или

void TableAllSquares(int num)
{
    int index = 1;
    while (index <= num)
    {
        Console.WriteLine($"{index,3}  {index * index,4}"); index++;
    }
}
Console.WriteLine("Please enter your number: "); int number = Convert.ToInt32(Console.ReadLine()); TableAllSquares(number);
