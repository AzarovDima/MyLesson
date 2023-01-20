/* Задача 18: Напишите программу, которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой четверти (x и y).
 */

Console.Clear();
Console.Write("Введите номер четверти от 1 до 4 в системе координат: ");
int input = int.Parse(Console.ReadLine() ?? "");

if (input == 1)
{
    Console.WriteLine("Координаты Х>0 и Y>0");
}
else if (input == 2)
{
    Console.WriteLine("Координаты Х<0 и Y>0");
}
else if (input == 3)
{
    Console.WriteLine("Координаты Х<0 и Y<0");
}
else if (input == 4)
{
    Console.WriteLine("Координаты Х>0 и Y<0");
}
else
{
    Console.WriteLine("Четверти нет");
}
