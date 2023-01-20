/* 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
и выдаёт номер четверти плоскости, в которой находится эта точка.
 */
/* int X = 0, Y = 0;
InitCoordinatesByUser(ref X, ref Y); */

/* Console.Clear();
Console.Write("Введите Х: ");
int X = int.Parse(Console.ReadLine() !);

Console.Write("Введите Y: ");
int Y = int.Parse(Console.ReadLine() !);

if (X > 0 && Y > 0)
{
    Console.WriteLine("1");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("2");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("3");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("4");
}
else
{
    Console.WriteLine("Ошибка! Точка попадает на оси координат!");
} */




int x = 0, y = 0;
InitCoordinatesByUser(ref x, ref y);    //Вызов метода с передачей параметров по ссылке ref
PrintQuarterByCoords(x, y);             //Вывоз метода с передачей параметров по значению

static void InitCoordinatesByUser(ref int x, ref int y)
{
    try
    {
        Console.Write("Введите Х: ");
        x = int.Parse(Console.ReadLine() !);

        Console.Write("Введите Y: ");
        y = int.Parse(Console.ReadLine() !);
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}
static void PrintQuarterByCoords(int x, int y)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("1");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("2");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("3");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("4");
    }
    else
        Console.WriteLine("Ошибка! Точка попадает на оси координат!");
}
