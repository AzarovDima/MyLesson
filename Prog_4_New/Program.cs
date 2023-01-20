/* 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8  
12-> 2 
85 -> 8*/

var rnd = new Random();
int num = rnd.Next(10, 100);

int a1 = num / 10;
int a2 = num % 10;

int max = a1;

if (a1 < a2) max = a2;

Console.WriteLine($"{num}: ---> {max}");