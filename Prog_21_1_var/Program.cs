/* Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да */

int[] array = GetRandomArray(20, 0, 11);
int b = CheckingTheEnteredNumber();
bool result = GetSameNumber(b, array);


Console.Write($"{b}; массив [{String.Join(", ", array)} -> {(result ? "Yes" : "No")}]");


bool GetSameNumber(int b, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == b)
            return true;
    }
    return false;
}

int CheckingTheEnteredNumber()
{
    Console.Write("Введите число: ");
    string a = Console.ReadLine() ?? "";
    bool number = int.TryParse(a, out int b);
    if (number)
    {
        Console.WriteLine("Число принято!!!");
    }
    else
    {
        Console.WriteLine("Не верный формат числа!!!");
        return (0);
    }
    return Math.Abs(b);
}
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}