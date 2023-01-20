// Пишем программу которая на входе принимает два числа и проверяет, является ли ПЕРВОЕ число квадратом ВТОРОВО.

Console.WriteLine("Введите первое целое число: ");
string userInput1 = Console.ReadLine() ?? "";
int number1 = int.Parse(userInput1);

Console.WriteLine("Введите второе целое число: ");
string userInput2 = Console.ReadLine() ?? "";
int number2 = int.Parse(userInput2);

int result = (int)Math.Pow(number2, 2);

if (result == number1)
{
    Console.WriteLine($"Да, число {number1} является квадратом {number2}");
}

else
{
    Console.WriteLine($"Нет, число {number1} не является квадратом {number2}");
}
