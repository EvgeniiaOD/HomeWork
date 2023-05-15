// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


Console.Write("Введите количество элементов массива: ");
int elementsCount = Convert.ToInt32(Console.ReadLine());
int[] array = new int[elementsCount];

for (int i = 0; i < array.Length; i++)
{
    if (i < array.Length - 1) Console.Write("Введите число: ");
    else Console.Write("Введите последнее число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    array[i] = number;
}

int totalPositiveNumbers = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) totalPositiveNumbers++;
    else totalPositiveNumbers += 0;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

PrintArray(array);
Console.Write ($" -> {totalPositiveNumbers}");
