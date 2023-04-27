// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите длину массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
Console.Write("[");
PrintArray(array);
Console.Write("] -> ");

int result = CheckEvenNumbers(array);
Console.WriteLine(result);

int[] CreateArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 999);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

int CheckEvenNumbers(int[] arr)
{
    int num = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) num += 1;
    }
    return num;
}

// num=num+arr[i]/arr[i];