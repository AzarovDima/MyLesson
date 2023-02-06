/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */


int userNumberA = GetNumbetFromUser("Введите натуральное число A: ", " Ошибка ввода!");
int userNumberB = GetNumbetFromUser("Введите натуральное число B: ", " Ошибка ввода!");

int result = Recurse(userNumberA, userNumberB);

Console.Write($"A={userNumberA}; B={userNumberB} -> {result}");

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
int Recurse(int userNumberA, int userNumberB)
{
    int result = 1;
    if (userNumberB == 0) return 1;
    if (userNumberA == 0) return 0;
    else
    {
        result = userNumberA * Recurse(userNumberA, userNumberB - 1);
        return result;
    }
}


