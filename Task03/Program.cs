// // 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите число:");
int date = Convert.ToInt32(Console.ReadLine());

if (date == 1)
{
    Console.WriteLine("Понедельник");
}
else if (date == 2)
{
    Console.WriteLine("Вторник");
}
else if (date == 3)
{
    Console.WriteLine("Среда");
}
else if (date == 4)
{
    Console.WriteLine("Четверг");
}
else if (date == 5)
{
    Console.WriteLine("Пятница");
}
else if (date == 6)
{
    Console.WriteLine("Суббота");
}
else if (date == 7)
{
    Console.WriteLine("Воскресенье");
}
else {
    Console.WriteLine("Такого дня нет!");
}