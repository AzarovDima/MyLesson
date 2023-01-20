// Углубляем изучать написание консоли С+

Console.Write("Введите ваше имя: ");
string username = Console.ReadLine() ?? "";
int user = int.Parse(username);

Console.Write($"Привет {user}");