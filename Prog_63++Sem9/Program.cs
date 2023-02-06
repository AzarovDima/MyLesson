/* Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */

int userNumber = GetNumbetFromUser("Введите целоечисло: ", " Ошибка ввода!");

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

Console.Write($"N = {userNumber} -> ");

string ShowLine(int start, int userNumber)
{
    if (start == userNumber) return userNumber.ToString();
    else return start + ", " + ShowLine(start + 1, userNumber);
}

Console.Write(ShowLine(1, userNumber));

// https://boosty.to/ksergeyru/posts/e70dec1b-972b-4a91-b247-06b790de97a1?share=post_link


