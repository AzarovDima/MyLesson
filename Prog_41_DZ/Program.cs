/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

/* int[] array = new int[GetNumberFromUser()];

Console.Write(String.Join(" ", array));

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
} */


int[] array = new int[5];
for (int i = 0; i < 5; ++i)
    array[i] = int.Parse(Console.ReadLine());
Console.Write(String.Join(" ", array));