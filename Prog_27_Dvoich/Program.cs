/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10 */

// Console.Write(GetNumberFromUser());

int inPutNumber = GetNumberFromUser();
string dex = Dex();
Console.Write($"Число {inPutNumber} равняется {dex} в двоичной системе исчисления");

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

string Dex()
{
    int num = inPutNumber;
    string result = String.Empty;
    if (num == 0) return "0";
    while (num > 0)
    {
        result = (num % 2).ToString() + result;
        num = num / 2;
    }
    return result;
}

