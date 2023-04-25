// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите длину массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
int total = SumDigit(array);
Console.Write($"Сумма всех элементов массива");
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.Write($"стоящих на нечетных позициях равна {total}");

int[] CreateArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10,10);
    }
    return arr;
}

int SumDigit(int[] arr)
{
        int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1) sum += arr[i];
        else sum += 0;
    }
    return sum;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}