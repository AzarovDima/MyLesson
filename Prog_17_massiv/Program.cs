/* Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */

printArray();

void printArray()
{
    Console.Write("[");
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"{new Random().Next(0, 2)}");
        if (i < 7) Console.Write(", ");
    }
    Console.Write("]");

}