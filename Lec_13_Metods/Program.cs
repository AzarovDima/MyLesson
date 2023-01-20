
// Метод 1  // Метод который ничего не возвращает и не принимает
void Method1()
{
    Console.WriteLine("Автор Д.А. Азаров!!!");
}
//Method1();

// Метод 2 // Методы которые не возвращают а принимают что либо.

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method1(msg: "Текст сообщения");
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Текст", count: 4);
//Method21(count: 4, msg: "новый текст");

// Метод 3  // Методы которые возвращают что-либо.

int Method3()
{
    return DateTime.Now.Year;
}
//int year = Method3();
//Console.WriteLine(year);


// Метод 4  // Методы которые возвращают что либо и принимают что либо

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "Это ");
Console.WriteLine(res);

