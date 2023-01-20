/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10 */

int num1 = GetNumbetFromUser1("Введите целоечисло A: ", " Ошибка ввода!");

int GetNumbetFromUser1(string message, string errorMessage)
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

/* Console.Clear();

int[] array = new int[3];

FillArray(array);
bool result = CheckArray(array);
Console.WriteLine($"Треугольник со сторонами заданной длины существует: {(result ? "да" : "нет")}");


//Функции, используемые в программе
void FillArray(int[] collection)
{
    int lengthArray = collection.Length;
    for (int i = 0; i < lengthArray; i++)
    {
        while (true)
        {
            Console.Write($"Введите {i}-й элемент массива: ");
            bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
            if (isCorrect)
                {
                collection[i] = num;
                break;
                }
            else Console.WriteLine("Ошибка ввода!");
        }
    }
}

bool CheckArray(int[] arr)
{
    Console.WriteLine($"{String.Join(" ", arr)}");
    if (arr[0] + arr[1] > arr[2] && arr[1] + arr[2] > arr[0] && arr[0] + arr[2] > arr[1]) return true;
    else return false;
} */