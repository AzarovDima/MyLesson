/* Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120 */


int num = GetNumbetFromUser("Введите целоечисло А: ", " Ошибка ввода!");
int multipNumbers = GetMultipNumbers(num);
Console.WriteLine($"{num} -> {multipNumbers}");

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
int GetMultipNumbers(int number)
{
    int mult = 1;
    for (int i = 1; i <= number; i++)
    {
        mult = mult * i;
    }
    return mult;
}