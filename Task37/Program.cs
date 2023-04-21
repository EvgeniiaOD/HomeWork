// // Задача 37: Найдите произведение пар чисел в одномерном массиве.
// // Парой считаем первый и последний элемент, второй и предпоследний
// // и т.д. Результат запишите в новом массиве.
// // [1 2 3 4 5] -> 5 8 3
// // [6 7 3 6] -> 36 21

// 1. запросить у пользователя строку с числами

// 2. разбить строку на отдельные слова (числа)

// 3.перевести разбитые слова в числа

// 4. пройтись в цикле от 0 до length / 2 + 1 (до половины массива)

// 5. умножить числа одинаково удаленных от начала и конца списка между собой arr[i] * arr[len(arr) - i - 1]

// 6. занести полученный результат в массив

// 7. вывести массив на экран

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int [size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
       arr[i] = rnd.Next(min, max + 1); 
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}


int[] CreateNewArray(int[] arr)
{
   
    int length = arr.Length /2; 
    if (arr.Length % 2 == 1) length += 1;
     
    int[] newArr = new int [length];
    for (int i = 0; i < length; i++)
    {
        newArr[i]= arr[i]* arr[arr.Length -1 -i];
    }
    if (arr.Length % 2 == 1) newArr[length -1] = arr[arr.Length /2 ];
    return newArr;
    
}

int[] array = CreateArrayRndInt(5, 1, 10);
Console.Write("[");
PrintArray(array);
Console.Write("] -> ");
int[] newArray = CreateNewArray(array);
Console.Write("[");
PrintArray(newArray);
Console.Write("]");