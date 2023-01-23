/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */


static void Main(string[] args)
{
    int[] numbers = new int[args.Length];
    int temp;
    for (int i = 0; i < args.Length; i++)
    {
        if (Int32.TryParse(args[i], out temp))
        {
            numbers[i] = temp;
        }
        else
        {
            numbers[i] = 0;
        }
    }
}

int[] array = Main