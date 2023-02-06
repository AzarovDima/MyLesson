/* Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */


int userNumber = GetNumbetFromUser("Введите натуральное число ", " Ошибка ввода!");
int result = Recurse(userNumber);

Console.Write($"{userNumber} -> {result}");

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
int Recurse(int userNumber)
{
    if (userNumber == 0) return 0;
    else
    {
        return userNumber % 10 + Recurse(userNumber / 10);
    }
}
