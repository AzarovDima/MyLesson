/* 
Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4 */

int number;

while (true)
{
    Console.Write("Введите целое число: ");

    try
    {
        number = Convert.ToInt32(Console.ReadLine()!);
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода! {exc.Message}");
    }
}

int num_abs = Math.Abs(number);

Console.Write($"{number} ---> ");
int count = 1;

if (number == 0)
{
    Console.Write($"Отсутствуют числа от 1 до 0");
    return;
}

if (number != 0)
{
    while (count <= num_abs)
    {
        Console.Write($"{Math.Pow(count, 2)}, ");
        count++;
    }
}
