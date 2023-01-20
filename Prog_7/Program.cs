/* 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
 */

Console.WriteLine("Введите первое число: ");
string input = Console.ReadLine() ?? "";
int number = int.Parse(input);


if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"{number} -> да");
}
else
{
    Console.WriteLine($"{number} -> нет");
}
