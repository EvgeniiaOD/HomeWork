// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArrayRndDouble(size, -10, 10); // взяла вещественные числа в небольшом отрезке от -10 до 10
double biggestNumber = MaxNumber(array);
Math.Round(biggestNumber, 1, MidpointRounding.ToZero);
double smallestNumber = MinNumber(array);
Math.Round(smallestNumber, 1, MidpointRounding.ToZero);
double result = biggestNumber - smallestNumber;
double final = Math.Round(result, 1, MidpointRounding.ToZero);
Console.Write("[");
PrintArray(array);
Console.Write("] -> ");
Console.WriteLine();
Console.WriteLine($"разница между максимальным и минимальным значениями -> {final}");



double MaxNumber(double[] arr)
{
    double maxNum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (maxNum < arr[i]) maxNum = arr[i];
    }
    return maxNum;
}

double MinNumber(double[] arr)
{
    double minNum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (minNum > arr[i]) minNum = arr[i];
    }
    return minNum;
}

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        double round = Math.Round(arr[i], 1);
        if (i < arr.Length - 1) Console.Write($"{round}  ");
        else Console.Write($"{round}");
    }
}