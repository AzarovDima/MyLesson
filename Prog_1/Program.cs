// Задача: Возвести любое целое число в квадрат.

Console.Write("Введите целое число: ");
string userInput = Console.ReadLine() ?? "";
int number = int.Parse(userInput);
double result = Math.Pow(number, 2);

Console.WriteLine($"Число в квадрате {number} равно {result}");
