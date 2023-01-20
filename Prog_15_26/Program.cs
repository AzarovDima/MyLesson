/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */


int num = GetNumbetFromUser("Введите целоечисло А: ", " Ошибка ввода!");
int digNumbers = GetDigitSumNumbers(num);
Console.WriteLine($"{num} -> {digNumbers}");

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
int GetDigitSumNumbers(int number)
{
    int sum = 0;
    while (number > 0)
    {
        number = number / 10;
        sum++;
    }
    return sum;
}