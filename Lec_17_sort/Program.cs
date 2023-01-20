
/*Упорядочить массивы
Было: 6 8 3 2 1 4 5 7
Стало: 1 8 3 2 6 4 5 7 */

int[] arr = { 5, 6, 8, 2, 6, 4, 3, 9, 2, 7, 0 };


void PtintArray(int[] array1)
{
    int count = array1.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array1[i]} ");
    }
    Console.WriteLine();
}
void SwlectionSort(int[] array2)
{
    for (int i = 0; i < array2.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array2.Length; j++)
        {
            if (array2[j] < array2[minPosition]) minPosition = j;
        }
        int temporary = array2[i];
        array2[i] = array2[minPosition];
        array2[minPosition] = temporary;
    }
}

PtintArray(arr);
SwlectionSort(arr);
PtintArray(arr);
