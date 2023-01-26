/* Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12 */


////////ТЕЛО ПРОГРАММЫ//////////////
//*******1 ВВОД ДАННЫХ*********
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);

//*******2 ВЫЧИСЛЕНИЕ**********
int sum = GetSumArray(array);
//*******3 ВЫВОД ДАННЫХ*********
PrintArray(array);
Console.Write(sum);


///////////////МЕТОДЫ/////////////////
//*******1 ВВОД ДАННЫХ*********

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
//*******2 ВЫЧИСЛЕНИЕ**********

int GetSumArray(int[,] array)
{
    int resolutionMin = Math.Min(array.GetLength(0), array.GetLength(1));
    int sum = 0;
    for (int i = 0; i < resolutionMin; i++)
    {
        sum = sum + array[i,i];
    }
    return sum;
}
//*********3 ВЫВОД ДАННЫХ*********
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}


/* Console.Clear();

int[,] array = FillArray(6, 2, 0, 9);
PrintArray(array);
int[,] newArray = ReversArray(array);
PrintArray(newArray);


// Функции, используемые в программе
int[,] FillArray(int m, int n, int minValue, int maxValue)
{
    int[,] inArray = new int[m, n];
    var rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        inArray[i, j] = rnd.Next(minValue, maxValue + 1);
    }
    return inArray;
}
 */
/* 
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        Console.Write($"{inArray[i, j]} ");
        Console.WriteLine();    
    }
    
} */


/* Console.Clear();

int[,] array = FillArray(6, 6, 0, 10);
PrintArray(array);
CheckArray(array, 0, 10);


void CheckArray(int[,] inArray, int minValue, int maxValue)
{
    Console.WriteLine();
    int[] countNumber = new int[maxValue - minValue];
    for (int x = 0; x < countNumber.Length; x++)
    {
        int amount = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                if (inArray[i,j] == x) amount += 1;

            }
        }
        countNumber[x] = amount;
        if (amount != 0)
        {
            if (amount % 10 == 2 || amount % 10 == 3 || amount % 10 == 4)
                Console.WriteLine($"{x} встречается {amount} раза");
            else
                Console.WriteLine($"{x} встречается {amount} раз");
        }
    }
} */