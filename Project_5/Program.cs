// Приветствуем по разному


Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username == "Дима")
{
    Console.WriteLine("Ура, это же Дима!!! ");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
