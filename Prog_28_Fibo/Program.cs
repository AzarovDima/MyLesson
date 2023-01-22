/* Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

int inPutNumber = GetNumberFromUser();
int[] array = Fibo();
if (array == null)
    Console.Write("Ошибка!");
else
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
}

int[] Fibo()
{
    int n = inPutNumber;
    if (n == 1) return new int[1] { 0 };
    int i = 2;
    int[] result = new int[n];
    result[0] = 0;
    result[1] = 1;
    if (n == 2)
    {
        result[0] = 0;
        result[1] = 1;
    }

    while (i < n)
    {
        result[i] = result[i - 1] + result[i - 2];
        i++;
    }
    return result;

}