/* Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон. */


int[] triangle = new int[5];

int GetData(string DataName)
{
    int Data;
    while(true)
    {
        Console.Write($"Введите {DataName}: ");
        if (int.TryParse(Console.ReadLine(),out Data))
            return Data;
        Console.WriteLine("Ошибка ввода");
    }
}

for(int i = 1; i < 4; i++)
{
    triangle[i-1] = GetData($"сторону {i}");
}
triangle[3] = triangle[0];
triangle[4] = triangle[1];

string CheckTriangle(int[] triangle)
{
    int[] res = new int[3];
    for(int i = 0; i <= 2; i++)
    {
        
        res[i] = triangle[i+1] + triangle[i+2];
        if(res[i] <= triangle[i])
        {
            
return "такого треугольника быть не может";

        } 
    }
    return "такой треугольник существует";
       
}
Console.WriteLine(CheckTriangle(triangle));



/* 
Console.Clear();

int[] array = new int[3];

FillArray(array);
bool result = CheckArray(array);
Console.WriteLine($"Треугольник со сторонами заданной длины существует: {(result ? "да" : "нет")}");


//Функции, используемые в программе
void FillArray(int[] collection)
{
    int lengthArray = collection.Length;
    for (int i = 0; i < lengthArray; i++)
    {
        while (true)
        {
            Console.Write($"Введите {i}-й элемент массива: ");
            bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
            if (isCorrect)
                {
                collection[i] = num;
                break;
                }
            else Console.WriteLine("Ошибка ввода!");
        }
    }
}

bool CheckArray(int[] arr)
{
    Console.WriteLine($"{String.Join(" ", arr)}");
    if (arr[0] + arr[1] > arr[2] && arr[1] + arr[2] > arr[0] && arr[0] + arr[2] > arr[1]) return true;
    else return false;
} */











/* 
int num1 = GetNumbetFromUser1("Введите целоечисло A: ", " Ошибка ввода!");
int num2 = GetNumbetFromUser2("Введите целоечисло B: ", " Ошибка ввода!");
int num3 = GetNumbetFromUser3("Введите целоечисло C: ", " Ошибка ввода!");
int f = GetResult(num1, num2, num3);

int GetNumbetFromUser1(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
int GetNumbetFromUser2(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
int GetNumbetFromUser3(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}


bool GetResult(int num1, int num2, int num3)
{
    bool f = false;
    if (num1 < num2 + num3) f = true;
    else if (num2 < num1 + num3) f = true;
    else if (num3 < num2 + num3) f = true;
    else f = false;
    return f;
}
if GetResult(num1, num2, num3);(num, array)) Console.Write(" -> YES");
else Console.WriteLine(" - > NO");

 */