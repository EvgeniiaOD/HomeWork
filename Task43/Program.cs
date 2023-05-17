// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// x=(b2-b1)/(k1-k2)
// y=k1*(b2-b1)/(k1-k2)+b1

Console.WriteLine("Введите знакчение b1: ");
double numb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите знакчение k1: ");
double numk1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите знакчение b2: ");
double numb2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите знакчение k2: ");
double numk2 = Convert.ToInt32(Console.ReadLine());

double FindX(double b1, double k1, double b2, double k2)
{
    double x = 0;
    if (x >= 0) 
    {
        x = (b2 - b1) / (k1 - k2);
    }
    return x;
    //или можно сократить эту часть кода до одной строки return (b2 - b1) / (k1 - k2);
}

double FindY(double b1, double k1, double b2, double k2)
{
    double y = 0;
    if (y >= 0) 
    {
        y = k1 * (b2 - b1) / (k1 - k2) + b1;
    }
    return y;
    // или можно сократить строку до return k1 * (b2 - b1) / (k1 - k2) + b1;
}

double resultX = FindX(numb1, numk1, numb2, numk2);
double resultXRound = Math.Round(resultX, 2);
double resultY = FindY(numb1, numk1, numb2, numk2);
double resultYRound = Math.Round(resultY, 2);

Console.WriteLine($"({resultXRound}; {resultYRound})");



