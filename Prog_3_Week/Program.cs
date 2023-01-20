//Пишем программу которая по заданнуму числу с клавиатуры от 1 до 7 выводит дни недели!!

Console.Write("Введите целое число от 1 до 7: ");
string userInput = Console.ReadLine() ?? "";
int number = int.Parse(userInput);

if (number == 1)
{
    Console.WriteLine("1 ----> Понедельник");
}
else if (number == 2)
{
    Console.WriteLine("2 ----> Вторник");
}
else if  (number == 3)
{
    Console.WriteLine("3 ----> Среда");
}
else if (number == 4)
{
    Console.WriteLine("4 ----> Четверг");
}
else if (number == 5)
{
    Console.WriteLine("5 ----> Пятинца");
}
else if (number == 6)
{
    Console.WriteLine("6 ----> Суббота");
}
else if (number == 7)
{
    Console.WriteLine("7 ----> Воскресенье");
}
else
{
    Console.WriteLine("Вы ввели не верное число!!!");
}