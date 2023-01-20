// Приветствуем по разному


Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine() ?? "";

if (username.ToLower() == "дима")
{
    Console.WriteLine("Ура, это же ДИМА!!! ");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
