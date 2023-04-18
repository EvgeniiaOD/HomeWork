// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int [] array = new int [8];

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2); 
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
}

Console.WriteLine("Please enter array length: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(size);
PrintArray(arr);

// второй вариант: 

// Console.WriteLine("Введите длину массива");
// int lenghtArray = Convert.ToInt32(Console.ReadLine());

// int[] arr = CreateArray(lenghtArray);
// PrintArray(arr);

// int[] CreateArray(int size)
// {
//     int[] array = new int [size];
//     Random random = new Random(); // оптимизация объекта Random (var - объект неявной типизации)
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(0, 2);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }