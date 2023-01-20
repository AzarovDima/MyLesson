/* 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
 */
 
Console.WriteLine("Введите первое число 1: ");
string input1 = Console.ReadLine() ?? "";
int number1 = int.Parse(input1);

Console.WriteLine("Введите второе число 2: ");
string input2 = Console.ReadLine() ?? "";
int number2 = int.Parse(input2);

if (number2 % number1 == 0)
{
    Console.WriteLine($"{number2}, {number1} -> кратно");
}
else if (number2 % number1 != 0)
{
    Console.WriteLine($"{number2}, {number1} -> не кратно, остаток {number2 % number1}");
}

