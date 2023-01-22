/* Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон. */
Console.Clear();
int[] array = new int[3];
FillArray(array);
bool result = CheckArray(array);
Console.WriteLine($"Треугольник со сторонами заданной длины существует: {(result ? "Yes" : "No")}");

void FillArray(int[] collection)
{
    int count = 0;
    while (count < 3)
    {
        while (true)
        {
            Console.Write($"Введите {count} число: ");
            bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
            if (isCorrect)
            {
                collection[count] = num;
                break;
            }
            else Console.Write("Ошибка ввода!! ");
        }
    count++;
    }
}
bool CheckArray(int[] arr)
{
    if ((arr[0] + arr[1] > arr[2]) && (arr[1] + arr[2] > arr[0]) && (arr[2] + arr[0] > arr[1]))
        return true;
    else return false;
}