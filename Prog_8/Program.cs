/* 16.Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
 */

Console.Write("Введите ПЕРВОЕ число: ");
string userInput1 = Console.ReadLine() ?? "";
int number1 = int.Parse(userInput1);

Console.Write("Введите ВТОРОЕ число: ");
int number2 = int.Parse(Console.ReadLine() ?? "");

if ((int)Math.Pow(number1, 2) == number2)
{
    Console.WriteLine($"{number1}, {number2} ---> ДА");
}
else if ((int)Math.Pow(number2, 2) == number1)
{
    Console.WriteLine($"{number1}, {number2} ---> ДА");
}
else
    Console.WriteLine($"{number1}, {number2} ---> НЕТ");