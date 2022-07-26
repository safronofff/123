Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if (username.ToLower() == "аня")
{
	Console.WriteLine("Привет Анютка!Как твои дела?!");
}
else
{
	Console.Write("Привет!");
	Console.WriteLine(username);
}