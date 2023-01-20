/* . Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
 */

var rnd = new Random();
int num = rnd.Next(100, 1000);

int a1 = num / 100;
int a2 = num % 10;
int res = a1 * 10 + a2;

Console.WriteLine($"{num}-->{res}");