// Нахождение элементов в массиве с заданным значением

//              0   1   2   3  4   5   6   7   8   9  10  11  12  13  14  15  16 
int[] array = { 23, 83, 31, 6, 4, 21, 73, 83, 12, 56, 21, 31, 43, 84, 342, 13, 83 };

int n = array.Length;
int find = 83;

int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}


