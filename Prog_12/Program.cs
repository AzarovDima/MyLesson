/* Задача 21: Напишите программу, которая принимает на вход координаты
двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21 */

Console.Clear();
Console.Write("Введите координаты первой точки Х: ");
int XA = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите координаты первой точки Y: ");
int YA = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите координаты второй точки Х: ");
int XB = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите координаты второй точки Y:  ");
int YB = int.Parse(Console.ReadLine() ?? "");

double result = Math.Sqrt(Math.Pow(XB - XA, 2) + Math.Pow(YB - YA, 2));

Console.WriteLine($"({XA}, {YA}) ({YA}, {YB}) ---> {result}");
