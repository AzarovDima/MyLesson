/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10 */

Console.Write(GetNumberFromUser());

int GetNumberFromUser()
{

    while (true)
    {
        Console.Write($"Введите чесло: ");
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect)
        {
            return num;
        }
        else Console.Write("Ошибка ввода!!! ");
    }
}

