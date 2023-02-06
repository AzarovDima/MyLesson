/* Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8" */

int userNumber1 = GetNumbetFromUser("Введите 1 число: ", " Ошибка ввода!");
int userNumber2 = GetNumbetFromUser("Введите 2 число: ", " Ошибка ввода!");
int GetNumbetFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

Console.Write($"M={userNumber1}; N={userNumber2} -> ");

string ShowLine(int start, int end)
{
    if (start == end) return end.ToString();
    else return start + ", " + ShowLine(start + 1, end);
}

if (userNumber1 < userNumber2) Console.Write(ShowLine(userNumber1, userNumber2));
else Console.Write(ShowLine(userNumber2, userNumber1));