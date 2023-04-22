// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


// Console.WriteLine("Введите длинну массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(8);
Console.Write("[");
PrintArray(array);
Console.Write("]");

int[] CreateArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
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

// int[] array = new int [8];
// CreateArray(array);
// PrintArray(array);
// Console.Write("\b\b"); удаление последние пару чисел 
// Console.Write(" - > [");