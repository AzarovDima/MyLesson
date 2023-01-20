/* 
Задача 32: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]  */


Console.Write("Выполняется создание массива.. ");

int[] array = GetRandomArray(4, -10, 20);
Console.Write($"[{String.Join(", ", array)}]");

GetChangeNumber(array);
Console.Write(" -> ");
Console.Write($"[{String.Join(", ", array)}]");

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

void GetChangeNumber(int[] array2)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }

}

