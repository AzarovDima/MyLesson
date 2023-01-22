/* Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
 */
Console.Clear();

int[] array = GetArray(8, -100, 150);

Console.WriteLine($"[{String.Join(", ", array)}]");

int[] reversArray = ReversArray1(array);
Console.WriteLine($"[{String.Join(", ", reversArray)}]");

ReversArrat2(array);
Console.WriteLine($"[{String.Join(", ", array)}]");


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }

    return result;
}


int[] ReversArray1(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}
void ReversArrat2(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length - i - 1];
        inArray[inArray.Length - i - 1] = k;
    }
}