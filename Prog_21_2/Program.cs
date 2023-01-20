/* Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да */

Console.Write("Выполняется создание массива.. ");

int[] array = GetRandomArray(8, -10, 20);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(minValue, maxValue);
    }

    return result;
}

int num = GetNumbetFromUser(" Введите целоечисло А: ", " Ошибка ввода!");

int GetNumbetFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

bool CheckArray(int num, int[] arr)
{
    int i = 0;
    bool f = false;
    while ((f == false) && (i < arr.Length))
    {
        if (num == arr[i]) f = true;
        i++;
    }
    return f;
}

if (CheckArray(num, array)) Console.Write(" -> YES");
else Console.WriteLine(" - > NO");