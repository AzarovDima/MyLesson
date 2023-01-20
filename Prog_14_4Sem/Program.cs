/* Демонстрация решения
Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А	4 -> 10 (1+2+3+4=10)	7-> 28     8-> 36 */
int num = GetNumbetFromUser("Введите целоечисло А: ", " Ошибка ввода!");
int sumNumbers = GetSumNumbers(num);
Console.WriteLine($"{num} -> {sumNumbers}");

//Выводит в консоль сообщение message,
// преобразовывает введенную пользователем строку в число типа int,
// в случае ошибки выводит в консоль сообщение errorMessage

int GetNumbetFromUser(string message, string errorMessage) //  GetNumbetFromUser возвращает целое число --- 1. выводит сообщение 2. выводит ошибку
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
int GetSumNumbers(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number;
        number--;
    }
    return sum;
}